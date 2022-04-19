using System;

namespace calsswrok5// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Введите имя");
            
            string Name =Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            string SecondName =Console.ReadLine();
            Console.WriteLine("Введите день вашего рождения");
            int.TryParse(Console.ReadLine(), out int i);
            
            Console.WriteLine("Введите месяц вашего рождения");
            int.TryParse(Console.ReadLine(), out int y);
            
            Console.WriteLine("Введите год вашего рождения");
            int.TryParse(Console.ReadLine(), out int z);
           
            Human human = new Human(Name, SecondName, i, y, z);
            human.AllInfo();
        }
    }
}