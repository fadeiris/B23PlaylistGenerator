using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Music;

/// <summary>
/// 音樂 -> 原創音樂 (original)
/// </summary>
public class Tag28
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}