namespace flower_shop {
    public class Rose : IMothersDay {
        public string Name { get; set; }
        public string Type { get; set; }
        public double Cost { get; set; }
        public string Water_schedule { get; }
        public bool Thorny { get; }
        public bool Fragrant { get; }
        public double StemLength { get; set; }

        public override string ToString () {
            return $"{Name}";
        }
    }
}