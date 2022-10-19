using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Knowledge;

/// <summary>
/// 知識 -> 設計、創意 (design)
/// </summary>
public class Tag229
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}