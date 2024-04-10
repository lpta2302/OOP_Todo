using System.Text.Json;

public class EntityManager<EntityType>
{
    private static string path;
    static EntityManager()
    {
        string type = typeof(EntityType).ToString();

        switch (type)
        {
            case "Plan":
                path = "plan.data";
                break;
            case "Task":
                path = "task.data";
                break;
            default:
                path = "bin.data";
                break;
        }
    }
    public static List<EntityType>? GetAll()
    {
        string newjson = File.ReadAllText(path);
        List<EntityType>? res = JsonSerializer.Deserialize<List<EntityType>>(newjson);
        return res;
    }

    public static void Save(IList<EntityType> entities)
    {
        JsonSerializerOptions jsonOption = new JsonSerializerOptions { WriteIndented = true };
        jsonOption.Converters.Add(new TaskConverter());
        string json = JsonSerializer.Serialize(entities, jsonOption);

        File.WriteAllText(path, json);
    }

    public static EntityType? Get(object id) { return default; }
    public static void Delete(object id) { }
}
