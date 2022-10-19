using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Music;

/// <summary>
/// 音樂 -> 翻唱 (cover)
/// </summary>
public class Tag31
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}