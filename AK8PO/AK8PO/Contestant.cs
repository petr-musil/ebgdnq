using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK8PO
{
    public enum ArtLevel
    {
        Kyu10,
        Kyu9,
        Kyu8,
        Kyu7,
        Kyu6,
        Kyu5,
        Kyu4,
        Kyu3,
        Kyu2,
        Kyu1,
        Dan1,
        Dan2,
        Dan3,
        Dan4,
        Dan5,
        Dan6,
        Dan7,
        Dan8,
        Dan9,
        Dan10
    }

    public class Contestant
    {
        private string name = "";
        private string surname = "";
        private string email = "";
        private short age = 0;
        private ArtLevel level = 0;

        public string Name
        { get { return name; } set { name = value; } }

        public string Surname
        { get { return surname; } set { surname = value; } }    

        public string Email
        { get { return email; } set { email = value; } }

        public short Age
        { get { return age; } set { age = value; } }

        public ArtLevel Level
        { get { return level; } set { level = value; } }

        public Contestant(string name, string surname, string email, short age, ArtLevel level)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Age = age;
            Level = level;
        }
        public static string getArtLevelCorrectName(ArtLevel artLevel) =>
        artLevel switch
        {
            ArtLevel.Kyu10 => "10 Kyu",
            ArtLevel.Kyu9 => "9 Kyu",
            ArtLevel.Kyu8 => "8 Kyu",
            ArtLevel.Kyu7 => "7 Kyu",
            ArtLevel.Kyu6 => "6 Kyu",
            ArtLevel.Kyu5 => "5 Kyu",
            ArtLevel.Kyu4 => "4 Kyu",
            ArtLevel.Kyu3 => "3 Kyu",
            ArtLevel.Kyu2 => "2 Kyu",
            ArtLevel.Kyu1 => "1 Kyu",
            ArtLevel.Dan1 => "1 Dan",
            ArtLevel.Dan2 => "2 Dan",
            ArtLevel.Dan3 => "3 Dan",
            ArtLevel.Dan4 => "4 Dan",
            ArtLevel.Dan5 => "5 Dan",
            ArtLevel.Dan6 => "6 Dan",
            ArtLevel.Dan7 => "7 Dan",
            ArtLevel.Dan8 => "8 Dan",
            ArtLevel.Dan9 => "9 Dan",
            ArtLevel.Dan10 => "10 Dan",
            _ => ""
        };
        
        override public string ToString()
        {
            return this.Name + " " + this.Surname + " (" + getArtLevelCorrectName(this.level) + ")";
        }
    }
}
