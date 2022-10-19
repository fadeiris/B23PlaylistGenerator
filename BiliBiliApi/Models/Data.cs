using System.Text.Json.Serialization;

namespace BilibiliApi.Models;

/// <summary>
/// Data
/// </summary>
public class Data
{
    [JsonPropertyName("list")]
    public List? List { get; set; }

    [JsonPropertyName("page")]
    public Page? Page { get; set; }

    [JsonPropertyName("episodic_button")]
    public EpisodicButton? EpisodicButton { get; set; }

    [JsonPropertyName("is_risk")]
    public bool IsRisk { get; set; }

    [JsonPropertyName("gaia_res_type")]
    public int GaiaResType { get; set; }

    [JsonPropertyName("gaia_data")]
    public object? GaiaData { get; set; }
}