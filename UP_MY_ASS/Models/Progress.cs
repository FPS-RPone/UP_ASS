using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP_ASS.Models
{
    public class Progress
    {
        public int ProgressId { get; set; }
        [MaxLength(200)]
        public string? UserName { get; set; }
        public User? User { get; set; } //Пользователь

        [MaxLength(200)]
        public string? LessonName { get; set; }
        public Lesson? Lesson { get; set; }
        public string? Status { get; set; }
    }
}
