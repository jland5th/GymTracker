using System.Text.Json;
namespace GymTracker.Services;
using GymTracker.Models;

public static class ExerciseService
{
    // Climb out of bin/Debug/net8.0 to the project's source Data folder
    private static readonly string FilePath = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "Data", "exercises.json");
    public static List<Exercise> Load()
    {
        if (!File.Exists(FilePath)) return new List<Exercise>();
        string json = File.ReadAllText(FilePath);
        if (string.IsNullOrWhiteSpace(json)) return new List<Exercise>();
        return JsonSerializer.Deserialize<List<Exercise>>(json) ?? new List<Exercise>();
    }
    public static Exercise? GetById(int id)
    {
        return Load().FirstOrDefault(e => e.Id == id);
    }
}