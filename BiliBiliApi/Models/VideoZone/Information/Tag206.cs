using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Information;

/// <summary>
/// 資訊 -> 綜合 (multiple)
/// </summary>
public class Tag206
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}