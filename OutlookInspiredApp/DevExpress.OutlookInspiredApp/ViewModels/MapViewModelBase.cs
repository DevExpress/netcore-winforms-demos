namespace DevExpress.DevAV.ViewModels {
    public abstract partial class MapViewModelBase {
        public const string WinBingKey = DevExpress.Map.Native.DXBingKeyVerifier.BingKeyWinOutlookInspiredApp;
        public const string WpfBingKey = DevExpress.Map.Native.DXBingKeyVerifier.BingKeyWpfOutlookInspiredApp;
        public virtual Address Address { get; set; }
    }
}