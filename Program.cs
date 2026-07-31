using GymTracker.Models;
List<Workout> workouts = new();
while (true)
{
    Console.Clear();

    Console.WriteLine("=== Gym Tracker ===");
    Console.WriteLine("1. Add Workout");
    Console.WriteLine("2. View Workouts");
    Console.WriteLine("3. Add Predefined Workout");
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

        case "0":
            return;
    }
}
void AddWorkout(){
    Console.Write("Workout Type: ");
    string workoutType= Console.ReadLine() ?? "";
    var workout= new Workout {
        Date=DateTime.Now,
        WorkoutType= workoutType
    };
    workouts.Add(workout);
    while (true)
    {
        Console.Write("Add Exercise? (y/n): ");
        var addExerciseChoice = Console.ReadLine() ?? "";
        if (addExerciseChoice.ToLower() != "y") break;
        var exercise = AddExercise();
        workout.Exercises.Add(exercise);
    }
    Console.WriteLine("Workout Added!");
    Console.ReadKey();
}
Exercise AddExercise(){
    Console.Write("Exercise Name: ");
    string exerciseName = Console.ReadLine() ?? "";
    
    Console.Write("Number of Sets: ");
    int numberOfSets = int.Parse(Console.ReadLine() ?? "0");
    List<Set> sets = new List<Set>();
    for (int i=1; i<numberOfSets+1 ;i++){
        Console.WriteLine($"Set #{i}");
        Console.Write("Weight: ");
        int weight=int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Number of Reps: ");
        int reps=int.Parse(Console.ReadLine() ?? "0");
        sets.Add(
            new Set{
                Reps = reps,
                Weight = weight
            }
        );

    }
    var exercise = new Exercise {
        Name = exerciseName,
        Sets = sets
    };
    return exercise;
}
void AddPredefinedWorkout(){
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
    if (workout == null){
        Console.WriteLine("Invalid selection");
    }
    else{
        workouts.Add(workout);
        Console.WriteLine($"{workout.WorkoutType} workout added!");
    }
    Console.ReadKey();
}
void ViewWorkouts(){
    Console.WriteLine();
    if (workouts.Count==0){
        Console.WriteLine("No Workouts Found");
    }
    else{
        foreach (var workout in workouts){
            workout.Print();
            
        }}
    Console.ReadKey();
}
