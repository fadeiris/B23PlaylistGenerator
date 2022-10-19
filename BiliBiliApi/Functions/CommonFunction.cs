using BilibiliApi.Common;
using System.Net.Http;

namespace BilibiliApi.Functions;

/// <summary>
/// 通用函式
/// </summary>
public class CommonFunction
{
    /// <summary>
    /// 檢查網址是否有效
    /// </summary>
    /// <param name="httpClient">HttpClient</param>
    /// <param name="url">字串，網址</param>
    /// <returns>Task&lt;bool&gt;</returns>
    public static async Task<bool> IsUrlValid(HttpClient httpClient, string url)
    {
        bool isPassed = false;

        using HttpResponseMessage response = await httpClient.GetAsync(url);

        string? requestUrl = response.RequestMessage?.RequestUri?.ToString();

        // 排除掉非一般影片的網址。
        if (!string.IsNullOrEmpty(requestUrl) &&
            !requestUrl.Contains("/festival/"))
        {
            isPassed = true;
        }

        return isPassed;
    }

    /// <summary>
    /// 取得格式化後的 length
    /// </summary>
    /// <param name="length">字串，vlist 下個項目的 length</param>
    /// <returns>字串</returns>
    public static string GetFormattedLength(string length)
    {
        // vlist 下個項目的 length 所表示的值有可能會超過 1 小時。
        if (length.Length >= 5)
        {
            string[] tempArray = length.Split(":");

            if (int.TryParse(tempArray[0], out int result))
            {
                if (result > 59)
                {
                    int hours = result / 60;
                    int minutes = result % 60;

                    if (hours > 23)
                    {
                        int days = hours / 24;
                        int newHours = hours % 24;

                        length = $"{days}.{newHours:0#}:{minutes:0#}:{tempArray[1]:0#}";
                    }
                    else
                    {
                        length = $"{hours:0#}:{minutes:0#}:{tempArray[1]:0#}";
                    }
                }
                else
                {
                    length = $"00:{tempArray[0]:0#}:{tempArray[1]:0#}";
                }
            }
        }

        return length;
    }

    /// <summary>
    /// 從 Bilibili 使用者空間的網址拆解 mid
    /// </summary>
    /// <param name="url">字串，Bilibili 使用者空間的網址</param>
    /// <returns>字串</returns>
    public static string ExtractMID(string url)
    {
        if (url.Contains(VariableSet.BilibiliSpaceUrl))
        {
            url = url.Replace(VariableSet.BilibiliSpaceUrl, string.Empty);
        }

        if (!url.Contains("http://") &&
            !url.Contains("https://"))
        {
            if (url.Contains('/'))
            {
                string[] tempArray = url
                    .Split(
                        new char[] { '/' },
                        StringSplitOptions.RemoveEmptyEntries);

                url = tempArray[0];
            }
        }

        return url.Trim();
    }
}