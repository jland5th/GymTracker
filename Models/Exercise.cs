namespace GymTracker.Models;

public class Exercise
{
    public string Name { get; set; } = "";

    public List<Set> Sets { get; set; } = new();
    public void Print()
        {
            Console.WriteLine($"{Name}");
            int setNum=1;
            foreach (var set in Sets)
            {
                Console.WriteLine($"Set {setNum}: {set.Weight} lb x {set.Reps} reps");
                setNum++;
            }
            Console.WriteLine();
        }
}
