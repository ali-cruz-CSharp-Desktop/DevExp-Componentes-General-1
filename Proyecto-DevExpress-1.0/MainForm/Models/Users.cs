using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.Models
{
    public class Users
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int RoleTitle { get; set; }
        public int RoleID { get; set; }
        public bool Activo { get; set; }
        public string Descripcion { get; set;}
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
