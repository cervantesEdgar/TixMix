using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;

namespace TixMix.ViewModels
{
    public class LoginViewModel : ObservableObject
    {
        private string _username;
        public string Username
        {
            get => _username;
            set => SetProperty(ref _username, value);
        }

        private string _password;
        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        private string _errorMessage;
        public string ErrorMessage
        {
            get => _errorMessage;
            set => SetProperty(ref _errorMessage, value);
        }

        public IRelayCommand LoginCommand { get; }

        public event EventHandler LoginSuccess;

        public LoginViewModel()
        {
            LoginCommand = new RelayCommand(Login);
        }

        private void Login()
        {
            if (Username == "admin" && Password == "admin")
            {
                LoginSuccess?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                ErrorMessage = "Invalid username or password.";
            }
        }
    }
}
