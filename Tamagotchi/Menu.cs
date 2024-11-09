using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;  

namespace Tamagotchi
{
    class Menu
    {
        private Care care;
        private List<Action> actions;
        private Random random;
        private Action lastAction;
        private System.Timers.Timer gameTimer;
        private double timeLeft; 

        public Menu()
        {
            care = new Care();
            random = new Random();
            actions = new List<Action> { care.Feed, care.Walk, care.Sleep, care.Heal, care.Play };
            lastAction = null;

            care.OnFeed += (message) => Console.WriteLine(message);
            care.OnWalk += (message) => Console.WriteLine(message);
            care.OnSleep += (message) => Console.WriteLine(message);
            care.OnHeal += (message) => Console.WriteLine(message);
            care.OnPlay += (message) => Console.WriteLine(message);
        }

        public void ShowMenu()
        {
            bool alive = true;
            timeLeft = 60; 
            gameTimer = new System.Timers.Timer(1000);
            gameTimer.Elapsed += TimerElapsed;
            gameTimer.Start();

            do
            {
                care.Print();
                Action nextAction;
                do
                {
                    nextAction = actions[random.Next(actions.Count)];
                } while (nextAction == lastAction);

                nextAction.Invoke();
                lastAction = nextAction;

                string choice = Console.ReadLine();
                alive = care.Choise(choice);

            } while (alive);

            gameTimer.Stop();
            care.Print();
            Console.WriteLine("Игра завершена");
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            timeLeft--;
            if (timeLeft == 50 || timeLeft == 30 || timeLeft == 10)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"До конца игры осталось {timeLeft} секунд.");
                Console.ResetColor();
            }
        }
    }
}
