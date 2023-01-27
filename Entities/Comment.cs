using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaStringB.Entities
{
    internal class Comment
    {
        public String Text { get; set; }
        public Comment()
        {

        }
        public Comment(string text)
        {
            Text= text; 
        }
    }
}
