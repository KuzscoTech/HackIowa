using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crop_Models
{
    public class Wheat
    {
        string GrowTime;
        string SunlightExposureTime;
        string SoilConditions;
        string WaterFrequency;
        string Tools;

        double CostPerAcre;
        double YieldperAcre;
        double ReturnPerAcre;

        public Wheat()
        {
            GrowTime = "120 if planted in spring 240 if planted in fall";
            SunlightExposureTime = "full sun cycle";
            SoilConditions = "clay loam soil pH level between 6.0 and 7.0";
            WaterFrequency = "12-15 inches of rain over growing season";
            Tools = "Tools: pickaxe, hoe, and spade";
            YieldperAcre = 68.9;
            CostPerAcre = 327.16;
            ReturnPerAcre = 333.05;
        }

        public void EconInfo()
        {
            Console.WriteLine("Cost per acre: {0:C2}", CostPerAcre);
            Console.WriteLine("Return per acre: {0:C2}", ReturnPerAcre);
            Console.WriteLine("Yield per acre: {0} bushels", YieldperAcre);
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
