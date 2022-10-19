namespace BilibiliApi.Common;

/// <summary>
/// 變數組
/// </summary>
public class VariableSet
{
    /// <summary>
    /// Bilibili 查詢使用者投稿視頻明細的 API 網址
    /// <para>參考來源：https://github.com/SocialSisterYi/bilibili-API-collect/blob/master/user/space.md#%E6%9F%A5%E8%AF%A2%E7%94%A8%E6%88%B7%E6%8A%95%E7%A8%BF%E8%A7%86%E9%A2%91%E6%98%8E%E7%BB%86 </para>
    /// </summary>
    public static readonly string BilibiliSpaceApiUrl = $"https://api.bilibili.com/x/space/arc/search";

    /// <summary>
    /// Bilibili 使用者空間的網址
    /// </summary>
    public static readonly string BilibiliSpaceUrl = "https://space.bilibili.com/";
}