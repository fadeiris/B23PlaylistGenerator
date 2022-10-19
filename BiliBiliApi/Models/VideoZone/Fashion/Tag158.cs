using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Fashion;

/// <summary>
/// 時尚 -> 穿搭 (clothing)
/// </summary>
public class Tag158
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}