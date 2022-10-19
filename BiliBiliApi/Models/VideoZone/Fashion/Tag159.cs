using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Fashion;

/// <summary>
/// 時尚 -> 時尚潮流 (catwalk)
/// </summary>
public class Tag159
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}