using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Cinephile;

/// <summary>
/// 影視 -> 影視雜談 (cinecism)
/// </summary>
public class Tag182
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}