using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyApp.Core.Models;

namespace MyApp.Features.Auth
{
    public partial class LoginViewModel : ObservableObject
    {
        [ObservableProperty]
        private User _user = new User();

        [RelayCommand]
        private void Login()
        {
            MainWindow.Instance.ShowShell();
        }
    }
}
