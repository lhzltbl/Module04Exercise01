using Module02Exercise01.View;
using Module02Exercise01.Services;
using Microsoft.Extensions.Logging;

namespace Module02Exercise01
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();

            //Services
            builder.Services.AddSingleton<IMyService, MyService>();

            //Content Page
            builder.Services.AddTransient<LoginPage>();
#endif

            return builder.Build();
        }
    }
}
