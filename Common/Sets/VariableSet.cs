using BilibiliApi.Functions;

namespace B23PlaylistGenerator.Common.Sets;

/// <summary>
/// 變數組
/// </summary>
public class VariableSet
{
    /// <summary>
    /// 預設的播放清單檔案名稱
    /// </summary>
    public static readonly string DefalutPlaylistFileName = "CustomYTPlayer_Playlist";

    /// <summary>
    /// 預設的 Bilibili API 用 ps 值。（最小值為 1，最大值不可以超過 50）
    /// </summary>
    public static readonly int BilibiliDefaultPS = Properties.Settings.Default.DefaultPS;

    /// <summary>
    /// 排除字詞
    /// </summary>
    public static List<string> ExcludedWords()
    {
        return Properties.Settings.Default
            .ExcludedWords
            .Split(
                new char[] { ',' },
                StringSplitOptions.RemoveEmptyEntries)
            .ToList();
    }

    /// <summary>
    /// Bilibili 使用者的 mid 列表（暫存）
    /// </summary>
    private static readonly List<string> _BilibiliMidSet = new();

    /// <summary>
    /// Bilibili 使用者的 mid 列表
    /// </summary>
    public static List<string> BilibiliMidSet
    {
        get
        {
            return _BilibiliMidSet;
        }

        set
        {
            _BilibiliMidSet.Clear();

            foreach (string line in value)
            {
                if (!string.IsNullOrEmpty(line))
                {
                    _BilibiliMidSet.Add(CommonFunction.ExtractMID(line));
                }
            }
        }
    }
}