using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    class Program
    {
        static void Main() 
        {
            try
            {
                Menu menu = new Menu();
                menu.ShowMenu();
            }
            catch(Exception ex) 
            { 
                Console.WriteLine(ex.ToString()); 
            }
          
        }

    }
}
