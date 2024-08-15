using Microsoft.Extensions.Logging;

namespace LineSpacing
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
                    fonts.AddFont("1-mundial-hair-italic-tty.ttf", "Mundial Hair Italic");
                    fonts.AddFont("1-mundial-hair-tty.ttf", "Mundial Hair");
                    fonts.AddFont("2-mundial-thin-italic-tty.ttf", "Mundial Thin Italic");
                    fonts.AddFont("2-mundial-thin-tty.ttf", "Mundial Thin");
                    fonts.AddFont("3-mundial-light-italic-tty.ttf", "Mundial Light Italic");
                    fonts.AddFont("3-mundial-light-tty.ttf", "Mundial Light");
                    fonts.AddFont("4-mundial-regular-italic-tty.ttf", "Mundial Regular Italic");
                    fonts.AddFont("4-mundial-regular-tty.ttf", "Mundial Regular");
                    fonts.AddFont("5-mundial-demibold-italic-tty.ttf", "Mundial Demibold Italic");
                    fonts.AddFont("5-mundial-demibold-tty.ttf", "Mundial Demibold");
                    fonts.AddFont("6-mundial-bold-italic-tty.ttf", "Mundial Bold Italic");
                    fonts.AddFont("6-mundial-bold-tty.ttf", "Mundial Bold");
                    fonts.AddFont("7-mundial-black-italic-tty.ttf", "Mundial Black Italic");
                    fonts.AddFont("7-mundial-black-tty.ttf", "Mundial Black");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
