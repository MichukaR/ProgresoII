namespace ReyesMProgII;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }
    
    private void BotonAChistes(object? sender, EventArgs e)
    {
        Navigation.PushAsync(new ChistesView());
    }
    private void BotonAAbout(object? sender, EventArgs e)
    {
        Navigation.PushAsync(new AboutView());
    }
}