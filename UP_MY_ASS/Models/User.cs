using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP_ASS.Models
{
    public class User
    {
        //Разделение на учеников и преподавателей
        public int Id { get; set; }
        [MaxLength (50)]
        public string? Name { get; set; }
        [MaxLength(100)]
        public string? Login { get; set; }
        [MaxLength(50)]
        public string? Password { get; set; }
        public Role? Role { get; set; }
        public ObservableCollection<Course>? Courses { get; set; }
    }
}
