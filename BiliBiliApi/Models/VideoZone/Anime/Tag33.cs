using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Anime;

/// <summary>
/// 番劇 -> 連載動畫 (serial)
/// </summary>
public class Tag33
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}