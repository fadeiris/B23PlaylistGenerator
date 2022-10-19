using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Life;

/// <summary>
/// 生活 -> 三農 (rurallife)
/// </summary>
public class Tag251
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}