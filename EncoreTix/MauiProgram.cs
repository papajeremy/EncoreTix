using EncoreTix.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Reflection;

namespace EncoreTix
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts( fonts =>
                {
                    fonts.AddFont( "Inter-Italic-VariableFont_.ttf", "Inter-Italic" );
                    fonts.AddFont( "Inter-VariableFont.ttf", "Inter-Regular" );
                } );
            var assembly = Assembly.GetExecutingAssembly();
            using var stream = assembly.GetManifestResourceStream("EncoreTix.appsettings.json");
            var config = new ConfigurationBuilder()
                .AddJsonStream(stream)
                .Build();
            builder.Configuration.AddConfiguration( config );
            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddSingleton<TicketMasterService>();

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
