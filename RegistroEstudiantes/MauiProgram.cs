using Microsoft.Extensions.Logging;

using RegistroEstudiantes.ViewModels;
using RegistroEstudiantes.Views;

namespace RegistroEstudiantes
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder
                .UseMauiApp<App>();

            builder.Services.AddSingleton<RegistroViewModel>();
            builder.Services.AddSingleton<RegistroPage>();

            return builder.Build();
        }
    }
}