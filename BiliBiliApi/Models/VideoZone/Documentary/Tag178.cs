using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Documentary;

/// <summary>
/// 紀錄片 -> 科學、探索、自然 (science)
/// </summary>
public class Tag178
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}