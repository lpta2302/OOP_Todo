using System.Text.Json;
using System.Text.Json.Serialization;


public class TaskConverter : JsonConverter<Task>
{
    public override Task Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using (JsonDocument doc = JsonDocument.ParseValue(ref reader))
        {
            JsonElement obj = doc.RootElement;

            // Determine the actual type of task based on the discriminator property
            string taskType = obj.GetProperty("TaskType").GetString();
            Task task;
            switch (taskType)
            {
                case "ShortTerm":
                    task = JsonSerializer.Deserialize<ShortTerm>(obj.GetRawText(), options);
                    break;
                case "LongTerm":
                    task = JsonSerializer.Deserialize<LongTerm>(obj.GetRawText(), options);
                    break;
                default:
                    throw new JsonException("Unknown task type.");
            }

            return task;
        }
    }

    public override void Write(Utf8JsonWriter writer, Task value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
