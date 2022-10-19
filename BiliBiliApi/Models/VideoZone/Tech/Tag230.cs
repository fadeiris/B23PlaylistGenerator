using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Tech;

/// <summary>
/// 科技 -> 軟件應用 (application)
/// </summary>
public class Tag230
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}