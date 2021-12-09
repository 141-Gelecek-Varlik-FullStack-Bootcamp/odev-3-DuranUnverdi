using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityLayer.Concrete
{
   public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(30), Display(Name = "Name")]
        public string Name { get; set; }
        [StringLength(30), Display(Name = "SurName")]
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Status { get; set; }
    }
}
