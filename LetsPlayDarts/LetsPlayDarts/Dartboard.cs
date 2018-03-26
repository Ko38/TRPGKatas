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
        
        private readonly string[] _baseScore = {"6" ,"13","4" ,"18","1" ,"20","5" ,"12","9" ,"14","11","8" ,"16","7" ,"19","3" ,"17","2" ,"15","10"};

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
            return GetScoreText(distance).Replace("{point}", CalculateBaseScore(angle));
        }

        //-9 to 9 : index 0 , // 9 to 27 : index 1 , ...
        private string CalculateBaseScore(double angle)
        {
            angle += 9;
            if (angle < 0) angle += 360;
            int index = (int)angle / 18;
            return _baseScore[index];
        }

        private double CalculateDistanceByPythagoreanTheorem(double x, double y)
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }
    }
}
