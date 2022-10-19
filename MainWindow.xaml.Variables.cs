using System.Net.Http;

namespace B23PlaylistGenerator;

public partial class MainWindow
{
    /// <summary>
    /// 共用的 IHttpClientFactory
    /// </summary>
    private readonly IHttpClientFactory? _httpClientFactory;

    /// <summary>
    /// 共用的 CancellationTokenSource
    /// </summary>
    private CancellationTokenSource? sharedCancellationTokenSource;

    /// <summary>
    /// 共用的 CancellationTokenSource
    /// </summary>
    private CancellationToken? sharedCancellationToken;
}