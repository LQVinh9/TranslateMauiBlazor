using Microsoft.Extensions.Logging;
using TranslateMauiBlazor.Interfaces;
using TranslateMauiBlazor.Services;
using CommunityToolkit.Maui;

namespace TranslateMauiBlazor;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>().ConfigureFonts(fonts =>
        {
            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular").AddFont("BanhMi.ttf");
        }).UseMauiCommunityToolkit();
        builder.Services.AddMauiBlazorWebView();
#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
        builder.Logging.AddDebug();
#endif
        builder.Services.AddSingleton<ITranslateService, TranslateService>();
        builder.Services.AddSingleton<ICultureService, CultureService>();
        builder.Services.AddAntDesign();
        return builder.Build();
    }
}