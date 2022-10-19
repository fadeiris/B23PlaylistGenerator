using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Knowledge;

/// <summary>
/// 知識 -> 科學科普 (science)
/// </summary>
public class Tag201
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}