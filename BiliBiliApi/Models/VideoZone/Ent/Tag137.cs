using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Ent;

/// <summary>
/// 娛樂 -> 明星綜合 (celebrity)
/// </summary>
public class Tag137
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}