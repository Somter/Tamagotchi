using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    class Care
    {
        public delegate void CareHandler(string message);
        private int mood { get; set; }
        private Character character;

        public Care()
        {
            mood = 100;
            character = new Character();
        }
        public void Print()
        {
            Console.Clear();
            character.ShowCharacter(mood);
        }

        public bool Choise(string choice)
        {
            if (choice.ToLower() == "n" || choice.ToLower() == "N")
            {
                mood = Math.Max(mood - 33, 0); 
            }
            else if (choice.ToLower() == "y" || choice.ToLower() == "Y")    
            { 
                mood = Math.Min(mood + 33, 100);
            }

            return mood > 0;
        }

        public void Feed() 
        {
            OnFeed?.Invoke("\nПокорми меня(Y/N)");  
        }
        public void Walk() 
        {
            OnWalk?.Invoke("\nПогуляй со мной(Y/N)");
        }
        public void Sleep()
        {
            OnSleep?.Invoke("\nУложи меня спать(Y/N)");
        }
        public void Heal()
        {
            OnHeal?.Invoke("\nПоличи меня(Y/N)");
        }
        public void Play()
        {
            OnHeal?.Invoke("\nПоиграй со мной(Y/N)");
        }

        public event CareHandler OnFeed;
        public event CareHandler OnWalk;
        public event CareHandler OnSleep;
        public event CareHandler OnHeal;
        public event CareHandler OnPlay;

    }
}
