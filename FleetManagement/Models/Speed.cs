using System.Globalization;

namespace DotNet6Console.Models;
public class Speed : IFormattable
    
    {
        private readonly double _speed;


        public Speed(double speed)
        {
            _speed = speed;
        }
 
        public double MetersPerSecond()
        {
            return _speed * 0.514444444;
        }

        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            if (String.IsNullOrEmpty(format)) format = "KN";

            return format switch
            {
                "MS" => MetersPerSecond().ToString() + " m/s",
                _ => _speed.ToString() + " knots",
            };
        }

        public override string ToString()
        {
            return $"Speed: {ToString("", null)}";
        }

        public string ToString(string format)
        {
            return $"Speed: {ToString(format, null)}";
        }
}

