using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Sports;

/// <summary>
/// 運動 -> 籃球 (basketball)
/// </summary>
public class Tag235
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}