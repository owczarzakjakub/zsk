﻿namespace project_4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "imiĘ i NAzwisko";
            Console.WriteLine(message);

            string messageUpperCase = message.ToUpper();
            Console.WriteLine(messageUpperCase);

            string messageLowerCase = message.ToLower();
            Console.WriteLine(messageLowerCase);

            string name = message.Substring(1);
            Console.WriteLine(name); //miĘ i NAzwisko

            string name1 = message.Substring(0, 4);
            Console.WriteLine(name1); //imiĘ

            Console.WriteLine(name1[0]); //1


            Console.WriteLine(message.Substring(0,1).ToUpper() + message.Substring(1).ToLower()); //imiĘ i NAzwisko => Imię i nzawisko
            Console.WriteLine(message[0].ToString().ToUpper() + message.Substring(1).ToLower()); //imiĘ i NAzwisko => Imię i nzawisko, 2 metoda


        }
    }
}