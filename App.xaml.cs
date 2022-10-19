using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace B23PlaylistGenerator;

/// <summary>
/// Interaction logic for App.xaml
/// <para>參考來源：https://executecommands.com/dependency-injection-in-wpf-net-core-csharp/ </para>
/// </summary>
public partial class App : Application
{
    private IServiceProvider? ServiceProvider { get; set; }

    public App()
    {
        ServiceCollection serviceCollection = new();

        ConfigureServices(serviceCollection);

        ServiceProvider = serviceCollection.BuildServiceProvider();
    }

    private static void ConfigureServices(ServiceCollection services)
    {
        services.AddHttpClient().AddSingleton<MainWindow>();
    }

    private void OnStartup(object sender, StartupEventArgs e)
    {
        MainWindow? mainWindow = ServiceProvider?.GetService<MainWindow>();

        mainWindow?.Show();
    }
}