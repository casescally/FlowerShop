namespace flower_shop
{
    public class Sunflower : IBirthday
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double Cost { get; set; }
        public string Water_schedule { get; set; }
        public bool Thorny { get; set; }
        public bool Fragrant { get; set; }
        public string Color { get; set; }
    }
}