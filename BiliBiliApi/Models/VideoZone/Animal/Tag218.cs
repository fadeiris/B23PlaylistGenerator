using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Animal;

/// <summary>
/// 動物圈 -> 喵星人 (cat)
/// </summary>
public class Tag218
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}