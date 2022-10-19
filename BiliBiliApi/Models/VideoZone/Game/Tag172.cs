using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Game;

/// <summary>
/// 遊戲 -> 手機遊戲 (mobile)
/// </summary>
public class Tag172
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}