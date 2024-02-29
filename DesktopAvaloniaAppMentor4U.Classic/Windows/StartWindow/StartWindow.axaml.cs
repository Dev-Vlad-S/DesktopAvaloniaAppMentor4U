using Avalonia.Controls;
using Avalonia.Interactivity;
using System;
using System.ComponentModel;
using Tmds.DBus.Protocol;
using MsBox.Avalonia.Enums;
using MsBox.Avalonia;

namespace DesktopAvaloniaAppMentor4U.Classic.Windows.StartWindow
{
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            InitializeComponent();
            this.Closing += OnClosing;
        }

        private async void OnClosing(object? sender, CancelEventArgs e)
        {
            var box = MessageBoxManager.
               GetMessageBoxStandard("Caption", "¬ы действительно хотите закрыть приложение?",
               ButtonEnum.YesNo);

            var result = await box.ShowAsync();

            if(result == ButtonResult.No)
            {
                e.Cancel = true;
            }


            //var result = MessageBox.Show(
            //    owner: this,
            //    messageBoxText: "¬ы действительно хотите закрыть приложение?",
            //    caption: App.Current.Resources["AppTitle"].ToString(),
            //    button: MessageBoxButton.YesNo,
            //    icon: MessageBoxImage.Stop);
            //if (result == MessageBoxResult.No)
            //{
            //    e.Cancel = true;
            //}
        }

        //private EventHandler<WindowClosingEventArgs> OnClosing()
        //{
        //    throw new NotImplementedException();
        //}

        public void ButtonClose_OnClick(object sender, RoutedEventArgs args)
        {
            this.Close();
        }

        public void ButtonAuth_OnClick(object sender, RoutedEventArgs args)
        {
            new AuthWindow.AuthWindow().Show();
            this.Closing -= OnClosing;
            this.Close();
        }
    }
}
