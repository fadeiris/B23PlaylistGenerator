using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Dance;

/// <summary>
/// 舞蹈 -> 宅舞 (otaku)
/// </summary>
public class Tag20
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}