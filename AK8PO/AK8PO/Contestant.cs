using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK8PO
{
    internal class Contestant
    {
        private string name = "";
        private string surname = "";
        private string email = "";
        private short age = 0;
        private short level = 0;

        public string Name
        { get { return name; } set { name = value; } }

        public string Surname
        { get { return surname; } set { surname = value; } }    

        public string Email
        { get { return email; } set { email = value; } }

        public short Age
        { get { return age; } set { age = value; } }

        public short Level
        { get { return level; } set { level = value; } }

        public Contestant(string name, string surname, string email, short age, short level)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Age = age;
            Level = level;
        }
    }
}
