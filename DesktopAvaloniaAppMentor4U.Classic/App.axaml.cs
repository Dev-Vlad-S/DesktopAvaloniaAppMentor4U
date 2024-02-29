using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using DesktopAvaloniaAppMentor4U.Classic.Windows.StartWindow;

namespace DesktopAvaloniaAppMentor4U.Classic
{
    public partial class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new StartWindow();
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}