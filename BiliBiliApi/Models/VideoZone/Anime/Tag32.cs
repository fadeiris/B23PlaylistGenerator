using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Anime;

/// <summary>
/// 番劇 -> 完結動畫 (finish)
/// </summary>
public class Tag32
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}