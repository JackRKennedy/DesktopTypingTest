using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;

namespace DesktopTypingTest;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        
        // Buttons - hand on hover, arrow otherwise
        StartButton.PointerEntered += (s, e) => Cursor = new Cursor(StandardCursorType.Hand);
        StartButton.PointerExited += (s, e) => Cursor = new Cursor(StandardCursorType.Arrow);
        StopButton.PointerEntered += (s, e) => Cursor = new Cursor(StandardCursorType.Hand);
        StopButton.PointerExited += (s, e) => Cursor = new Cursor(StandardCursorType.Arrow);
        ResetButton.PointerEntered += (s, e) => Cursor = new Cursor(StandardCursorType.Hand);
        ResetButton.PointerExited += (s, e) => Cursor = new Cursor(StandardCursorType.Arrow);
        
    }
    
    private void StartTest(object? sender, RoutedEventArgs e)
    {
        // Start timer, start words scrolling across screen
        throw new System.NotImplementedException();
    }

    private void StopTest(object? sender, RoutedEventArgs e)
    {
        // Pause timer and stop words
        throw new System.NotImplementedException();
    }

    private void ResetTest(object? sender, RoutedEventArgs e)
    {
        // Reset the test
        throw new System.NotImplementedException();
    }
}