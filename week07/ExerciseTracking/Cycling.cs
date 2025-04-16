namespace FitnessApp
{
    public class Cycling : Activity
    {
        public double Speed { get; private set; }

        public Cycling(DateTime date, int durationMinutes, double speed)
            : base(date, durationMinutes)
        {
            Speed = speed;
        }

        public override double GetDistance()
        {
            return (Speed * DurationMinutes) / 60;
        }

        public override double GetSpeed()
        {
            return Speed;
        }

        public override double GetPace()
        {
            return 60 / Speed;
        }
    }
}
