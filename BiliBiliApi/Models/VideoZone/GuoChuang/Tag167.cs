using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.GuoChuang;

/// <summary>
/// 國創（主分區）(guochuang)
/// </summary>
public class Tag167
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}