using System.Windows;
using System.Windows.Input;

namespace Uncluster;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void TitleBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        if (e.ButtonState == MouseButtonState.Pressed)
            DragMove();
    }

    private void CloseButton_Click(object sender, RoutedEventArgs e)
    {
        Application.Current.Shutdown();
    }

    private void SettingsButton_Click(object sender, RoutedEventArgs e)
    {
        // Settings panel — wired in a later step
    }

    private void MainToggleButton_Click(object sender, RoutedEventArgs e)
    {
        // Toggle logic — wired in a later step
    }
}
