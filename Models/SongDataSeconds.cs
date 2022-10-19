using System.ComponentModel;
using System.Text.Json.Serialization;

namespace B23PlaylistGenerator.Models;

/// <summary>
/// 類別：歌曲資料（秒數）
/// </summary>
public class SongDataSeconds
{
    /// <summary>
    /// 影片 ID
    /// </summary>
    [JsonPropertyName("videoID")]
    [Description("影片 ID")]
    public string? VideoID { get; set; }

    /// <summary>
    /// 名稱
    /// </summary>
    [JsonPropertyName("name")]
    [Description("名稱")]
    public string? Name { get; set; }

    /// <summary>
    /// 開始秒數
    /// </summary>
    [JsonPropertyName("startSeconds")]
    [Description("開始秒數")]
    public double? StartSeconds { get; set; } = 0;

    /// <summary>
    /// 結束秒數
    /// </summary>
    [JsonPropertyName("endSeconds")]
    [Description("結束秒數")]
    public double? EndSeconds { get; set; } = 0;

    /// <summary>
    /// 字幕檔案來源
    /// </summary>
    [JsonPropertyName("subSrc")]
    [Description("字幕檔案來源")]
    public string? SubSrc { get; set; }

}