using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.GuoChuang;

/// <summary>
/// 國創 -> 動態漫、廣播劇 (motioncomic)
/// </summary>
public class Tag195
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}