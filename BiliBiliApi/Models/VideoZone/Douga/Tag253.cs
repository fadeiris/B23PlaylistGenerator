using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Douga;

/// <summary>
/// 動畫 -> 動漫雜談 (acgntalks)
/// </summary>
public class Tag253
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}