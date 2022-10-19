using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Dance;

/// <summary>
/// 舞蹈 -> 中國舞 (china)
/// </summary>
public class Tag200
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}