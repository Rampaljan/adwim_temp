using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using mvvm_template.ViewModels;

namespace mvvm_template
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<MainViewModel>();
            builder.Services.AddSingleton<WynikiViewModel>();
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<WynikiPage>();
            builder.Services.AddTransient<SettingsViewModel>();
            builder.Services.AddTransient<SettingsPage>();

            //tutaj odchodzimy od dekalogu karola, ktory mowil mi jak dzialac z mvvm, nie uzywamy juz addtransient wszedzie, bo mainviewmodel i wynikiviewmodel musza byc ta samą instancją przez caly czas


            return builder.Build();
        }
    }
}
