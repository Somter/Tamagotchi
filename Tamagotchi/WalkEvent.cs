using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    public class WalkEvent
    {
        public void OnWalk(string messege)
        {
            Console.WriteLine(messege);
        }
    }
}
