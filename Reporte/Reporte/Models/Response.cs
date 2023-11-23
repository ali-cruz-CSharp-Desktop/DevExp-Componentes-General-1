using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporte.Models
{
    public class Response
    {
        public DataTable dt { get; set; }
        public bool ExistError { get; set; }
        public string MsgDB { get; set; }


    }
}
