namespace GymTracker.Models;
public class Workout{
    public DateTime Date {get; set;}
    public string WorkoutType {get; set;} ="";
    public List<Exercise> Exercises {get; set;} = new();
}