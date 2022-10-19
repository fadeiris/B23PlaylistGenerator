using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Tech;

/// <summary>
/// 科技 -> 極客DIY (diy)
/// </summary>
public class Tag233
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}