using Avalonia.Controls;
using Avalonia.Interactivity;
using MsBox.Avalonia.Enums;
using MsBox.Avalonia;

namespace DesktopAvaloniaAppMentor4U.Classic.Windows.AuthWindow
{
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }

        public async void Base_OnClick(object sender, RoutedEventArgs args)
        {
            var box = MessageBoxManager.GetMessageBoxStandard("Caption", $"{InputLogin.Input} {InputPassword.Input}",ButtonEnum.Ok);
            var result = await box.ShowAsync();
        }
    }
}
