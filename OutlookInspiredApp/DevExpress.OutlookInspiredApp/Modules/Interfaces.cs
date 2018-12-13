namespace DevExpress.DevAV.Modules {
    using DevExpress.XtraBars.Ribbon;

    public interface IRibbonModule {
        RibbonControl Ribbon { get; }
    }
    public interface ISupportViewModel {
        object ViewModel { get; }
        void ParentViewModelAttached();
    }
}