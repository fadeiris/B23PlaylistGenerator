using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Car;

/// <summary>
/// 汽車 -> 新能源車 (newenergyvehicle)
/// </summary>
public class Tag247
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}