using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using UP_ASS.Models;

namespace UP_MY_ASS
{
    /// <summary>
    /// Логика взаимодействия для WindowEditAdd.xaml
    /// </summary>
    public partial class WindowEditAdd : Window
    {
        MainDB db = new MainDB();
        public WindowEditAdd()
        {
            InitializeComponent();

            db.Lessons.Load();

            comboxLessons.ItemsSource = db.Lessons.Local.ToObservableCollection();
        }

        private void buttDone_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void buttQuit_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
