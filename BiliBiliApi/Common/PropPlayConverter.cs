using System.Text.Json;
using System.Text.Json.Serialization;

namespace BilibiliApi.Common;

/// <summary>
/// 參數 play 轉換器
/// </summary>
public class PropPlayConverter : JsonConverter<int>
{
    public override int Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return reader.TokenType switch
        {
            JsonTokenType.Number => reader.GetInt32(),
            JsonTokenType.String => int.TryParse(reader.GetString(), out int parsedInt) ? parsedInt : 0,
            _ => 0
        };
    }

    public override void Write(Utf8JsonWriter writer, int value, JsonSerializerOptions options)
    {
        writer.WriteNumberValue(value);
    }
}