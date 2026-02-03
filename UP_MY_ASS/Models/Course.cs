using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UP_ASS.Models
{
    public class Course
    {
        //Название, цена, кто ведёт
        public int Id { get; set; }
        public float? Price { get; set; }
        [MaxLength(50)]
        public string? Name { get; set; }
        [MaxLength(50)]
        public string? Category { get; set; } //Платно или бесплатно
        [MaxLength(200)]
        public string? Description { get; set; }
        public string? Courser { get; set; }
        public User? User { get; set; } //Преподаватель

        //public Course(int Id, float Price, string? Name, string? Category, string? Description)
        //{
        //    this.Id = Id;
        //    this.Price = Price;
        //    this.Name = Name;
        //    this.Category = Category;
        //    this.Description = Description;
        //    this.LessonsTotal = 5;
        //}       
    }   
}
