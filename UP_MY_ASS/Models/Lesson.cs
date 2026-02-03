using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP_ASS.Models
{
    public class Lesson
    {
        //Название, цена, кто ведёт
        public int Id { get; set; } 
        public float? Price { get; set; }
        [MaxLength(50)]
        public string? Name { get; set; }
        [MaxLength(200)]
        public string? Description { get; set; }
        [MaxLength(200)]
        public string? Courser { get; set; }

        public User? User { get; set; } //Преподаватель
    }
}
