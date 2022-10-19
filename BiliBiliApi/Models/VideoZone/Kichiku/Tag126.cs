using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Kichiku;

/// <summary>
/// 鬼畜 -> 人力VOCALOID (manual_vocaloid)
/// </summary>
public class Tag126
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}