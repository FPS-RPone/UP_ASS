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
    /// Логика взаимодействия для WindowCourses.xaml
    /// </summary>
    public partial class WindowCourses : Window
    {
        MainDB db = new MainDB();
        ObservableCollection<Course> courses = new ObservableCollection<Course>();
        List<string> Categories = new List<string>();
        public WindowCourses()
        {
            InitializeComponent();

            tBoxWindowUsername.Text = LoginUser.Name;

            db.Courses.Load();

            courses = db.Courses.Local.ToObservableCollection();

            Categories.Add("Все");
            Categories.Add("Платно");
            Categories.Add("Бесплатно");

            comBoxCategory.ItemsSource = Categories;
            comBoxCategory.SelectedIndex = 0;

            itemsCourses.ItemsSource = courses;
        }

        private void comBoxCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comBoxCategory.SelectedItem.ToString() == "Все")
            {
                itemsCourses.ItemsSource = courses;
                return;
            }

            var list = courses.Where(c => c.Category ==
                                     comBoxCategory.SelectedItem.ToString());
            itemsCourses.ItemsSource = list;
        }

        private void tBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        //Редактирование по двойному клику
        private void itemsCourses_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if ((sender as ItemsControl).DataContext is Course c) { 

                if (DialogResult == true) {
                    WindowEditAdd w = new WindowEditAdd();
                    w.DataContext = c;
                    w.ShowDialog();

                    db.SaveChanges();
                }
            }
        }

        private void buttAdd_Click(object sender, RoutedEventArgs e)
        {
            Course c = new Course();

            WindowEditAdd w = new WindowEditAdd();

            w.DataContext = c;

            if (w.ShowDialog() == true)
            {
                courses.Add(c);

                db.SaveChanges();
            }
        }

        private void buttLessons_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
