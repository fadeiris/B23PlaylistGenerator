using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Sports;

/// <summary>
/// 運動 -> 運動文化 (culture)
/// </summary>
public class Tag237
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}