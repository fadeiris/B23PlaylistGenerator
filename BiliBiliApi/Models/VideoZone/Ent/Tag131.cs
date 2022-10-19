using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Ent;

/// <summary>
/// 娛樂 -> Korea 相關 (korea)
/// </summary>
[Obsolete("此分區已下線")]
public class Tag131
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}