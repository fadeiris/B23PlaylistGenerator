using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Douga;

/// <summary>
/// 動畫 -> MMD、3D (mmd)
/// </summary>
public class Tag25
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}