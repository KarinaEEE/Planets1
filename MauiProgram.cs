using Microsoft.Extensions.Logging;

namespace MauiPlanet
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
                    
                    fonts.AddFont("dogicabold.otf", "RegularFront");
                    fonts.AddFont("VCR_OSD_MONO_1.001.ttf", "MediumFrontd");
                    fonts.AddFont("dogicapixel.otf", "BoldFront");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
