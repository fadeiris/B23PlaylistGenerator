using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Car;

/// <summary>
/// 汽車 -> 改裝玩車 (modifiedvehicle)
/// </summary>
public class Tag246
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}