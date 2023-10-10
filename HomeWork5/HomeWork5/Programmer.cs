using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    internal class Programmer : IDeveloper
    {
        string language;

        public string Tool
        {
            get { return language; }
            set { language = value; }
        }
        public Programmer(string language)
        {
            this.language = language;
        }
        public void Create() { Console.WriteLine("Create some project"); }
        public void Destroy() { Console.WriteLine("Destroy some project"); }
    }
}