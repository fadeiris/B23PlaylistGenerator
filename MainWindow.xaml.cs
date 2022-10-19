using B23PlaylistGenerator.Common;
using B23PlaylistGenerator.Common.Sets;
using System.Net.Http;
using System.Windows;
using System.Windows.Controls;

namespace B23PlaylistGenerator;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow(IHttpClientFactory httpClientFactory)
    {
        InitializeComponent();

        _httpClientFactory = httpClientFactory;
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
        try
        {
            CustomInit();
            CheckAppVersion();
        }
        catch (Exception ex)
        {
            CustomFunction.WriteLog(TBLog, ex.Message);
        }
    }

    private void TBUserAgent_TextChanged(object sender, TextChangedEventArgs e)
    {
        try
        {
            // 將值指派給變數。
            string value = (sender as TextBox)?.Text ?? string.Empty;

            if (!string.IsNullOrEmpty(value) &&
                value != Properties.Settings.Default.UserAgent)
            {
                Properties.Settings.Default.UserAgent = value;
                Properties.Settings.Default.Save();
            }
        }
        catch (Exception ex)
        {
            CustomFunction.WriteLog(TBLog, ex.Message);
        }
    }

    private void TBMid_TextChanged(object sender, TextChangedEventArgs e)
    {
        try
        {
            // 將值指派給變數。
            string value = (sender as TextBox)?.Text ?? string.Empty;

            VariableSet.BilibiliMidSet = value.Split(
                    Environment.NewLine.ToCharArray(),
                    StringSplitOptions.RemoveEmptyEntries)
                .ToList();
        }
        catch (Exception ex)
        {
            CustomFunction.WriteLog(TBLog, ex.Message);
        }
    }

    private void TBExcludedWords_TextChanged(object sender, TextChangedEventArgs e)
    {
        try
        {
            // 將值指派給變數。
            string value = (sender as TextBox)?.Text ?? string.Empty;

            List<string> excludedWords = value.Split(
                    Environment.NewLine.ToCharArray(),
                    StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string formatedValue = string.Join(",", excludedWords);

            if (formatedValue != Properties.Settings.Default.ExcludedWords)
            {
                Properties.Settings.Default.ExcludedWords = formatedValue;
                Properties.Settings.Default.Save();
            }
        }
        catch (Exception ex)
        {
            CustomFunction.WriteLog(TBLog, ex.Message);
        }
    }

    private void CBExportJsonc_Unchecked(object sender, RoutedEventArgs e)
    {
        bool value = CBJsoncAppendComment.IsChecked ?? false;

        if (value)
        {
            CBJsoncAppendComment.IsChecked = false;
        }
    }

    private void CBJsoncAppendComment_Checked(object sender, RoutedEventArgs e)
    {
        bool value1 = (sender as CheckBox)?.IsChecked ?? false;
        bool value2 = CBExportJsonc.IsChecked ?? false;

        if (value1)
        {
            if (!value2)
            {
                CBJsoncAppendComment.IsChecked = false;

                MessageBox.Show($"請先勾選「{CBExportJsonc.Content}」。", Title);
            }
        }
    }

    private async void BtnGeneratePlaylist_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            SetControlsIsEnabled(false);

            if (VariableSet.BilibiliMidSet.Count > 5)
            {
                MessageBoxResult messageBoxResult = MessageBox
                   .Show("一次處裡的 mid 數量，建議不要超過 5 個，" +
                       "若是過於頻繁的操作，有可能會讓您的 IP 地址會被 Bilibili 網站進行封鎖。" +
                       "請問您要繼續執行嗎？",
                       Title,
                       MessageBoxButton.OKCancel,
                       MessageBoxImage.Warning);

                if (messageBoxResult == MessageBoxResult.Cancel)
                {
                    return;
                }
            }

            // 先清除 TBLog 的內容。
            TBLog.Clear();

            sharedCancellationTokenSource = new();
            sharedCancellationToken = sharedCancellationTokenSource.Token;

            await DoGeneratePlaylist(CBExportJsonc.IsChecked ?? false,
                CBJsoncAppendComment.IsChecked ?? false,
                sharedCancellationToken.Value);
        }
        catch (Exception ex)
        {
            CustomFunction.WriteLog(TBLog, ex.Message);
        }
        finally
        {
            SetControlsIsEnabled(true);

            // 重設變數。
            sharedCancellationTokenSource = null;
            sharedCancellationToken = null;
        }
    }

    private void BtnCancel_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            if (sharedCancellationTokenSource != null &&
                !sharedCancellationTokenSource.IsCancellationRequested)
            {
                sharedCancellationTokenSource.Cancel();
            }
        }
        catch (Exception ex)
        {
            CustomFunction.WriteLog(TBLog, ex.Message);
        }
    }

    private void BtnClear_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            TBMid.Clear();
            TBLog.Clear();
            CBExportJsonc.IsChecked = false;
            CBJsoncAppendComment.IsChecked = false;
        }
        catch (Exception ex)
        {
            CustomFunction.WriteLog(TBLog, ex.Message);
        }
    }
}