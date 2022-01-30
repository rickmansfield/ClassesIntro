using System;

namespace ClassesIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Car myCar = new Car();
            Car anotherCar = new Car();

            myCar.Accelerate();
            myCar.Accelerate();
            myCar.Accelerate();
            myCar.Accelerate();
            myCar.Brake();
            myCar.Accelerate();

            anotherCar.Brake();
        }
    }
    class Car
    {
        private int speed = 0;
        public void Accelerate()
        {
            speed++;
            Console.WriteLine($"Your're going {speed} Mph ");
        }

        public void Brake()
        { 
            speed--;
            Console.WriteLine($"You're going {speed} Mph."); 
        }
    }
}
