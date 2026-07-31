namespace GymTracker.Models;

public static class WorkoutTemplates
{
    public static Workout Push() => new()
    {
        Date = DateTime.Today,
        WorkoutType = "Push",
        Exercises = new()
        {
            new LoggedExercise { ExerciseId = 1, Sets = new()   // Bench Press
            {
                new Set { Weight = 135, Reps = 10 },
                new Set { Weight = 155, Reps = 8 },
                new Set { Weight = 175, Reps = 6 },
            }},
            new LoggedExercise { ExerciseId = 2, Sets = new()   // Overhead Press
            {
                new Set { Weight = 75, Reps = 10 },
                new Set { Weight = 85, Reps = 8 },
                new Set { Weight = 95, Reps = 6 },
            }},
            new LoggedExercise { ExerciseId = 3, Sets = new()   // Incline Dumbbell Press
            {
                new Set { Weight = 50, Reps = 12 },
                new Set { Weight = 55, Reps = 10 },
                new Set { Weight = 60, Reps = 8 },
            }},
            new LoggedExercise { ExerciseId = 4, Sets = new()   // Lateral Raise
            {
                new Set { Weight = 15, Reps = 15 },
                new Set { Weight = 15, Reps = 15 },
                new Set { Weight = 20, Reps = 12 },
            }},
            new LoggedExercise { ExerciseId = 5, Sets = new()   // Triceps Pushdown
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
            new LoggedExercise { ExerciseId = 6, Sets = new()   // Deadlift
            {
                new Set { Weight = 225, Reps = 8 },
                new Set { Weight = 275, Reps = 5 },
                new Set { Weight = 315, Reps = 3 },
            }},
            new LoggedExercise { ExerciseId = 7, Sets = new()   // Pull-Up
            {
                new Set { Weight = 0, Reps = 10 },
                new Set { Weight = 0, Reps = 8 },
                new Set { Weight = 0, Reps = 6 },
            }},
            new LoggedExercise { ExerciseId = 8, Sets = new()   // Barbell Row
            {
                new Set { Weight = 135, Reps = 10 },
                new Set { Weight = 155, Reps = 8 },
                new Set { Weight = 175, Reps = 6 },
            }},
            new LoggedExercise { ExerciseId = 9, Sets = new()   // Face Pull
            {
                new Set { Weight = 30, Reps = 15 },
                new Set { Weight = 35, Reps = 15 },
                new Set { Weight = 40, Reps = 12 },
            }},
            new LoggedExercise { ExerciseId = 10, Sets = new()  // Bicep Curl
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
            new LoggedExercise { ExerciseId = 11, Sets = new()  // Squat
            {
                new Set { Weight = 185, Reps = 10 },
                new Set { Weight = 225, Reps = 8 },
                new Set { Weight = 275, Reps = 5 },
            }},
            new LoggedExercise { ExerciseId = 12, Sets = new()  // Romanian Deadlift
            {
                new Set { Weight = 135, Reps = 12 },
                new Set { Weight = 155, Reps = 10 },
                new Set { Weight = 185, Reps = 8 },
            }},
            new LoggedExercise { ExerciseId = 13, Sets = new()  // Leg Press
            {
                new Set { Weight = 270, Reps = 12 },
                new Set { Weight = 360, Reps = 10 },
                new Set { Weight = 450, Reps = 8 },
            }},
            new LoggedExercise { ExerciseId = 14, Sets = new()  // Leg Curl
            {
                new Set { Weight = 70, Reps = 15 },
                new Set { Weight = 80, Reps = 12 },
                new Set { Weight = 90, Reps = 10 },
            }},
            new LoggedExercise { ExerciseId = 15, Sets = new()  // Calf Raise
            {
                new Set { Weight = 100, Reps = 20 },
                new Set { Weight = 120, Reps = 15 },
                new Set { Weight = 140, Reps = 12 },
            }},
        }
    };
}