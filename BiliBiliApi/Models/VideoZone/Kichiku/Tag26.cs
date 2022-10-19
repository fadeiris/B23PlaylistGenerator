using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Kichiku;

/// <summary>
/// 鬼畜 -> 音MAD (mad)
/// </summary>
public class Tag26
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}