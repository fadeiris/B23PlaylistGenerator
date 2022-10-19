using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.GuoChuang;

/// <summary>
/// 國創 -> 國產原創相關 (original)
/// </summary>
public class Tag168
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}