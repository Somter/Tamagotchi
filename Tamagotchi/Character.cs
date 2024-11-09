class Character
{
    public void ShowCharacter(int moodPercentage)
    {
        if (moodPercentage > 63)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Энергия: " + moodPercentage + "%");
            Console.WriteLine("  ^_^  ");
            Console.WriteLine(" / | \\ ");
            Console.WriteLine(" /   \\ ");
            Console.WriteLine("Он счастлив!");
            Console.ResetColor();
        }
        else if (moodPercentage > 0)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Энергия: " + moodPercentage + "%");
            Console.WriteLine("  T_T  ");
            Console.WriteLine(" / | \\ ");
            Console.WriteLine(" /   \\ ");
            Console.WriteLine("Он болен");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Энергия: " + moodPercentage + "%");
            Console.WriteLine("  x_x  ");
            Console.WriteLine(" / | \\ ");
            Console.WriteLine(" /   \\ ");
            Console.WriteLine("Он мертв");
            Console.ResetColor();   
        }
    }
}