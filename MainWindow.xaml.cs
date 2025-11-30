using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using MyApp.Features.Auth;
using MyApp.Features.Dashboard;
using MyApp.Features.FamilyList;
using MyApp.Features.NewFamily;
using MyApp.Features.Settings;

namespace MyApp
{
    public sealed partial class MainWindow : Window
    {
        public static MainWindow Instance { get; private set; }

        public MainWindow()
        {
            this.InitializeComponent();
            Instance = this;

            // Start with normal system title bar
            ExtendsContentIntoTitleBar = false;

            var hWnd = WinRT.Interop.WindowNative.GetWindowHandle(this);
            var windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(hWnd);
            var appWindow = AppWindow.GetFromWindowId(windowId);

            // Default size
            appWindow.Resize(new Windows.Graphics.SizeInt32(1000, 700));

            ShowLogin();
        }

        public void ShowLogin()
        {
            // Use system title bar
            ExtendsContentIntoTitleBar = false;

            // Hide custom bars
            AppTitleBar.Visibility = Visibility.Collapsed;

            NavView.Visibility = Visibility.Collapsed;
            LoginFrame.Visibility = Visibility.Visible;
            LoginFrame.Navigate(typeof(LoginPage));
        }

        public void ShowShell()
        {
            // Switch to custom title bar
            ExtendsContentIntoTitleBar = true;
            SetTitleBar(AppTitleBar);

            LoginFrame.Visibility = Visibility.Collapsed;
            NavView.Visibility = Visibility.Visible;

            // Show custom shell title bar
            AppTitleBar.Visibility = Visibility.Visible;

            ContentFrame.Navigate(typeof(DashboardPage));
        }

        private void TitleBar_PaneToggleRequested(TitleBar sender, object args)
        {
            if (NavView.Visibility == Visibility.Visible)
            {
                NavView.IsPaneOpen = !NavView.IsPaneOpen;
            }
        }

        private void TitleBar_BackRequested(TitleBar sender, object args)
        {
            if (ContentFrame.CanGoBack)
            {
                ContentFrame.GoBack();
            }
        }

        private void NavView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            var item = args.InvokedItemContainer as NavigationViewItem;
            if (item == null) return;

            switch (item.Tag as string)
            {
                case "Dashboard":
                    ContentFrame.Navigate(typeof(DashboardPage));
                    break;
                case "Settings":
                    ContentFrame.Navigate(typeof(SettingsPage));
                    break;
                case "FamilyList":
                    ContentFrame.Navigate(typeof(FamilyListPage));
                    break;
                case "NewFamily":
                    ContentFrame.Navigate(typeof(NewFamilyPage));
                    break;
                case "Logout":
                    ContentFrame.BackStack.Clear();
                    ShowLogin();
                    break;

            }
        }
    }
}