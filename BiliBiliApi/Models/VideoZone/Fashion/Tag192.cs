using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Fashion;

/// <summary>
/// 時尚 -> 風尚標 (trends)
/// </summary>
[Obsolete("此分區已下線")]
public class Tag192
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}