using GymTracker.Services;
namespace GymTracker.Models;
public class Workout{
    public DateTime Date {get; set;}
    public string WorkoutType {get; set;} ="";
    public List<LoggedExercise> Exercises {get; set;} = new();
    public void Print()
        {
            Console.WriteLine($"{WorkoutType} - {Date:d}");
            Console.WriteLine("-------------------------");
            foreach (var loggedExercise in Exercises)
            {
                var definition = ExerciseService.GetById(loggedExercise.ExerciseId);
                string name = definition?.Name ?? "Unknown Exercise";
                loggedExercise.Print(name);
            }
            Console.WriteLine("-------------------------");
        }
    public void AddExercise(LoggedExercise exercise)
{
    Exercises.Add(exercise);
}
}