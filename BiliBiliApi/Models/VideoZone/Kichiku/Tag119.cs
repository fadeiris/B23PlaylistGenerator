using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Kichiku;

/// <summary>
/// 鬼畜（主分區）(kichiku)
/// </summary>
public class Tag119
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}