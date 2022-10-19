using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Douga;

/// <summary>
/// 動畫 -> 綜合 (other)
/// </summary>
public class Tag27
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}