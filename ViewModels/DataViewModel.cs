namespace ViewModels
{
    public partial class DataViewModel : ViewModelBase
    {
        [ObservableProperty]
        private bool termination = false;
        [ObservableProperty]
        private bool cable = true;
        partial void OnCableChanged(bool value)
        {
            Calculate();
        }
        [ObservableProperty]
        private string cableWeightAir = string.Empty;
        partial void OnCableWeightAirChanged(string value)
        {
            Calculate();
        }
        [ObservableProperty]
        private string cableWeightWater = string.Empty;
        partial void OnCableWeightWaterChanged(string value)
        {
            Calculate();
        }
        [ObservableProperty]
        private string instrumentWeightAir = string.Empty;
        partial void OnInstrumentWeightAirChanged(string value)
        {
            Calculate();
        }
        [ObservableProperty]
        private string instrumentWeightWater = string.Empty;
        partial void OnInstrumentWeightWaterChanged(string value)
        {
            Calculate();
        }
        [ObservableProperty]
        private string sampleWeightAir = string.Empty;
        partial void OnSampleWeightAirChanged(string? oldValue, string newValue)
        {
            Calculate();
        }
        [ObservableProperty]
        private string sampleWeightWater = string.Empty;
        partial void OnSampleWeightWaterChanged(string value)
        {
            Calculate();
        }
        [ObservableProperty]
        private string instrumentArea = string.Empty;
        partial void OnInstrumentAreaChanged(string value)
        {
            Calculate();
        }
        [ObservableProperty]
        private string coefficientOfDrag = string.Empty;
        partial void OnCoefficientOfDragChanged(string value)
        {
            Calculate();
        }
        [ObservableProperty]
        private string instrumentVelocity = string.Empty;
        partial void OnInstrumentVelocityChanged(string value)
        {
            Calculate();
        }
        [ObservableProperty]
        private string pullOutTension = string.Empty;
        partial void OnPullOutTensionChanged(string value)
        {
            Calculate();
        }
        [ObservableProperty]
        private string estimatedMaximumTension = string.Empty;

        public static void Calculate()
        {
            CalculationViewModel.Calculations();
        }
    }
}
