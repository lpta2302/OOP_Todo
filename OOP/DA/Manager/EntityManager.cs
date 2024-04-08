using System.Text.Json;

public class EntityManager<EntityType>
{
    private string path;
    public EntityManager()
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
    public List<EntityType>? GetAll()
    {
        string newjson = File.ReadAllText(path);
        List<EntityType>? res = JsonSerializer.Deserialize<List<EntityType>>(newjson);
        return res;
    }

    public void Save(List<EntityType> entities)
    {
        JsonSerializerOptions jsonOption = new JsonSerializerOptions { WriteIndented = true };
        jsonOption.Converters.Add(new TaskConverter());
        string json = JsonSerializer.Serialize(entities, jsonOption);

        File.WriteAllText(path, json);
    }

    public EntityType? Get(object id) { return default; }
    public void Delete(object id) { }
}
