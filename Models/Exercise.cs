namespace GymTracker.Models;

public class Exercise
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string MuscleGroup { get; set; } = "";   // e.g. "Chest", "Legs"

    public void Print()
    {
        Console.WriteLine($"{Name} ({MuscleGroup})");
    }
}