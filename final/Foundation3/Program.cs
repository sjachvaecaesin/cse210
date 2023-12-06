using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Ring Road", "Clarksville", "40121", "USA");
        Lecture lecture = new Lecture("Lecture", "On the topic of pies", "To discuss how we can make pies even better", "October 4th", "2:35 pm", address1, "Tyler Jerry", 40);
        Gathering gathering = new Gathering("Gathering", "Outdoor community picnic", "Just a friendly get-together", "June 18th", "3:15 pm", address1, "sunny");
        Reception reception = new Reception("Reception", "Community awards", "A prestigious event to give back to the community", "January 1st", "6:00 pm", address1, "billybobjoe@hotmail.com");

        Console.WriteLine("----------------------------------------------");
        lecture.Standard();
        Console.WriteLine();
        lecture.Full();
        Console.WriteLine();
        lecture.Short();
        Console.WriteLine();
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine();
        gathering.Standard();
        Console.WriteLine();
        gathering.Full();
        Console.WriteLine();
        gathering.Short();
        Console.WriteLine();
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine();
        reception.Standard();
        Console.WriteLine();
        reception.Full();
        Console.WriteLine();
        reception.Short();
        Console.WriteLine();
    }
}