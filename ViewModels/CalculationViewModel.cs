namespace ViewModels 
{
    public partial class CalculationViewModel : ViewModelBase
    {
        
        public static DataViewModel data = new DataViewModel();

        [RelayCommand]
        private void CalculateButton()
        {

        }

        public static void Calculations()
        {
            double airCableWeight = 0;
            double waterCableWeight = 0;
            double lengthCable = 0;
            double rho = 63.677; //Density of Seawater in lbf/ft^3
            double g = 0.75; //acceleration due to heave, 0.75 per ABS
            double convertMtoFt = 3.281; //Conversion factor for m/s to ft/s
            double convertMtoKft = convertMtoFt/1000; //Conversion factor for m to kft
            double convertFtToIn = 12; //conversion from ft to in
            if (data.Cable)
            {
                if(!double.TryParse(data.CableLength, out lengthCable))
                {
                    lengthCable = 0;
                }   
                if (!double.TryParse(data.CableWeightAir, out airCableWeight))
                {
                    airCableWeight = 0;
                }
                if (!double.TryParse(data.CableWeightWater, out waterCableWeight))
                {
                    waterCableWeight = 0;
                }
            }
            if(!double.TryParse(data.InstrumentWeightAir, out double airInstrumentWeight))
            {
                airInstrumentWeight = 0;
            }
            if(!double.TryParse(data.InstrumentWeightWater, out double waterInstrumentWeight))
            {
                waterInstrumentWeight = 0;
            }
            if(!double.TryParse(data.SampleWeightAir, out double airSampleWeight))
            {
                airSampleWeight = 0;
            }
            if(!double.TryParse(data.SampleWeightWater, out double waterSampleWeight))
            {
                waterSampleWeight = 0;
            }
            if(!double.TryParse(data.InstrumentArea, out double areaInstrument))
            {
                areaInstrument = 0;
            }
            if(!double.TryParse(data.CoefficientOfDrag, out double cod))
            {
                cod = 0;
            }
            if(!double.TryParse(data.InstrumentVelocity, out double velocity))
            {
                velocity = 0;
            }
            if(!double.TryParse(data.PullOutTension, out double tensionPullOut))
            {
                tensionPullOut = 0;
            }

            //Check if velocity needs to be converted
            velocity = velocity * convertMtoFt;

            //Check if area needs to be converted
            areaInstrument = areaInstrument /( convertFtToIn * convertFtToIn);

            //Check it water weights & length need to be converted
            double staticLoad = waterCableWeight * lengthCable * convertMtoKft + waterInstrumentWeight + waterSampleWeight;

            //Check if pull out tension needs to be converted
            double transientLoad = tensionPullOut;

            //Calculate quasi static load in lbf using velocity and area
            double quasiStaticLoad = (areaInstrument*cod*rho*velocity*velocity)/(2*32.174);

            //Check if air weights & length need to be converted
            double dynamicLoad = (airCableWeight*lengthCable * convertMtoKft + airInstrumentWeight + airSampleWeight)*g;

            //Calculate total tension
            double total = staticLoad + transientLoad + quasiStaticLoad + dynamicLoad;

            //Check if total tension needs to be converted

            data.EstimatedMaximumTension = total.ToString();
        }
    }
}
