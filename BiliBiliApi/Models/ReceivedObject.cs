namespace BilibiliApi.Models;

/// <summary>
/// 接收的物件
/// </summary>
/// <typeparam name="T">T，類型參數</typeparam>
public class ReceivedObject<T>
{
    /// <summary>
    /// HTTP Code
    /// </summary>
    public int Code { get; set; }

    /// <summary>
    /// 訊息
    /// </summary>
    public string? Message { get; set; }

    /// <summary>
    /// 資料
    /// </summary>
    public T? Data { get; set; }
}