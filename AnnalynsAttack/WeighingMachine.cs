
namespace Batch
{
    class WeighingMachine
    {
        public int Precision { get; private set;}

        public double TareAdjustment { get; set; } = 5;

        private double weight;
        public double Weight
        {
            get { return weight; }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException();
                weight = value;
            }
        }

        public string DisplayWeight
        {
            get { return $"{(Weight - TareAdjustment).ToString($"f{Precision}")} kg"; }
        }

        public WeighingMachine(int precision)
        {
            Precision = precision;
        }
    }
}
