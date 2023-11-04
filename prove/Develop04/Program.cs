using System;

class Program
{
    static void Main(string[] args)
    {
        int input;

        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Start breathing activity");
        Console.WriteLine("  2. Start reflecting activity");
        Console.WriteLine("  3. Start listing activity");
        Console.WriteLine("  4. Quit");
        Console.Write("Select a choice from the menu: ");
        input = int.Parse(Console.ReadLine());

        while (input != 4)
        {
            if (input == 1)
            {
                BreathingActivity breath = new BreathingActivity();
                Console.Clear();
                breath.Breathe();
            }
            else if (input == 2)
            {
                ReflectingActivity reflect = new ReflectingActivity();
                Console.Clear();
                reflect.Reflect();
            }
            else if (input == 3)
            {
                ListingActivity list = new ListingActivity();
                Console.Clear();
                list.Listing();
            }
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            input = int.Parse(Console.ReadLine());
        }
        Console.Clear();
    }
}