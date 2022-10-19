using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Game;

/// <summary>
/// 遊戲 -> 桌遊棋牌 (board)
/// </summary>
public class Tag173
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}