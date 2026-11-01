using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppliApSport
{
    internal static class Program
    {
        
       
        static void Main()
        {
            List<Sportif> lesSportifs = SportifADO.GetAll();
            
        }
    }
}
