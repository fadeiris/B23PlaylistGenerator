using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Food;

/// <summary>
/// 美食 -> 美食測評 (measurement)
/// </summary>
public class Tag213
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}