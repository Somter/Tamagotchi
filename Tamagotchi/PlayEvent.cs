using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    public class PlayEvent
    {
        public void OnPlay(string messege)
        {
            Console.WriteLine(messege);
        }
    }
}
