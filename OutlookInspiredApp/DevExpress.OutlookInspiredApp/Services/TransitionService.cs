namespace DevExpress.DevAV.Services {
    using System;

    public interface ITransitionService {
        void StartTransition(bool forward, object waitParameter);
        void EndTransition();
    }
    class TransitionService : ITransitionService {
        ISupportTransitions supportTransitions;
        public TransitionService(ISupportTransitions supportTransitions) {
            this.supportTransitions = supportTransitions;
        }
        public void StartTransition(bool forward, object waitParameter) {
            supportTransitions.StartTransition(forward, waitParameter);
        }
        public void EndTransition() {
            supportTransitions.EndTransition();
        }
    }
    public static class TransitionServiceExtension {
        public static IDisposable EnterTransition(this ITransitionService service,
            bool effective = true,
            bool forward = true,
            object waitParameter = null) {
            return new TransitionBatch(effective ? service : null, forward, waitParameter);
        }
        class TransitionBatch : IDisposable {
            ITransitionService service;
            public TransitionBatch(ITransitionService service, bool forward, object waitParameter) {
                this.service = service;
                if(service != null)
                    service.StartTransition(forward, waitParameter);
            }
            public void Dispose() {
                if(service != null)
                    service.EndTransition();
            }
        }
    }
}