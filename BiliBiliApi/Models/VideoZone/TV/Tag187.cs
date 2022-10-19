using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.TV;

/// <summary>
/// 電視劇 -> 海外劇 (overseas)
/// </summary>
public class Tag187
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}