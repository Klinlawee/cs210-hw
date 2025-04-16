namespace FitnessApp
{
    public class Swimming : Activity
    {
        public int Laps { get; private set; }

        public Swimming(DateTime date, int durationMinutes, int laps)
            : base(date, durationMinutes)
        {
            Laps = laps;
        }

        public override double GetDistance()
        {
            return Laps * 50 / 1000.0;
        }

        public override double GetSpeed()
        {
            return (GetDistance() / DurationMinutes) * 60;
        }

        public override double GetPace()
        {
            return DurationMinutes / GetDistance();
        }
    }
}
// // This class represents a swimming activity. It inherits from the Activity class and implements the methods to calculate distance, speed, and pace based on the number of laps swum. The distance is calculated by multiplying the number of laps by 50 meters (assuming a standard pool length) and converting it to kilometers. The speed is calculated as distance per minute, and the pace is calculated as time per kilometer.
// // The class constructor takes the date of the activity, the duration in minutes, and the number of laps swum as parameters. The GetDistance, GetSpeed, and GetPace methods are overridden to provide specific calculations for swimming activities.