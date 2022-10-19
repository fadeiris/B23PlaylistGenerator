using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Movie;

/// <summary>
/// 電影 -> 其他國家 (movie)
/// </summary>
public class Tag83
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}