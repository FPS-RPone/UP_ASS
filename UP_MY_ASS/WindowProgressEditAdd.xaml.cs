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
    /// Interaction logic for WindowProgressEditAdd.xaml
    /// </summary>
    public partial class WindowProgressEditAdd : Window
    {
        List <string> Status = new List<string>(); 

        MainDB db = new MainDB();
        public WindowProgressEditAdd()
        {
            InitializeComponent();

            Status.Add("В процессе");
            Status.Add("Завершено");

            comboxStatus.ItemsSource = Status;
        }

        private void buttDone_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void buttQuit_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
