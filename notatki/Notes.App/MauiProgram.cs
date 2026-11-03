using Microsoft.Extensions.Logging;
using Notes.App.ViewModels;

namespace Notes.App
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
            builder.Services.AddSingleton<AddCategory>();
            builder.Services.AddSingleton<AddCategoryViewModel>();

            builder.Services.AddSingleton<AddNote>();
            builder.Services.AddSingleton<AddNoteViewModel>();

            builder.Services.AddSingleton<CategoryList>();
            builder.Services.AddSingleton<CategoryListViewModel>();

            builder.Services.AddSingleton<DisplayClickedNote>();
            builder.Services.AddSingleton<DisplayClickedNoteViewModel>();

            builder.Services.AddSingleton<NotesList>();
            builder.Services.AddSingleton<NotesListViewModel>();




            return builder.Build();
        }
    }
}
