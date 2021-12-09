using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityLayer.Concrete
{
    //UserDto modelini oluşturduk
    public class UserDto
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
    }
    //User tablosundaki int olan status kodlarını string halini Maplediğimiz class'a ekleme işlemi 
    public enum UserStatusEnum
    {
        Active=0,
        Pedding=1,
        Passive=2
    }
}
