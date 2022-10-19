using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Anime;

/// <summary>
/// 番劇 -> 資訊 (information)
/// </summary>
public class Tag51
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}