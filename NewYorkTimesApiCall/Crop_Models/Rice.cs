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

        public void EconInfo()
        {
            Console.WriteLine("Cost per acre: {0:C2}", CostPerAcre);
            Console.WriteLine("Return per acre: {0:C2}", ReturnPerAcre);
            Console.WriteLine("Yield per acre: {0} lbs", YieldperAcre);
        }

        public void PlantingInfo()
        {
            Console.WriteLine("Grow time of crop: {0}", GrowTime);
            Console.WriteLine("Soil conditions: {0}", SoilConditions);
            Console.WriteLine("Sunlight needs of crop: {0}", SunlightExposureTime);
            Console.WriteLine("Water frequency of crop: {0}", WaterFrequency);
            Console.WriteLine("Tools required for crop: {0}", Tools);
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

