using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;

namespace AvaloniaMeasureArrange
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif

            RandomPanel randomPanel = new RandomPanel();
            randomPanel.Background = Brushes.Pink;
            randomPanel.HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center;
            randomPanel.VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center;

            for (int i = 0; i < 5; i++)
            {
                randomPanel.Children.Add(new Button() { Content = "Hello World" });
            }

            this.Content = randomPanel;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}