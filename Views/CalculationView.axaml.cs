using Avalonia.Controls;

namespace Views
{
    public partial class CalculationView : UserControl
    {
        public CalculationView()
        {
            InitializeComponent();
            DataContext = CalculationViewModel.data;
        }

        private void Binding(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
        }
    }
}
