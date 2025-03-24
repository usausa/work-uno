namespace UnoApp;

using Microsoft.UI.Windowing;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();
    }

    private void MainPage_OnLoading(FrameworkElement sender, object args)
    {
        var app = (App)Application.Current;
        app.MainWindow!.AppWindow.SetPresenter(AppWindowPresenterKind.FullScreen);
    }
}
