using System.Text.Json;
namespace GymTracker.Services;
using GymTracker.Models;

public static class WorkoutService
{
    // Climb out of bin/Debug/net8.0 to the project's source Data folder
    private static readonly string FilePath = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "Data", "workouts.json");
    private static readonly JsonSerializerOptions Options = new()
    {
        WriteIndented = true
    };
    public static void Save(List<Workout> workouts)
    {
        Directory.CreateDirectory(Path.GetDirectoryName(FilePath)!);
        string json = JsonSerializer.Serialize(workouts, Options);
        File.WriteAllText(FilePath, json);
    }
    public static List<Workout> Load()
    {
        if (!File.Exists(FilePath)) return new List<Workout>();
        string json= File.ReadAllText(FilePath);
        if (string.IsNullOrWhiteSpace(json)) return new List<Workout>();
        return JsonSerializer.Deserialize<List<Workout>>(json, Options) ?? new List<Workout>();
    }

    public static void Clear()
    {
        File.WriteAllText(FilePath, "[]");
    }
}