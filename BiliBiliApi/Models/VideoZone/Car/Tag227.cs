using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Car;

/// <summary>
/// 汽車 -> 購車攻略 (strategy)
/// </summary>
public class Tag227
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}