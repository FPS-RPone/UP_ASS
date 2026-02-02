using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP_ASS.Models
{
    public class Progress
    {
        public int ProgressId { get; set; }
        public User? User { get; set; } //Пользователь
        public Course? Course { get; set; } //Курс пользователя
        public Lesson? Lesson { get; set; } //Урок
        public int OnLesson { get; set; } //Пользователь сейчас на уроке
        public int TotalLessons { get; set; } //Всего уроков
        public float CurrentProgress { get; set; } //Прогресс по урокам в процентах, текущий / Всего
    }
}
