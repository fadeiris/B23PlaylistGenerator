using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Anime;

/// <summary>
/// 番劇 -> 官方延伸 (offical)
/// </summary>
public class Tag152
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}