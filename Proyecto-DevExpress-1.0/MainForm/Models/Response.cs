using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.Models
{
    public class Response
    {
        public DataTable dt { get; set; }
        public DataSet ds { get; set; }
        public string Msg { get; set; }
        public int RowAffected { get; set; }

    }
}
