using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UP_ASS.Models;

namespace UP_MY_ASS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void buttLogin_Click(object sender, RoutedEventArgs e)
        {
            MainDB db = new MainDB();

            User? user = db.Users.FirstOrDefault(u => 
                                                u.Login == tBoxLogin.Text &&
                                                u.Password == tBoxPassword.Text);

            if (user == null) {
                MessageBox.Show("Неправильное имя пользователя\t" +
                                "Или пароль!");
                return;
            }

            LoginUser.Name = user.Name;
            LoginUser.RolePower = user.Role.RolePower;

        }

        private void buttQuit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}