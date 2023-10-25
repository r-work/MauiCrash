namespace MauiCrash;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();

        var timer = new System.Timers.Timer(5000) { AutoReset = false };
        timer.Elapsed += Timer_Elapsed;
        timer.Start();
    }

    private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
    {
        MainThread.BeginInvokeOnMainThread(() => Application.Current.MainPage = new AppShell());
    }
}