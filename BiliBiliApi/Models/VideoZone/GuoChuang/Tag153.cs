using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.GuoChuang;

/// <summary>
/// 國創 -> 國產動畫 (chinese)
/// </summary>
public class Tag153
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}