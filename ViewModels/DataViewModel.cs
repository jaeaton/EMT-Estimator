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
        private string cableLength = string.Empty;
        partial void OnCableLengthChanged(string value)
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
        [ObservableProperty]
        private string cableLengthUnit = string.Empty;
        [ObservableProperty]
        private string cableWeightAirUnit = string.Empty;
        [ObservableProperty]
        private string cableWeightWaterUnit = string.Empty;
        [ObservableProperty]
        private string instrumentWeightAirUnit = string.Empty;
        [ObservableProperty]
        private string instrumentWeightWaterUnit = string.Empty;
        [ObservableProperty]
        private string sampleWeightAirUnit = string.Empty;
        [ObservableProperty]
        private string sampleWeightWaterUnit = string.Empty;
        [ObservableProperty]
        private string instrumentAreaUnit = string.Empty;
        [ObservableProperty]
        private string coefficientOfDragUnit = string.Empty;
        [ObservableProperty]
        private string instrumentVelocityUnit = string.Empty;
        [ObservableProperty]
        private string pullOutTensionUnit = string.Empty;
        [ObservableProperty]
        private string estimatedMaximumTensionUnit = string.Empty;
        [ObservableProperty]
        private List<string> speedUnitList = new List<string>
                                                            {
                                                                "m/min",
                                                                "ft/min",
                                                                "kph",
                                                                "mph",
                                                                "m/sec"
                                                            };
        [ObservableProperty]
        private List<string> payoutUnitList = new List<string>
                                                            {
                                                                "m",
                                                                "ft",
                                                                "km"
                                                            };
        [ObservableProperty]
        private List<string> tensionUnitList = new List<string>
                                                            {
                                                                "lbf",
                                                                "kg",
                                                                "kip",
                                                                "N",
                                                                "Short Ton",
                                                                "Long Ton",
                                                                "Tonne"
                                                            };
        [ObservableProperty]
        private List<string> instrumentAreaUnitList = new List<string>
                                                            {
                                                                "in^2",
                                                                "ft^2",
                                                                "cm^2",
                                                                "m^2"
                                                            };
        [ObservableProperty]
        private List<string> weightPerLengthUnitList = new List<string>
                                                            {
                                                                "lbf/kft",
                                                                "kg/km"
                                                            };

        public static void Calculate()
        {
            CalculationViewModel.Calculations();
        }
    }
}
