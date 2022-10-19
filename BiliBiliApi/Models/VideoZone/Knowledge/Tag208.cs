using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Knowledge;

/// <summary>
/// 知識 -> 校園學習 (campus)
/// </summary>
public class Tag208
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}