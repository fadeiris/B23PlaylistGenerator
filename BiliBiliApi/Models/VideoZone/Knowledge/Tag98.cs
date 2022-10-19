using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Knowledge;

/// <summary>
/// 知識 -> 機械 (mechanical)
/// </summary>
[Obsolete("此分區已下線")]
public class Tag98
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}