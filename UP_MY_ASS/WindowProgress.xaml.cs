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
    /// Interaction logic for WindowProgress.xaml
    /// </summary>
    public partial class WindowProgress : Window
    {
        MainDB db = new MainDB();
        ObservableCollection<Progress> Progresses = new ObservableCollection<Progress>();
        public WindowProgress()
        {
            InitializeComponent();

            db.Progresses.Load();

            Progresses = db.Progresses.Local.ToObservableCollection();

            itemsProgresses.ItemsSource = Progresses;
        }

        private void buttProgressAdd_Click(object sender, RoutedEventArgs e)
        {
            Progress p = new Progress();

            WindowProgressEditAdd w = new WindowProgressEditAdd();

            w.DataContext = p;

            w.comboxUsers.ItemsSource = db.Users.ToList();
            w.comboxLessons.ItemsSource = db.Lessons.ToList();

            w.ShowDialog();

            if (w.DialogResult == true)
            {
                p.UserName = p.User.Name;
                p.LessonName = p.Lesson.Name;
                Progresses.Add(p);
                db.SaveChanges();
            }
        }

        private void StackPanel_EditMouseDown(object sender, MouseButtonEventArgs e)
        {
            if ((sender as StackPanel).DataContext is Progress p)
            {
                WindowProgressEditAdd w = new WindowProgressEditAdd();

                w.DataContext = p;
                
                w.comboxUsers.ItemsSource = db.Users.ToList();
                w.comboxLessons.ItemsSource = db.Lessons.ToList();

                w.ShowDialog();
                if (w.DialogResult == true)
                {
                    p.UserName = p.User.Name;
                    p.LessonName = p.Lesson.Name;
                    db.SaveChanges();
                }
            }
        }
    }
}
