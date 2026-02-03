using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        List<string> categories = new List<string>();
        public WindowEditAdd()
        {
            InitializeComponent();

            categories.Add("Платно");
            categories.Add("Бесплатно");

            comBoxCategories.ItemsSource = categories;
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
