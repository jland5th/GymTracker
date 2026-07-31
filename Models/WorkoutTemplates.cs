namespace GymTracker.Models;

public static class WorkoutTemplates
{
    public static Workout Push() => new()
    {
        Date = DateTime.Today,
        WorkoutType = "Push",
        Exercises = new()
        {
            new Exercise { Name = "Bench Press", Sets = new()
            {
                new Set { Weight = 135, Reps = 10 },
                new Set { Weight = 155, Reps = 8 },
                new Set { Weight = 175, Reps = 6 },
            }},
            new Exercise { Name = "Overhead Press", Sets = new()
            {
                new Set { Weight = 75, Reps = 10 },
                new Set { Weight = 85, Reps = 8 },
                new Set { Weight = 95, Reps = 6 },
            }},
            new Exercise { Name = "Incline Dumbbell Press", Sets = new()
            {
                new Set { Weight = 50, Reps = 12 },
                new Set { Weight = 55, Reps = 10 },
                new Set { Weight = 60, Reps = 8 },
            }},
            new Exercise { Name = "Lateral Raise", Sets = new()
            {
                new Set { Weight = 15, Reps = 15 },
                new Set { Weight = 15, Reps = 15 },
                new Set { Weight = 20, Reps = 12 },
            }},
            new Exercise { Name = "Triceps Pushdown", Sets = new()
            {
                new Set { Weight = 40, Reps = 15 },
                new Set { Weight = 50, Reps = 12 },
                new Set { Weight = 60, Reps = 10 },
            }},
        }
    };

    public static Workout Pull() => new()
    {
        Date = DateTime.Today,
        WorkoutType = "Pull",
        Exercises = new()
        {
            new Exercise { Name = "Deadlift", Sets = new()
            {
                new Set { Weight = 225, Reps = 8 },
                new Set { Weight = 275, Reps = 5 },
                new Set { Weight = 315, Reps = 3 },
            }},
            new Exercise { Name = "Pull-Up", Sets = new()
            {
                new Set { Weight = 0, Reps = 10 },
                new Set { Weight = 0, Reps = 8 },
                new Set { Weight = 0, Reps = 6 },
            }},
            new Exercise { Name = "Barbell Row", Sets = new()
            {
                new Set { Weight = 135, Reps = 10 },
                new Set { Weight = 155, Reps = 8 },
                new Set { Weight = 175, Reps = 6 },
            }},
            new Exercise { Name = "Face Pull", Sets = new()
            {
                new Set { Weight = 30, Reps = 15 },
                new Set { Weight = 35, Reps = 15 },
                new Set { Weight = 40, Reps = 12 },
            }},
            new Exercise { Name = "Bicep Curl", Sets = new()
            {
                new Set { Weight = 25, Reps = 12 },
                new Set { Weight = 30, Reps = 10 },
                new Set { Weight = 35, Reps = 8 },
            }},
        }
    };

    public static Workout Legs() => new()
    {
        Date = DateTime.Today,
        WorkoutType = "Legs",
        Exercises = new()
        {
            new Exercise { Name = "Squat", Sets = new()
            {
                new Set { Weight = 185, Reps = 10 },
                new Set { Weight = 225, Reps = 8 },
                new Set { Weight = 275, Reps = 5 },
            }},
            new Exercise { Name = "Romanian Deadlift", Sets = new()
            {
                new Set { Weight = 135, Reps = 12 },
                new Set { Weight = 155, Reps = 10 },
                new Set { Weight = 185, Reps = 8 },
            }},
            new Exercise { Name = "Leg Press", Sets = new()
            {
                new Set { Weight = 270, Reps = 12 },
                new Set { Weight = 360, Reps = 10 },
                new Set { Weight = 450, Reps = 8 },
            }},
            new Exercise { Name = "Leg Curl", Sets = new()
            {
                new Set { Weight = 70, Reps = 15 },
                new Set { Weight = 80, Reps = 12 },
                new Set { Weight = 90, Reps = 10 },
            }},
            new Exercise { Name = "Calf Raise", Sets = new()
            {
                new Set { Weight = 100, Reps = 20 },
                new Set { Weight = 120, Reps = 15 },
                new Set { Weight = 140, Reps = 12 },
            }},
        }
    };
}
