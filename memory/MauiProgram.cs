using memory.ViewModels;
using Microsoft.Extensions.Logging;

namespace memory
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
#endif
            builder.Services.AddSingleton<MainViewModel>();
            builder.Services.AddSingleton<MainPage>();

            builder.Services.AddSingleton<GameEasyViewModel>();
            builder.Services.AddSingleton<GameEasyPage>();

            builder.Services.AddSingleton<GameMidViewModel>();
            builder.Services.AddSingleton<GameMidPage>();

            builder.Services.AddSingleton<GameHardViewModel>();
            builder.Services.AddSingleton<GameHardPage>();


            return builder.Build();
        }
    }
}
