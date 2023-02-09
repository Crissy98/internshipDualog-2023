using System.Globalization;

namespace DotNet6Console.Models;
public class Speed : IFormattable
    {
        private double speed;


        public Speed(double speed)
        {
            this.speed = speed;
        }

        public double MetersPerSecond()
        {
            return speed * 0.514444444;
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            switch (format)
            {
                case "MS":
                    return MetersPerSecond().ToString() + " m/s";
                case "KN":
                    return speed.ToString() + " knots";
                default:
                    return speed.ToString() + " knots";
            }
        }

        /*public override string ToString()
        {
            return $"Speed(KN): {0}, Speed(KN): {1}, {speed.ToString("KN",null)},{speed.ToString("MS",null)}";
        }*/
}

