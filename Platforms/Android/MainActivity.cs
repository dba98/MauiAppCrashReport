using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;

namespace MauiAppCrashReport;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true,
    ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode |
                           ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
[IntentFilter(new[] { Intent.ActionView },
    Categories = new[] { Intent.CategoryDefault, Intent.CategoryBrowsable },
    DataScheme = "myapp")]
public class MainActivity : MauiAppCompatActivity
{
    protected override async void OnNewIntent(Intent intent)
    {
        base.OnNewIntent(intent);

        if (intent.Action == Intent.ActionView)
        {
            // Handle the incoming URL here
            var uri = intent.DataString;
            if (uri != null)
            {
                // Process the URL and navigate accordingly
                //await _navigationService.NavigateToAsync("/Register");
            }
        }
    }
}