using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Tech;

/// <summary>
/// 科技（主分區） [原數碼分區] (tech)
/// </summary>
public class Tag188
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}