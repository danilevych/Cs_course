using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    internal class Builder : IDeveloper, IComparable<IDeveloper>
    {
        private string tool;
        public string Tool
        {
            get { return tool; }
            set { tool = value; }
        }
        public Builder(string tool)
        {
            this.tool = tool;
        }

        public void Create() { Console.WriteLine("Create something"); }
        public void Destroy() { Console.WriteLine("Destroy something"); }
    }
}
