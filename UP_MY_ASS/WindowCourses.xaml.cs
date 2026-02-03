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

            //Отображение и прогрузка
            tBoxWindowUsername.Text = LoginUser.Name;

            db.Courses.Load();

            courses = db.Courses.Local.ToObservableCollection();

            //Добавим категории
            Categories.Add("Все");
            Categories.Add("Платно");
            Categories.Add("Бесплатно");

            comBoxCategory.ItemsSource = Categories;
            comBoxCategory.SelectedIndex = 0;

            itemsCourses.ItemsSource = courses;
        }

        //Поиск по категориям
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

        //Поиск по названию
        private void tBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tBoxSearch.Text == null || tBoxSearch.Text == "")
            {
                itemsCourses.ItemsSource = courses;
                return;
            }

            var list = courses.Where(c => c.Name == tBoxSearch.Text);

            itemsCourses.ItemsSource = list;
        }

        //Редактирование по двойному клику
        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if ((sender as StackPanel).DataContext is Course c)
            {

                WindowEditAdd w = new WindowEditAdd();
                w.DataContext = c;
                w.ShowDialog();

                if (w.DialogResult == true)
                    db.SaveChanges();
            }
        }
 

        //Добавление нового курса
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

        //Отображение уроков
        private void buttProgress_Click(object sender, RoutedEventArgs e)
        {
            WindowProgress w = new WindowProgress();

            w.ShowDialog();
        }

    }
}
