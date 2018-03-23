using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPlayDarts
{
    public class Dartboard
    {
        private readonly Dictionary<double, string> _radiusToResult = new Dictionary<double, string>()
            {
                {12.70 / 2, "DB" },
                {31.80 / 2, "SB" },
                {198 / 2, "{point}" },
                {214 / 2, "T{point}" },
                {324 / 2, "{point}" },
                {340 / 2, "D{point}" }
            };
        private readonly Dictionary<double, string> _angleToScore = new Dictionary<double, string>()
            {
                {9, "6" },
                {27, "13" },
                {45, "4" },
                {63, "18" },
                {81, "1" },
                {99, "20" },
                {117, "5" },
                {135, "12" },
                {153, "9" },
                {171, "14" },
                {189, "11" },
                {207, "8" },
                {225, "16" },
                {243, "7" },
                {261, "19" },
                {279, "3" },
                {297, "17" },
                {315, "2" },
                {333, "15" },
                {351, "10" }
            };

        private string GetScoreText(double distance)
        {
            foreach (var item in _radiusToResult)
            {
                if (distance < item.Key)
                {
                    return item.Value;
                }
            }
            return "X";
        }


        public string GetScore(double x, double y)
        {
            var distance = CalculateDistanceByPythagoreanTheorem(x, y);
            var angle = Math.Atan2(y, x) * 180.0 / Math.PI;
            return GetScoreText(distance).Replace("{point}", GetPoint(angle));
        }

        private string GetPoint(double angle)
        {
            if (angle < -9) angle += 360;
            foreach(var item in _angleToScore)
            {
                if(angle < item.Key) return item.Value;
            }
            return null;
        }

        private double CalculateDistanceByPythagoreanTheorem(double x, double y)
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }
    }
}
