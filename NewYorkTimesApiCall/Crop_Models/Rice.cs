using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crop_Models
{
    public class Rice
    {
         
        string GrowTime;
        string SunlightExposureTime;
        string SoilConditions;
        string WaterFrequency;
        string Tools;

        double CostPerAcre;
        double YieldperAcre;
        double ReturnPerAcre;

        public Rice()
        {
            GrowTime = "150 to 180 days";
            SunlightExposureTime = "Subsurface water irrigation";
            SoilConditions = "sandy soils or clay soils";
            WaterFrequency = "Subsurface water irrigation";
            Tools = "Sickle";
            YieldperAcre = 938;
            CostPerAcre = 773.44;
            ReturnPerAcre = 823;
        }

        public string EconInfo()
        {

            return "Cost per acre: " + CostPerAcre + "\n" + "Return per acre: " + ReturnPerAcre + "\n" + "Yield per acre: " + YieldperAcre + "\n";
        }

        public string PlantingInfo()
        {
            return "Grow time of crop: " + GrowTime + "\n" + "Soil conditions: " + SoilConditions + "\n" + "Sunlight needs of crop: " + 
                SunlightExposureTime + "\n" + "Water frequency of crop: " + WaterFrequency + "\n" + "Tools required for crop: " + Tools + "\n";
        }

        public double CostCalculator(int _acres)
        {
            double product = _acres * CostPerAcre;

            return product;
        }

        public double ReturnCalculator(int _acres)
        {
            double product = _acres * ReturnPerAcre;

            return product;
        }
    }
}

