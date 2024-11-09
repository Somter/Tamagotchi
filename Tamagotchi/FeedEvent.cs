using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    public class FeedEvent
    {
        public void OnFeed(string messege) 
        {
            Console.WriteLine(messege);       
        }
    }
}
