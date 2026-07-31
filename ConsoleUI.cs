namespace GymTracker.UI;

using GymTracker.Models;
using GymTracker.Services;

public class ConsoleUI
{
    private readonly List<Workout> _workouts;

    public ConsoleUI()
    {
        _workouts = WorkoutService.Load();
    }

    public void Run()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Gym Tracker ===");
            Console.WriteLine("1. Add Workout");
            Console.WriteLine("2. View Workouts");
            Console.WriteLine("3. Add Predefined Workout");
            Console.WriteLine("4. Clear All Workouts");
            Console.WriteLine("0. Exit");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddWorkout();
                    break;
                case "2":
                    ViewWorkouts();
                    break;
                case "3":
                    AddPredefinedWorkout();
                    break;
                case "4":
                    ClearWorkouts();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    private void AddWorkout()
    {
        Console.Write("Workout Type: ");
        string workoutType = Console.ReadLine() ?? "";
        var workout = new Workout { Date = DateTime.Now, WorkoutType = workoutType };

        while (true)
        {
            Console.Write("Add Exercise? (y/n): ");
            if ((Console.ReadLine() ?? "").ToLower() != "y") break;

            var exercise = CreateLoggedExercise();   // build from input (UI)
            workout.AddExercise(exercise);           // attach (model logic)
        }

        _workouts.Add(workout);
        WorkoutService.Save(_workouts);
        Console.WriteLine("Workout Added!");
        Console.ReadKey();
    }

    private LoggedExercise CreateLoggedExercise()
    {
        var catalog = ExerciseService.Load();
        Console.WriteLine("Choose an exercise:");
        foreach (var ex in catalog)
            Console.WriteLine($"{ex.Id}. {ex.Name}");

        int exerciseId = ReadInt("Exercise Id: ");

        int numberOfSets = ReadInt("Number of Sets: ");
        var sets = new List<Set>();
        for (int i = 1; i <= numberOfSets; i++)
        {
            Console.WriteLine($"Set #{i}");
            int weight = ReadInt("Weight: ");
            int reps = ReadInt("Number of Reps: ");
            sets.Add(new Set { Reps = reps, Weight = weight });
        }

        return new LoggedExercise { ExerciseId = exerciseId, Sets = sets };
    }

    private void AddPredefinedWorkout()
    {
        Console.WriteLine("1. Push");
        Console.WriteLine("2. Pull");
        Console.WriteLine("3. Legs");
        Console.Write("Select workout: ");
        var choice = Console.ReadLine();
        Workout? workout = choice switch
        {
            "1" => WorkoutTemplates.Push(),
            "2" => WorkoutTemplates.Pull(),
            "3" => WorkoutTemplates.Legs(),
            _ => null
        };

        if (workout == null)
        {
            Console.WriteLine("Invalid selection");
        }
        else
        {
            _workouts.Add(workout);
            WorkoutService.Save(_workouts);
            Console.WriteLine($"{workout.WorkoutType} workout added!");
        }
        Console.ReadKey();
    }

    private void ViewWorkouts()
    {
        Console.WriteLine();
        if (_workouts.Count == 0)
        {
            Console.WriteLine("No Workouts Found");
        }
        else
        {
            foreach (var workout in _workouts)
                workout.Print();
        }
        Console.ReadKey();
    }

    private void ClearWorkouts()
    {
        WorkoutService.Clear();
        _workouts.Clear();
        Console.WriteLine("All workouts cleared!");
        Console.ReadKey();
    }

    private int ReadInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int value))
            {
                if (value < 1)
                {
                    Console.WriteLine("Please enter a number greater than 0.");
                    continue;
                }
                return value;
            }
            Console.WriteLine("Please enter a whole number.");
        }
    }
}