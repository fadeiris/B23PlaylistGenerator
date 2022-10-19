using System.Text.Json.Serialization;

namespace BilibiliApi.Models;

/// <summary>
/// EpisodicButton
/// </summary>
public class EpisodicButton
{
    [JsonPropertyName("text")]
    public string? Text { get; set; }

    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}