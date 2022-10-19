using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Documentary;

/// <summary>
/// 紀錄片（主分區）(documentary)
/// </summary>
public class Tag177
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}