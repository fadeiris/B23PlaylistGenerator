using BilibiliApi.Functions;
using BilibiliApi.Models;
using B23PlaylistGenerator.Common;
using B23PlaylistGenerator.Models;
using System.IO;
using System.Net.Http;
using System.Reflection;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text;
using System.Windows.Controls;
using System.Windows;
using OpenCCNET;
using B23PlaylistGenerator.Common.Sets;

namespace B23PlaylistGenerator;

public partial class MainWindow
{
    /// <summary>
    /// 自定義初始化
    /// </summary>
    private void CustomInit()
    {
        try
        {
            Version? version = Assembly.GetEntryAssembly()?.GetName().Version;

            if (version != null)
            {
                LVersion.Content = $"版本：{version}";
            }
            else
            {
                LVersion.Content = "版本：無";
            }

            TBUserAgent.Text = Properties.Settings.Default.UserAgent;

            string excludedWords = string.Empty;

            if (!string.IsNullOrEmpty(Properties.Settings.Default.ExcludedWords))
            {
                excludedWords = string.Join(
                    Environment.NewLine,
                    Properties.Settings.Default.ExcludedWords
                        .Split(
                            new char[] { ',' },
                            StringSplitOptions.RemoveEmptyEntries));
            }
            else
            {
                excludedWords = string.Join(
                    Environment.NewLine,
                    Properties.Settings.Default.DefaultExcludedWords
                        .Split(
                            new char[] { ',' },
                            StringSplitOptions.RemoveEmptyEntries));
            }

            TBExcludedWords.Text = excludedWords;

            // 初始化 OpenCC。
            ZhConverter.Initialize();
        }
        catch (Exception ex)
        {
            CustomFunction.WriteLog(TBLog, ex.Message);
        }
    }

    /// <summary>
    /// 建立 HttpClient
    /// </summary>
    /// <returns>HttpClient?</returns>
    private HttpClient? CreateHttpClient()
    {
        HttpClient? httpClient = _httpClientFactory?.CreateClient();

        // 為 HttpClient 設定使用者代理字串。
        httpClient?.DefaultRequestHeaders
            .Add("User-Agent", Properties.Settings.Default.UserAgent);

        return httpClient;
    }

    /// <summary>
    /// 執行產生播放清單檔案
    /// </summary>
    /// <param name="outputJsonc">布林值，使用 *.jsonc 格式，預設值為 false</param>
    /// <param name="appendComment">布林值，附加註解文字，預設值為 false</param>
    /// <param name="cancellationToken">CancellationToken</param>
    /// <returns>Task</returns>
    private async Task DoGeneratePlaylist(
        bool outputJsonc = false,
        bool appendComment = false,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        if (VariableSet.BilibiliMidSet.Count <= 0)
        {
            MessageBox.Show("請輸入 Bilibili 使用者的 mid。", Title);

            return;
        }

        using HttpClient? httpClient = CreateHttpClient();

        if (httpClient == null)
        {
            CustomFunction.WriteLog(TBLog, "發生錯誤 httpClient 為 null。");

            return;
        }

        foreach (string mid in VariableSet.BilibiliMidSet)
        {
            cancellationToken.ThrowIfCancellationRequested();

            // 播放清單檔案儲存的路徑。
            string savedPath = $@"C:\Users\{Environment.UserName}\Desktop\" +
                $"{(outputJsonc ? $"{mid}.jsonc" :
                    $"{VariableSet.DefalutPlaylistFileName}_Bilibili_{mid}_{DateTime.Now:yyyyMddHHmmss}.json")}";

            // 取標籤資訊。
            ReceivedObject<TList> receivedTList = await SpaceFunction.GetTList(httpClient!, mid);

            if (receivedTList.Code != 0)
            {
                string message = receivedTList.Message ?? "作業失敗，發生非預期的錯誤";

                CustomFunction.WriteLog(TBLog, message);

                continue;
            }

            List<TidData> tidDataSet = new();

            TList? tlist = receivedTList.Data;

            // 當 tlist，表示沒有取到有效的標籤資訊。
            if (tlist == null)
            {
                CustomFunction.WriteLog(TBLog, $"資料解析失敗，沒有取到有效的標籤資訊。" +
                    $"{Environment.NewLine}已取消產製 Bilibili 使用者（{mid}）的秒數播放清單檔案");

                continue;
            }

            SetTidDataList(tidDataSet, tlist);

            if (tidDataSet.Count <= 0)
            {
                CustomFunction.WriteLog(TBLog, $"資料解析失敗，沒有取到有效的標籤資訊。" +
                    $"{Environment.NewLine}已取消產製 Bilibili 使用者（{mid}）的秒數播放清單檔案");

                continue;
            }

            CustomFunction.WriteLog(
                TBLog,
                $"正在準備產製 Bilibili 使用者（{mid}）的秒數播放清單檔案。");

            foreach (TidData tidData in tidDataSet)
            {
                cancellationToken.ThrowIfCancellationRequested();

                CustomFunction.WriteLog(
                    TBLog,
                    $"正在處裡標籤「{tidData.Name}（{tidData.TID}）」的資料。");

                await GeneratePlaylist(
                    httpClient!,
                    TBLog,
                    savedPath,
                    mid,
                    outputJsonc,
                    appendComment,
                    tidData.TID,
                    VariableSet.BilibiliDefaultPS,
                    cancellationToken);
            }
        }

        MessageBox.Show("作業結束。", Title);
    }

    /// <summary>
    /// 產生播放清單檔案
    /// </summary>
    /// <param name="httpClient">HttpClient</param>
    /// <param name="control">TextBox</param>
    /// <param name="mid">字串，目標使用者的 mid</param>
    /// <param name="outputJsonc">布林值，使用 *.jsonc 格式，預設值為 false</param>
    /// <param name="appendComment">布林值，附加註解文字，預設值為 false</param>
    /// <param name="tid">數值，篩選目標分區，預設值為 0</param>
    /// <param name="path">字串，產生播放清單檔案的路徑</param>
    /// <param name="ps">數值，每頁項數（最小 1 最大 50），預設值為 30</param>
    /// <param name="cancellationToken">CancellationToken</param>
    /// <returns>Task</returns>
    public static async Task GeneratePlaylist(
        HttpClient httpClient,
        TextBox control,
        string path,
        string mid,
        bool outputJsonc = false,
        bool appendComment = false,
        int tid = 0,
        int ps = 30,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        List<SongDataSeconds> outputLists = new();

        // 取得分頁資訊。
        ReceivedObject<BilibiliApi.Models.Page> receivedPage = await SpaceFunction
            .GetPage(httpClient, mid, tid);

        if (receivedPage.Code != 0)
        {
            string message = receivedPage.Message ?? "作業失敗，發生非預期的錯誤";

            CustomFunction.WriteLog(control, message);

            return;
        }

        // 取得此標籤下的影片數量。
        int videoCount = receivedPage.Data?.Count ?? -1;

        if (videoCount > 0)
        {
            int pages = videoCount / ps,
                remainder = videoCount % ps;

            if (remainder > 0)
            {
                pages++;
            }

            int processCount = 1;

            for (int pn = 1; pn <= pages; pn++)
            {
                cancellationToken.ThrowIfCancellationRequested();

                CustomFunction.WriteLog(
                    control,
                    $"正在處裡第 {pn}/{pages} 頁的資料。");

                ReceivedObject<List<VList>> receivedVLists = await SpaceFunction
                    .GetVList(httpClient, mid, tid, pn, ps);

                if (receivedVLists.Code != 0)
                {
                    string message = receivedPage.Message ?? "作業失敗，發生非預期的錯誤";

                    CustomFunction.WriteLog(control, message);

                    return;
                }

                if (receivedVLists.Data != null)
                {
                    foreach (VList vlist in receivedVLists.Data)
                    {
                        cancellationToken.ThrowIfCancellationRequested();

                        CustomFunction.WriteLog(
                            control,
                            $"正在處裡第 {processCount}/{videoCount} 部影片的資料。");

                        processCount++;

                        // 強制將網址掛上 "/p1"，以免部分有多分頁的影片會無法被解析。
                        string url = $"https://b23.tv/{vlist?.Bvid}/p1",
                            title = vlist?.Title ?? string.Empty;

                        // 處理 title。
                        if (!string.IsNullOrEmpty(title))
                        {
                            // 排除 title 內會破壞 JSON 字串結構的內容。
                            title = string.Join(" ", title.Split(Path.GetInvalidFileNameChars()));

                            // 透過 OpenCC 轉換成正體中文。
                            title = ZhConverter.HansToTW(title, true);
                        }

                        bool hasExcludeWord = false;

                        List<string> excludedWords = VariableSet.ExcludedWords();

                        // 判斷 title 是否有要排除的字詞。
                        foreach (string excludeWord in excludedWords)
                        {
                            if (title.Contains(excludeWord))
                            {
                                hasExcludeWord = true;

                                CustomFunction.WriteLog(
                                    control,
                                    $"影片「{title}」的標題內有要排除的字詞「{excludeWord}」，故略過此影片。");

                                break;
                            }
                        }

                        if (hasExcludeWord)
                        {
                            continue;
                        }

                        // 只能判斷是不是特殊的網址而已。
                        bool isPassed = await CommonFunction.IsUrlValid(httpClient, url);

                        if (!isPassed)
                        {
                            CustomFunction.WriteLog(
                                control,
                                $"影片「{title}」的網址「{url}」為不支援的網址，故略過此影片。");

                            continue;
                        }

                        string length = vlist?.Length ?? string.Empty;

                        length = CommonFunction.GetFormattedLength(length);

                        TimeSpan endTime = TimeSpan.Parse(length);

                        double endSeconds = endTime.TotalSeconds;

                        // 根據網路資料取平均值，一首歌大約 4 分鐘。
                        if (endTime.TotalMinutes > Properties.Settings.Default.MaxMinute)
                        {
                            // 當時間長度大於 4 分鐘，有可能是不正確的長度時間。
                            CustomFunction.WriteLog(
                                control,
                                $"影片「{title}」的獲取影片長度時間為 {endSeconds} 秒，" +
                                $"已超過 {Properties.Settings.Default.MaxMinute} 分鐘，" +
                                $"故將結束的秒數值設為 0 秒。");

                            // 將結束秒數歸零。
                            endSeconds = 0;
                        }

                        if (outputLists.Any(n => n.VideoID == url))
                        {
                            CustomFunction.WriteLog(control, $"影片「{title}」已存在。");

                            continue;
                        }

                        outputLists.Add(new SongDataSeconds()
                        {
                            VideoID = url,
                            Name = title,
                            StartSeconds = 0,
                            EndSeconds = endSeconds
                        });
                    }
                }
            }
        }

        CustomFunction.WriteLog(
            control,
            $"Bilibili 使用者（{mid}）在此 tid（{tid}）下共有 {videoCount} 部影片，" +
            $"已成功處理 {outputLists.Count} 部影片的資料。");

        if (outputLists.Count > 0)
        {
            // 重新調整順序。（升冪）
            outputLists.Reverse();

            string jsonText = string.Empty;

            if (outputJsonc)
            {
                if (appendComment)
                {
                    // 來源：https://github.com/YoutubeClipPlaylist/Playlists/blob/BasePlaylist/Template/TemplateSongList.jsonc
                    string jsoncHeader = $"/**{Environment.NewLine}" +
                        $" * 歌單格式為JSON with Comments{Environment.NewLine}" +
                        $" * [\"VideoID\", StartTime, EndTime, \"Title\", \"SubSrc\"]{Environment.NewLine}" +
                        $" * VideoID: 必須用引號包住，為字串型態。{Environment.NewLine}" +
                        $" * StartTime: 只能是非負數。如果要從頭播放，輸入0{Environment.NewLine}" +
                        $" * EndTime: 只能是非負數。如果要播放至尾，輸入0{Environment.NewLine}" +
                        $" * Title?: 必須用引號包住，為字串型態{Environment.NewLine}" +
                        $" * SubSrc?: 必須用雙引號包住，為字串型態，可選{Environment.NewLine}" +
                        $" */{Environment.NewLine}";

                    jsonText += jsoncHeader;
                }

                jsonText += $"[{Environment.NewLine}";

                int countIdx = 0;

                foreach (SongDataSeconds songDataSeconds in outputLists)
                {
                    string endComma = countIdx == outputLists.Count - 1 ? string.Empty : ",";

                    jsonText += $"    [\"{songDataSeconds.VideoID}\", " +
                        $"{(songDataSeconds.StartSeconds.HasValue ? songDataSeconds.StartSeconds : 0)}, " +
                        $"{(songDataSeconds.EndSeconds.HasValue ? songDataSeconds.EndSeconds : 0)}, " +
                        $"\"{songDataSeconds.Name}\", " +
                        $"\"{songDataSeconds.SubSrc}\"]{endComma}{Environment.NewLine}";

                    countIdx++;
                }

                jsonText += "]";
            }
            else
            {
                jsonText = JsonSerializer.Serialize(outputLists, new JsonSerializerOptions()
                {
                    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                    // 忽略掉註解。
                    ReadCommentHandling = JsonCommentHandling.Skip,
                    WriteIndented = true
                });
            }

            using StreamWriter streamWriter = new(path, false, Encoding.UTF8);

            streamWriter.Write(jsonText);

            CustomFunction.WriteLog(
                control,
                $"已產生 Bilibili 使用者（{mid}）的秒數播放清單檔案：{path}");
        }
        else
        {
            CustomFunction.WriteLog(
                control,
                $"資料解析失敗，無法產生 Bilibili 使用者（{mid}）的秒數播放清單檔案。");
        }
    }

    /// <summary>
    /// 設定 List<TidData>
    /// </summary>
    /// <param name="dataSet">List&lt;TidData&gt;</param>
    /// <param name="tlist">TList</param>
    private static void SetTidDataList(List<TidData> dataSet, TList tlist)
    {
        // 只允許下列的 Tag 的資料。
        //※有些 Up 主會將音樂相關的影片放於動畫 Tag 下。

        if (tlist.Tag3 != null)
        {
            dataSet.Add(new TidData()
            {
                TID = tlist.Tag3.Tid,
                Name = tlist.Tag3.Name
            });
        }

        if (tlist.Tag28 != null)
        {
            dataSet.Add(new TidData()
            {
                TID = tlist.Tag28.Tid,
                Name = tlist.Tag28.Name
            });
        }

        if (tlist.Tag31 != null)
        {
            dataSet.Add(new TidData()
            {
                TID = tlist.Tag31.Tid,
                Name = tlist.Tag31.Name
            });
        }

        if (tlist.Tag59 != null)
        {
            dataSet.Add(new TidData()
            {
                TID = tlist.Tag59.Tid,
                Name = tlist.Tag59.Name
            });
        }

        if (tlist.Tag193 != null)
        {
            dataSet.Add(new TidData()
            {
                TID = tlist.Tag193.Tid,
                Name = tlist.Tag193.Name
            });
        }

        if (tlist.Tag29 != null)
        {
            dataSet.Add(new TidData()
            {
                TID = tlist.Tag29.Tid,
                Name = tlist.Tag29.Name
            });
        }
    }

    /// <summary>
    /// 設定控制項啟用／禁用
    /// </summary>
    /// <param name="isEnabled">布林值，是否啟用／禁用控制項，預設值為 true</param>
    private void SetControlsIsEnabled(bool isEnabled = true)
    {
        try
        {
            TBMid.IsReadOnly = !isEnabled;
            TBExcludedWords.IsReadOnly = !isEnabled;
            BtnGeneratePlaylist.IsEnabled = isEnabled;
            CBExportJsonc.IsEnabled = isEnabled;
            CBJsoncAppendComment.IsEnabled = isEnabled;
            BtnCancel.IsEnabled = !isEnabled;
            BtnClear.IsEnabled = isEnabled;
        }
        catch (Exception ex)
        {
            CustomFunction.WriteLog(TBLog, ex.Message);
        }
    }

    /// <summary>
    /// 檢查應用程式的版本
    /// </summary>
    private async void CheckAppVersion()
    {
        // 取得 HttpClient。
        using HttpClient? httpClient = CreateHttpClient();

        if (httpClient == null)
        {
            CustomFunction.WriteLog(TBLog, "發生錯誤 httpClient 為 null。");

            return;
        }

        UpdateNotifier.CheckResult checkResult = await UpdateNotifier.CheckVersion(httpClient);

        if (!string.IsNullOrEmpty(checkResult.MessageText))
        {
            CustomFunction.WriteLog(TBLog, checkResult.MessageText);
        }

        if (checkResult.HasNewVersion &&
            !string.IsNullOrEmpty(checkResult.DownloadUrl))
        {
            MessageBoxResult messageBoxResult = MessageBox.Show($"您是否要下載新版本 v{checkResult.VersionText}？",
                Title,
                MessageBoxButton.OKCancel,
                MessageBoxImage.Question);

            if (messageBoxResult == MessageBoxResult.OK)
            {
                CustomFunction.OpenBrowser(checkResult.DownloadUrl);

                // 結束應用程式。
                App.Current.Shutdown();
            }
        }

        if (checkResult.NetVersionIsOdler &&
            !string.IsNullOrEmpty(checkResult.DownloadUrl))
        {
            MessageBoxResult messageBoxResult = MessageBox.Show($"您是否要下載舊版本 v{checkResult.VersionText}？",
                Title,
                MessageBoxButton.OKCancel,
                MessageBoxImage.Question);

            if (messageBoxResult == MessageBoxResult.OK)
            {
                CustomFunction.OpenBrowser(checkResult.DownloadUrl);

                // 結束應用程式。
                App.Current.Shutdown();
            }
        }
    }
}