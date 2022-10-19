using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.GuoChuang;

/// <summary>
/// 國創 -> 資訊 (information)
/// </summary>
public class Tag170
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}