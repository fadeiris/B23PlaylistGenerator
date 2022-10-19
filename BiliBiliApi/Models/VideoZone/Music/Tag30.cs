using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Music;

/// <summary>
/// 音樂 -> VOCALOID、UTAU (vocaloid)
/// </summary>
public class Tag30
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}