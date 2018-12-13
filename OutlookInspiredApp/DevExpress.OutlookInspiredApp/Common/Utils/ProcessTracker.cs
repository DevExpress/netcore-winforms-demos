namespace DevExpress.DevAV {
    using System;
    using System.Collections.Generic;

    abstract class ProcessTracker : IObservable<string> {
        IList<IObserver<string>> observers;
        protected ProcessTracker() {
            observers = new List<IObserver<string>>();
        }
        public IDisposable StartTracking(IProcess process) {
            return new TrackingContext(process, this);
        }
        IDisposable IObservable<string>.Subscribe(IObserver<string> observer) {
            return new Subscription(this, observer);
        }
        void process_Start(object sender, ProcessStatusEventArgs e) {
            foreach(IObserver<string> observer in observers)
                observer.OnNext(e.Status);
        }
        void process_Running(object sender, ProcessStatusEventArgs e) {
            foreach(IObserver<string> observer in observers)
                observer.OnNext(e.Status);
        }
        void process_Complete(object sender, EventArgs e) {
            foreach(IObserver<string> observer in observers)
                observer.OnCompleted();
        }
        class TrackingContext : IDisposable {
            IProcess process;
            ProcessTracker tracker;
            public TrackingContext(IProcess process, ProcessTracker tracker) {
                process.Start += tracker.process_Start;
                process.Running += tracker.process_Running;
                process.Complete += tracker.process_Complete;
                this.process = process;
                this.tracker = tracker;
            }
            void IDisposable.Dispose() {
                process.Start -= tracker.process_Start;
                process.Running -= tracker.process_Running;
                process.Complete -= tracker.process_Complete;
                this.tracker = null;
                this.process = null;
            }
        }
        class Subscription : IDisposable {
            IObserver<string> observer;
            ProcessTracker tracker;
            public Subscription(ProcessTracker tracker, IObserver<string> observer) {
                if(!tracker.observers.Contains(observer))
                    tracker.observers.Add(observer);
                this.tracker = tracker;
                this.observer = observer;
            }
            void IDisposable.Dispose() {
                tracker.observers.Remove(observer);
            }
        }
    }
}