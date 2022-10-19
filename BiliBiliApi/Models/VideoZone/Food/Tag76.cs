using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Food;

/// <summary>
/// 美食 -> 美食製作 [(原)生活 -> 美食圈] (make)
/// </summary>
public class Tag76
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}