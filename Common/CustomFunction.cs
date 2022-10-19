using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Controls;

namespace B23PlaylistGenerator.Common;

/// <summary>
/// 自定義函式
/// </summary>
public class CustomFunction
{
    /// <summary>
    /// 寫紀錄
    /// </summary>
    /// <param name="control">TextBox</param>
    /// <param name="message">字串，訊息</param>
    public static void WriteLog(TextBox control, string message)
    {
        try
        {
            if (!string.IsNullOrEmpty(message))
            {
                message = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}{Environment.NewLine}";

                int currentLenth = control.Text.Length,
                    predictLength = currentLenth + message.Length,
                    maxLength = control.MaxLength;

                if (maxLength != 0 && predictLength > maxLength)
                {
                    control.Clear();

                    Debug.WriteLine($"{nameof(WriteLog)}：已執行 Clear()。");
                }

                control.AppendText(message);
                control.CaretIndex = control.Text.Length;
                control.Focus();
            }
            else
            {
                Debug.WriteLine($"{nameof(WriteLog)}：傳入的變數 messsage 為空值");
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"{nameof(WriteLog)}：{ex.Message}");
        }
    }

    /// <summary>
    /// 開啟網頁瀏覽器
    /// <para>參考 1：https://github.com/dotnet/runtime/issues/17938#issuecomment-235502080 </para>
    /// <para>參考 2：https://github.com/dotnet/runtime/issues/17938#issuecomment-249383422 </para>
    /// </summary>
    /// <param name="url">字串，網址</param>
    public static void OpenBrowser(string url)
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            // Process.Start(new ProcessStartInfo("cmd", $"/c start {url}"));
            url = url.Replace("&", "^&");

            Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            Process.Start("xdg-open", url);
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
        {
            Process.Start("open", url);
        }
        else
        {
            Debug.WriteLine($"{nameof(OpenBrowser)}：不支援的作業系統。");
        }
    }
}