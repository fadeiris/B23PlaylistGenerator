using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Food;

/// <summary>
/// 美食 -> 田園美食 (rural)
/// </summary>
public class Tag214
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}