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

            WindowCourses w = new WindowCourses();

            w.Show();
            this.Close();
        }

        private void buttQuit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void buttSignInAsGuest_Click(object sender, RoutedEventArgs e)
        {
            WindowCourses w = new WindowCourses();

            LoginUser.IsGuest = true;
            LoginUser.Name = "Гость";
            w.stackpanelTools.Visibility = Visibility.Collapsed;
            w.Show();
            this.Close();
        }
    }
}