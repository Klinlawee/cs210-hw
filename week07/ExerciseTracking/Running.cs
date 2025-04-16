namespace FitnessApp
{
    public class Running : Activity
    {
        public double Distance { get; private set; }

        public Running(DateTime date, int durationMinutes, double distance)
            : base(date, durationMinutes)
        {
            Distance = distance;
        }

        public override double GetDistance()
        {
            return Distance;
        }

        public override double GetSpeed()
        {
            return (Distance / DurationMinutes) * 60;
        }

        public override double GetPace()
        {
            return DurationMinutes / Distance;
        }
    }
}
// // This class represents a running activity. It inherits from the Activity class and implements the methods to calculate distance, speed, and pace based on the distance run. The distance is provided directly as a parameter in kilometers. The speed is calculated as distance per minute, and the pace is calculated as time per kilometer.
// // The class constructor takes the date of the activity, the duration in minutes, and the distance run as parameters. The GetDistance, GetSpeed, and GetPace methods are overridden to provide specific calculations for running activities.