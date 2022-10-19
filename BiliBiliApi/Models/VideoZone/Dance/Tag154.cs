using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Dance;

/// <summary>
/// 舞蹈 -> 舞蹈綜合 (three_d)
/// </summary>
public class Tag154
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}