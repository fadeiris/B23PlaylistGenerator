using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Ent;

/// <summary>
/// 娛樂 -> 粉絲創作 (fans)
/// </summary>
public class Tag242
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}