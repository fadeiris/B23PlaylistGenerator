using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Car;

/// <summary>
/// 汽車 -> 智能出行 (smart)
/// </summary>
[Obsolete("此分區已下線")]
public class Tag226
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}