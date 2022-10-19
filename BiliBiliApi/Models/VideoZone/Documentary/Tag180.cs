using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Documentary;

/// <summary>
/// 紀錄片 -> 社會、美食、旅行 (travel)
/// </summary>
public class Tag180
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}