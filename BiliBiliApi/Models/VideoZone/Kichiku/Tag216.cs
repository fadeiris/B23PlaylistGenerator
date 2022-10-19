using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Kichiku;

/// <summary>
/// 鬼畜 -> 鬼畜劇場 (theatre)
/// </summary>
public class Tag216
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}