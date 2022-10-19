using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Animal;

/// <summary>
/// 動物圈 -> 爬寵 (reptiles)
/// </summary>
public class Tag222
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}