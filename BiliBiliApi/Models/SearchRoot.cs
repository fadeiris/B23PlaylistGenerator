using System.Text.Json.Serialization;

namespace BilibiliApi.Models;

/// <summary>
/// Search
/// </summary>
public class SearchRoot
{
    [JsonPropertyName("code")]
    public int Code { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("ttl")]
    public int Ttl { get; set; }

    [JsonPropertyName("data")]
    public Data? Data { get; set; }
}