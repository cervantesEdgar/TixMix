using System.Windows.Controls;

namespace TixMix.Views
{
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
            DataContext = new ViewModels.LoginViewModel();
        }
    }
}
