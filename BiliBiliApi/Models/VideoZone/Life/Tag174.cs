using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Life;

/// <summary>
/// 生活 -> 其他 (other)
/// </summary>
[Obsolete("此分區已下線")]
public class Tag174
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}