using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP_ASS.Models
{
    public class Role
    {
        public int RoleId { get; set; } //Id и уровень привилегий
        //0 - гость, 1 - пользователь, 2 - преподаватель, 3 - менеджер, 4 - админ и т.д.
        [MaxLength(50)]
        public string? RoleName { get; set; } //Название роли
        [MaxLength(150)] 
        public string? RoleDescription { get; set; } //Описание роли
    }
}
