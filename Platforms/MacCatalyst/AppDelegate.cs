﻿using Foundation;

namespace KitchenStockManager
{
    [Register("AppDelegate")]
    public class AppDelegate : MauiUIApplicationDelegate
    {
        protected override Microsoft.Maui.Hosting.MauiApp CreateMauiApp() => AppBuild.CreateMauiApp();
    }
}
