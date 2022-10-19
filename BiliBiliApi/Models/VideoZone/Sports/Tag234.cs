using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Sports;

/// <summary>
/// 運動（主分區）(sports)
/// </summary>
public class Tag234
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}