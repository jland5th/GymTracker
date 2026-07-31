namespace GymTracker.Models;

public class LoggedExercise
{
    public int ExerciseId { get; set; }             // references Exercise.Id
    public List<Set> Sets { get; set; } = new();

    public void Print(string exerciseName)
    {
        Console.WriteLine($"{exerciseName}");
        int setNum = 1;
        foreach (var set in Sets)
        {
            Console.WriteLine($"Set {setNum}: {set.Weight} lb x {set.Reps} reps");
            setNum++;
        }
        Console.WriteLine();
    }
}