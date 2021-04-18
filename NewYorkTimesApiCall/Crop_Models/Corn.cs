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

        public string EconInfo()
        {
            return "Cost per acre: " + CostPerAcre + "\n" + "Return per acre: " + ReturnPerAcre + "\n" +
            "Yield per acre: " + YieldperAcre + "\n";

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
