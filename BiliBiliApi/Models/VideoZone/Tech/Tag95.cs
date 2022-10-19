using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Tech;

/// <summary>
/// 科技 -> 數碼 [(原) 手機平板] (digital)
/// </summary>
public class Tag95
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}