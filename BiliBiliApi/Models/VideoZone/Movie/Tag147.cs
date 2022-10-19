using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Movie;

/// <summary>
/// 電影 -> 華語電影 (chinese)
/// </summary>
public class Tag147
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}