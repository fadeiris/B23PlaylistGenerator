using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Douga;

/// <summary>
/// 動畫 -> 短片、手書、配音 (voice)
/// </summary>
public class Tag47
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}