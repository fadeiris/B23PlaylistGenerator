using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Life;

/// <summary>
/// 生活 -> 日常 (daily)
/// </summary>
public class Tag21
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}