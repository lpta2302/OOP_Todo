using System.Runtime.Serialization;
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
        try
        {

            if (!File.Exists(path))
                File.WriteAllText(path, "[]");
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FileLoadException ex)
        {
            Console.WriteLine(ex.Message);
        }

    }

    public static List<EntityType>? GetAll()
    {
        try
        {
            string newjson = File.ReadAllText(path);
            JsonSerializerOptions jsonOption = new JsonSerializerOptions();
            jsonOption.Converters.Add(new TaskConverter());
            List<EntityType>? res = JsonSerializer.Deserialize<List<EntityType>>(newjson, jsonOption);
            return res;
        }
        catch (SerializationException ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
    }

    public static void Save(IList<EntityType> entities)
    {
        try
        {
            JsonSerializerOptions jsonOption = new JsonSerializerOptions { WriteIndented = true };
            jsonOption.Converters.Add(new TaskConverter());
            string json = JsonSerializer.Serialize(entities, jsonOption);
            File.WriteAllText(path, json);
        }
        catch (SerializationException ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
        catch (FileLoadException ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
    }
}
