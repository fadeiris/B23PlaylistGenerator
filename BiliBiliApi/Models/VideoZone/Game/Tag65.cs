using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Game;

/// <summary>
/// 遊戲 -> 網路遊戲 (online)
/// </summary>
public class Tag65
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}