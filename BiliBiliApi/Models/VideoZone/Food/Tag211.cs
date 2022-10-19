using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Food;

/// <summary>
/// 美食（主分區）(food)
/// </summary>
public class Tag211
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}