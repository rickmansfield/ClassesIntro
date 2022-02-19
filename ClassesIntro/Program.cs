using System;

namespace ClassesIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Car myCar = new Car("Tim's car");
            Car anotherCar = new Car("The Batmobile");

            myCar.Accelerate(5);
            myCar.Accelerate(30);
            myCar.Brake(4);

            anotherCar.Brake(0);
        }
    }

    class Car
    {
        private int speed = 0;
        private string name;

        public Car(string carName)
        {
            name = carName;
        }

        public void Accelerate(int amount)
        {
            speed+=amount; //speed = spead + amount
            ShowSpeed();
        }

        public void Brake(int reduction)
        {
            speed = speed < reduction ? speed = 0 : speed -= reduction;

            ShowSpeed();
        }

        //public void Brake(int reduction)
        //{
        //    speed-=reduction;
        //    if (speed < 0) 
        //    {
        //        speed = 0;
        //    }
        //    ShowSpeed();
        //}

        private void ShowSpeed()
        {
            Console.WriteLine($"{name} is going {speed} miles per hour.");
        }
    }
}
