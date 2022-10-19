using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Fashion;

/// <summary>
/// 時尚（主分區）(fashion)
/// </summary>
public class Tag155
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}