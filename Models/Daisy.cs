using System;

namespace flower_shop
{
    public class Daisy : IBirthday
    {
        public string Color { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Water_schedule { get; set; }
        public double Cost { get; set; }
        public bool Thorny { get; set; }
        public bool Fragrant { get; set; }

        public override string ToString()
        {
            return $"{Color}";
        }
    }
}
