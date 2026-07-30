// See https://aka.ms/new-console-template for more information
while (true)
{
    Console.Clear();

    Console.WriteLine("=== Gym Tracker ===");
    Console.WriteLine("1. Add Workout");
    Console.WriteLine("2. View Workouts");
    Console.WriteLine("0. Exit");

    var choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine("Add Workout");
            Console.ReadKey();
            break;

        case "2":
            Console.WriteLine("View Workouts");
            Console.ReadKey();
            break;

        case "0":
            return;
    }
}