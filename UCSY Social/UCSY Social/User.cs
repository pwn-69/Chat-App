using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCSY_Social
{
    class User
    {
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string gender { get; set; }
        public DateTime dob { get; set; }
        public string bio { get; set; }
        public string one { get; set; }
        public string two { get; set; }
        public string three { get; set; }
        public User(string name, string email, string password, string bio)
        {
            this.name = name;
            this.email = email;
            this.password = password;
            this.bio = bio;
        }
        public User() { }
        public User(string name, string email, string password, string gender, DateTime dob, string bio, string one, string two, string three)
        {
            this.name = name;
            this.email = email;
            this.password = password;
            this.gender = gender;
            this.dob = dob;
            this.bio = bio;
            this.one = one;
            this.two = two;
            this.three = three;
        }
    }
}