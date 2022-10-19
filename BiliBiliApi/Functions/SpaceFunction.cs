using BilibiliApi.Common;
using BilibiliApi.Models;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BilibiliApi.Functions;

/// <summary>
/// Bilibili 使用者空間 API 函式
/// </summary>
public class SpaceFunction
{
    /// <summary>
    /// 共用的 JsonSerializerOptions
    /// </summary>
    private static readonly JsonSerializerOptions Options = new()
    {
        ReadCommentHandling = JsonCommentHandling.Skip,
        AllowTrailingCommas = true,
        NumberHandling = JsonNumberHandling.AllowReadingFromString |
            JsonNumberHandling.WriteAsString
    };

    /// <summary>
    /// 取得 tlist
    /// </summary>
    /// <param name="httpClient">HttpClient</param>
    /// <param name="mid">字串，目標使用者的 mid</param>
    /// <returns>Task&lt;ReceivedObject&lt;lTList&gt;&gt;</returns>
    public static async Task<ReceivedObject<TList>> GetTList(
        HttpClient httpClient,
        string mid)
    {
        string apiUrl = $"{VariableSet.BilibiliSpaceApiUrl}?mid={mid}";

        using HttpResponseMessage response = await httpClient.GetAsync(apiUrl);
        using HttpContent content = response.Content;

        string jsonContent = await content.ReadAsStringAsync();

        SearchRoot? searchRoot = JsonSerializer.Deserialize<SearchRoot>(jsonContent, Options);

        return new ReceivedObject<TList>()
        {
            Code = searchRoot?.Code ?? -1,
            Message = searchRoot?.Message,
            Data = searchRoot?.Data?.List?.TList
        };
    }

    /// <summary>
    /// 取得 page
    /// </summary>
    /// <param name="httpClient">HttpClient</param>
    /// <param name="mid">字串，目標使用者的 mid</param>
    /// <returns>Task&lt;ReceivedObject&lt;Page&gt;&gt;</returns>
    public static async Task<ReceivedObject<Page>> GetPage(
        HttpClient httpClient,
        string mid,
        int tid)
    {
        string apiUrl = $"{VariableSet.BilibiliSpaceApiUrl}?mid={mid}&tid={tid}";

        using HttpResponseMessage response = await httpClient.GetAsync(apiUrl);
        using HttpContent content = response.Content;

        string jsonContent = await content.ReadAsStringAsync();

        SearchRoot? searchRoot = JsonSerializer.Deserialize<SearchRoot>(jsonContent, Options);

        return new ReceivedObject<Page>()
        {
            Code = searchRoot?.Code ?? -1,
            Message = searchRoot?.Message,
            Data = searchRoot?.Data?.Page
        };
    }

    /// <summary>
    /// 取得 vlist
    /// </summary>
    /// <param name="httpClient">HttpClient</param>
    /// <param name="mid">字串，目標使用者的 mid</param>
    /// <param name="tid">數值，篩選目標分區，預設值為 0</param>
    /// <param name="pn">數值，頁碼，預設值為 1 </param>
    /// <param name="ps">數值，每頁項數（最小 1 最大 50），預設值為 30</param>
    /// <returns>Task&lt;ReceivedObject&lt;List&lt;VList&gt;&gt;&gt;</returns>
    public static async Task<ReceivedObject<List<VList>>> GetVList(
        HttpClient httpClient,
        string mid,
        int tid = 0,
        int pn = 1,
        int ps = 30)
    {
        string apiUrl = $"{VariableSet.BilibiliSpaceApiUrl}?mid={mid}&tid={tid}&pn={pn}&ps={ps}";

        using HttpResponseMessage response = await httpClient.GetAsync(apiUrl);
        using HttpContent content = response.Content;

        string jsonContent = await content.ReadAsStringAsync();

        SearchRoot? searchRoot = JsonSerializer.Deserialize<SearchRoot>(jsonContent, Options);

        return new ReceivedObject<List<VList>>()
        {
            Code = searchRoot?.Code ?? -1,
            Message = searchRoot?.Message,
            Data = searchRoot?.Data?.List?.VList
        };
    }
}