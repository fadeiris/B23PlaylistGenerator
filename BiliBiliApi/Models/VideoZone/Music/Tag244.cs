using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Music;

/// <summary>
/// 音樂 -> 音樂教學 (tutorial)
/// </summary>
public class Tag244
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}