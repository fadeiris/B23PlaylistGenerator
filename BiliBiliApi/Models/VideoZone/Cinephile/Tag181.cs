using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Cinephile;

/// <summary>
/// 影視（主分區）(cinephile)
/// </summary>
public class Tag181
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}