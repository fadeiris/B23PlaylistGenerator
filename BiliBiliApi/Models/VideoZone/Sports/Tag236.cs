using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Sports;

/// <summary>
/// 運動 -> 競技體育 (athletic)
/// </summary>
public class Tag236
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}