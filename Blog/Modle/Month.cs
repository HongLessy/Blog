using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Model
{
    public class Month
    {
        public int year { get; set; }
        public int month { get; set; }
        public int number { get; set; }

        public Month() { }
        public Month(int y,int n) 
        {
            year = y;
            number = n;
        }
    }
}
