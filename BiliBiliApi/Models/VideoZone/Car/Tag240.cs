using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Car;

/// <summary>
/// 汽車 -> 摩托車 (motorcycle)
/// </summary>
public class Tag240
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}