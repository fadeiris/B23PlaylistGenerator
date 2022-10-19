using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Food;

/// <summary>
/// 美食 -> 美食偵探 (detective)
/// </summary>
public class Tag212
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}