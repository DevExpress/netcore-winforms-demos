using System;
using System.Collections.Generic;

namespace DevExpress.StockMarketTrader.Model {
    public enum ActionPriority {
        Normal,
        High,
        Blocked
    }

    public enum ExecutorStatus {
        Enabled,
        Disabled,
        Offline
    }

    public class UserStateParams {
        public Delegate Callback { get; private set; }
        public int ActionID { get; set; }

        public UserStateParams(Delegate callback, int actionID) {
            if(callback != null)                                         
                Callback = callback;
            ActionID = actionID;
        }
    }

    public class ExecutorAction {
        readonly Delegate method;
        readonly ActionPriority priority;
        readonly object[] args;

        public object[] Args { get { return args; } }
        public Delegate Method { get { return method; } }
        public ActionPriority Priority { get { return priority; } }

        public ExecutorAction(Delegate method, ActionPriority priority, object[] args) {
            this.method = method;
            this.priority = priority;
            this.args = args;
        }
    }

    public class Executor {
        readonly Stack<ExecutorAction> actions;
        readonly NetworkMonitor networkMonitor;
        ExecutorAction currentAction;
        ExecutorStatus status = ExecutorStatus.Disabled;
        int userID = 0, executingActions = 0;

        public event EventHandler ExecuteFailed;

        public int UserID { get { return userID; } }
        public int ExecutingActions { get { return executingActions; } }
        public ExecutorStatus Status {
            get { return status; }
            set {
                status = value;
                if (value == ExecutorStatus.Enabled)
                    TryExecute(false);
                if (value == ExecutorStatus.Disabled && currentAction != null)
                    actions.Push(currentAction);
            }
        }

        public Executor(NetworkMonitor networkMonitor) {
            this.networkMonitor = networkMonitor;
            actions = new Stack<ExecutorAction>();
        }
        bool CanExecuteByNetwork() {
            bool isAvaliable = networkMonitor.IsInternetAvaliable;
            return isAvaliable || (!isAvaliable && status == ExecutorStatus.Offline);
        }
        void RaiseExecuteFailed() {
            ExecuteFailed(this, EventArgs.Empty);
        }
        void TryExecute(bool isForceExecute) {
            if (CanExecuteByNetwork() && actions.Count != 0 && (status != ExecutorStatus.Disabled && (actions.Peek().Priority != ActionPriority.Blocked || isForceExecute))) {
                currentAction = actions.Pop();
                BeginExecute(currentAction);
            }
        }
        void BeginExecute(ExecutorAction action) {
            try {
                executingActions++;
                action.Method.DynamicInvoke(action.Args);
            }
            catch {
                RaiseExecuteFailed();
            }
        }
        void Completed(object sender, EventArgs e) {
            ExecuteCompleted();
        }
        public void AddAction(ExecutorAction action) {
            actions.Push(action);
            TryExecute(false);
        }
        public void ExecuteCompleted() {
            TryExecute(false);
        }
        public void ChangeUserID() {
            actions.Clear();
            userID++;
        }
        public void ForceExecute() {
            TryExecute(true);
        }
        public void EndExecute(IAsyncResult result) {
            try {
                executingActions--;
                UserStateParams state = result.AsyncState as UserStateParams;
                if (state.ActionID == userID && state.Callback != null && status != ExecutorStatus.Disabled && CanExecuteByNetwork())
                    state.Callback.DynamicInvoke(new object[] { result });
            }
            catch {
                RaiseExecuteFailed();
            }
        }
    }
}
