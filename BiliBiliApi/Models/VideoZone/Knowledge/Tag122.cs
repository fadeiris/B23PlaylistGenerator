using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Knowledge;

/// <summary>
/// 知識 -> 野生技術協會 (skill)
/// </summary>
public class Tag122
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}