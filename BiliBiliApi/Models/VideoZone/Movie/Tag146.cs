using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Movie;

/// <summary>
/// 電影 -> 日本電影 (japan)
/// </summary>
public class Tag146
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}