using System;

namespace ConsoleApp125
{
    class Human
    {
        protected int age;
        public Human(int manAge)
        {
            age = manAge;
        }
        public void showAge()
        {
            Console.WriteLine("Возраст - " + age);
        }
    }
    class Man : Human
    {
        private string name;
        public Man(int manAge, string manName) : base(manAge)
        {
            name = manName;
        }
        public void getInfo()
        {
            base.showAge();
            Console.WriteLine("Имя - " + name);
        }
    }
}
