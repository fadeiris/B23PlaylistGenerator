using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Information;

/// <summary>
/// 資訊 -> 熱點 (hotspot)
/// </summary>
public class Tag203
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}