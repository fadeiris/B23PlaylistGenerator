using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Documentary;

/// <summary>
/// 紀錄片 -> 人文、歷史 (history)
/// </summary>
public class Tag37
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}