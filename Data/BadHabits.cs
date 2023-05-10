
namespace AdmiPanel_HealthApp.Data 
{   
    public enum Habit
{
    Smoking,
    Drinking,
    Dragging
}
    public enum Freqency
{
    Common,
    Often,
    Sometimes,
    FromTimeToTime,
    Rarely,
    UsedTo
}

    public class BadHabits
    {
        public int BadHabitId { get; set; }
        public Habit HabitType { get; set; }
        public Freqency HabitFrequency { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    } 
}