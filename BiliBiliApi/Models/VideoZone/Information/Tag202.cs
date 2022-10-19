using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Information;

/// <summary>
/// 資訊（主分區）(information)
/// </summary>
public class Tag202
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}