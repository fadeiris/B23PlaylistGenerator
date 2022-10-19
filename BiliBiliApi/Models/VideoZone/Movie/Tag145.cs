using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Movie;

/// <summary>
/// 電影 -> 歐美電影 (west)
/// </summary>
public class Tag145
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}