using Avalonia.Controls;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DesktopAvaloniaAppMentor4U.Classic.Components.InputComponents
{
    public partial class InputComponent : UserControl, INotifyPropertyChanged
    {
        private string _label;
        public string LabelName
        {
            get => _label;
            set => SetField(ref _label, value);
        }

        private string _input;
        public string Input
        {
            get => _input;
            set => SetField(ref _input, value);
        }

        public InputComponent()
        {

            InitializeComponent();
            DataContext = this;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
