using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace exercise12
{
  interface iLogger
    {
        List<string> LogPosts { get; set; }
        void Logg(string message);
        void PrintLoggs();
       
    }
}
