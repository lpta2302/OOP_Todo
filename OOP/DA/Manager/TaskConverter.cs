using System.Text.Json;
using System.Text.Json.Serialization;


public class TaskConverter : JsonConverter<Task>
{
    public override Task Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using (JsonDocument doc = JsonDocument.ParseValue(ref reader))
        {
            JsonElement obj = doc.RootElement;
            Task task;

            if (obj.TryGetProperty("PlanId", out JsonElement value))
            {
                task = JsonSerializer.Deserialize<LongTerm>(obj.GetRawText(), options)!;
            }
            else
            {
                task = JsonSerializer.Deserialize<ShortTerm>(obj.GetRawText(), options)!;
            }

            return task;
        }
    }

    public override void Write(Utf8JsonWriter writer, Task value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
