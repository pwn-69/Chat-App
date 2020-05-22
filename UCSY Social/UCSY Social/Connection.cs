using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCSY_Social
{
    class Connection
    {
        private string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\.database\UCSY Social.mdf;Integrated Security=True;Connect Timeout=30";
        public string get_constr()
        {
            return constr;
        }
    }
}