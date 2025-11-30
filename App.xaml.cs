using Microsoft.UI.Xaml;

namespace MyApp
{
    public partial class App : Application
    {
        private Window? _window;

        public App()
        {
            InitializeComponent();
        }

        protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
        {
            Core.Database.DatabaseContext.Initialize();

            _window = new MainWindow();
            _window.Activate();
        }
    }
}
