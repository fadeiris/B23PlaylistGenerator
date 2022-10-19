using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Douga;

/// <summary>
/// 動畫（主分區）(douga)
/// </summary>
public class Tag1
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}