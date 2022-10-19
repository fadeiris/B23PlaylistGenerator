using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.AD;

/// <summary>
/// 廣告（已下線）(ad)
/// </summary>
[Obsolete("此分區已下線")]
public class Tag166
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}