namespace DevExpress.DevAV {
    using System;

    public interface IProcess {
        event ProcessStatusEventHandler Start;
        event ProcessStatusEventHandler Running;
        event EventHandler Complete;
    }
    public delegate void ProcessStatusEventHandler(
            object sender, ProcessStatusEventArgs e
        );
    public class ProcessStatusEventArgs : EventArgs {
        public ProcessStatusEventArgs(string status) {
            Status = status;
        }
        public string Status { get; private set; }
    }
    //
    class StartUpProcess : IProcess, IDisposable {
        static StartUpProcess process;
        IDisposable tracker;
        public StartUpProcess() {
            process = this;
            tracker = StartUpProcessTracker.Instance.StartTracking(this);
        }
        void IDisposable.Dispose() {
            tracker.Dispose();
            process = null;
        }
        public static IObservable<string> Status {
            get { return StartUpProcessTracker.Instance; }
        }
        public static void OnStart(string status) {
            if(process != null)
                process.RaiseStart(status);
        }
        public static void OnRunning(string status) {
            if(process != null)
                process.RaiseRunning(status);
        }
        public static void OnComplete() {
            if(process != null)
                process.RaiseComplete();
        }
        #region ProcessTracker
        class StartUpProcessTracker : ProcessTracker {
            internal static StartUpProcessTracker Instance = new StartUpProcessTracker();
        }
        #endregion ProcessTracker
        #region IProcess Members
        ProcessStatusEventHandler startCore;
        event ProcessStatusEventHandler IProcess.Start {
            add { startCore += value; }
            remove { startCore -= value; }
        }
        ProcessStatusEventHandler runningCore;
        event ProcessStatusEventHandler IProcess.Running {
            add { runningCore += value; }
            remove { runningCore -= value; }
        }
        EventHandler completeCore;
        event EventHandler IProcess.Complete {
            add { completeCore += value; }
            remove { completeCore -= value; }
        }
        void RaiseStart(string status) {
            if(startCore != null)
                startCore(this, new ProcessStatusEventArgs(status));
        }
        void RaiseRunning(string status) {
            if(runningCore != null)
                runningCore(this, new ProcessStatusEventArgs(status));
        }
        void RaiseComplete() {
            if(completeCore != null)
                completeCore(this, EventArgs.Empty);
        }
        #endregion
    }
}