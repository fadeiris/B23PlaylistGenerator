using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.TV;

/// <summary>
/// 電視劇（主分區）(tv)
/// </summary>
public class Tag11
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}