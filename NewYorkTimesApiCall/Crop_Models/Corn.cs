using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crop_Models
{
    public class Corn
    {
        string GrowTime;
        string SunlightExposureTime;
        string SoilConditions;
        string WaterFrequency;
        string Tools;

        double CostPerAcre;
        double YieldperAcre;
        double ReturnPerAcre;

        public Corn()
        {
            GrowTime = "90 to 120 days";
            SunlightExposureTime = "Six hours";
            SoilConditions = "loam soils, soil pH level between 5.5 and 7.0";
            WaterFrequency = "2 to 3 times weekly";
            Tools = "spade, compost, 5-10-5 fertilizer, plant collars";
            YieldperAcre = 181.8;
            CostPerAcre = 695.48;
            ReturnPerAcre = 699.00;
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
