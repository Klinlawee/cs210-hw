namespace FitnessApp
{
    public abstract class Activity
    {
        public DateTime Date { get; private set; }
        public int DurationMinutes { get; private set; }

        public Activity(DateTime date, int durationMinutes)
        {
            Date = date;
            DurationMinutes = durationMinutes;
        }

        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();

        public virtual string GetSummary()
        {
            return $"{Date.ToShortDateString()} Activity ({DurationMinutes} min): Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
        }
    }
}
// This class represents a generic activity. It contains properties for the date and duration of the activity, and it defines abstract methods for calculating distance, speed, and pace. The GetSummary method provides a formatted string summarizing the activity details. The class is designed to be inherited by specific types of activities (e.g., Running, Cycling, Swimming) that implement the abstract methods with their own logic for calculating distance, speed, and pace.
// The constructor initializes the date and duration of the activity. The GetSummary method is virtual, allowing derived classes to override it if needed, but it provides a default implementation that can be used as is.