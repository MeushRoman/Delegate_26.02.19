using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    //1.создание делегата
    public delegate void GetMessage();
    public delegate int Operation(int x, int y);

    public delegate void CarEngineHandler(string s);
    public class Car
    {
        public Car()
        {
            MaxSpeed = 100;  
        }

        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string Name { get; set; }
        public bool IsDead;
        private CarEngineHandler listOfHundlers;

        public void RegisterCarEngine(CarEngineHandler methodCall)
        {
            listOfHundlers = methodCall;
        }

        public void Accelerate(int delta)
        {

        }
    }
    class Program
    {
        //2.1 экземпляр делегата (класса)
        static GetMessage del;
       //2.1 static Operation op;
        static void Main(string[] args)
        {
            //2.3
            Operation op = new Operation(Add);
            
            int result = op.Invoke(4,5);
            //result = op(4, 5);

            del = GoodMorning;

            //Вызов делегата
            //del();
            del.Invoke();
            Console.ReadLine();
        }

        private static int Add(int x, int y)
        {
            return x + y;
        }
        private static void GoodMorning()
        {
            Console.WriteLine("GoodMorning");
        }
        private static void GoodEvening()
        {
            Console.WriteLine("GoodEvening");
        }
        
    }
}
