using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Animal;

/// <summary>
/// 動物圈 -> 大熊貓 (panda)
/// </summary>
public class Tag220
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}