using System.ComponentModel;
using System.Text.Json.Serialization;

namespace B23PlaylistGenerator.Models;

/// <summary>
/// tid 資料
/// </summary>
public class TidData
{
    /// <summary>
    /// tid
    /// </summary>
    [JsonPropertyName("tid")]
    [Description("tid")]
    public int TID { get; set; }

    /// <summary>
    /// 名稱
    /// </summary>
    [JsonPropertyName("name")]
    [Description("名稱")]
    public string? Name { get; set; }
}