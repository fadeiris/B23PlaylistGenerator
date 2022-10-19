using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Life;

/// <summary>
/// 生活（主分區）(life)
/// </summary>
public class Tag160
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}