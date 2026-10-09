using System.Windows;

namespace PrimerProyecto
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            var user = UsernameTextBox.Text?.Trim();
            var pass = PasswordBox.Password ?? string.Empty;

            // Ejemplo simple: aceptar admin/1234 o user/user
            if (!string.IsNullOrEmpty(user) && ((user == "admin" && pass == "1234") || (user == "user" && pass == "user")))
            {
                var main = new MainWindow();
                // Establecer la ventana principal de la aplicación y asegurar que al cerrarla la app termine
                Application.Current.MainWindow = main;
                Application.Current.ShutdownMode = ShutdownMode.OnMainWindowClose;
                main.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show(this, "Usuario o contraseña incorrectos.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
