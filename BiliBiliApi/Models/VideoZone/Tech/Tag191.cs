using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Tech;

/// <summary>
/// 科技 -> 影音智能 (intelligence_av)
/// </summary>
[Obsolete("此分區已下線")]
public class Tag191
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}