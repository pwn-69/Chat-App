using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCSY_Social
{
    class Session
    {
        public string session_name { get; set; }
        public int login_status { get; set; }
        public int save_login_status { get; set; }
        public string login_email { get; set; }
        public Session() { }
        public Session(string session_name, int login_status, int save_login_status, string login_email)
        {
            this.session_name = session_name;
            this.login_status = login_status;
            this.save_login_status = save_login_status;
            this.login_email = login_email;
        }
    }
}