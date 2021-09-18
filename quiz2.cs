using System;
using System.Collections.Generic;

namespace quizSat2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Total Rose: ");
            int numRose = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Input Total Sun Flower: ");
            int numSunflower = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= numRose; i++)
            {
                Console.WriteLine("Input Rose");
                Console.WriteLine("__________");
                Console.Write("ID: ");
                int ID = int.Parse(Console.ReadLine());
                Console.Write("Plant name: ");
                string name = Console.ReadLine();
                Console.Write("Plant description: ");
                string info = Console.ReadLine();
                Console.Write("Amount: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Height: ");
                string height = Console.ReadLine();
                Console.Write("Circumference: ");
                string Circum = Console.ReadLine();

                Rose newRose = new Rose(ID, name, info, number, height, Circum);

                newRose.addRose(newRose);
                Console.Clear();
            }

            for (int k = 1; k <= numSunflower; k++)
            {
                Console.WriteLine("Input Sun flower");
                Console.WriteLine("________________");
                Console.Write("ID: ");
                int ID = int.Parse(Console.ReadLine());
                Console.Write("Plant name: ");
                string name = Console.ReadLine();
                Console.Write("Plant description: ");
                string info = Console.ReadLine();
                Console.Write("Amount: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Height: ");
                string height = Console.ReadLine();
                Console.Write("Circumference: ");
                string Circum = Console.ReadLine();

                Sunflower newSunflower = new Sunflower(ID, name, info, number, height, Circum);

                newSunflower.addSunflower(newSunflower);
                Console.Clear();

            }
        }
    }
    class flower
    {
        public int ID;
        public string name;
        public string info;
        public int number;
        public string height;
        public string circumference;

        public flower (int id, string inputName, string inputInfo, int Number, string inputHeight, string Circum)
        {
            this.ID = id;
            this.name = inputName;
            this.info = inputInfo;
            this.number = Number;
            this.height = inputHeight;
            this.circumference = Circum;

        }

    }

    class Rose: flower
    {
        public List<Rose> listRose;

        public Rose(int id, string inputName, string inputInfo, int Number, string inputHeight, string Circum) : base(id, inputName, inputInfo, Number, inputHeight, Circum) 
        { 
            listRose = new List<Rose>();
        }

        public void addRose(Rose orderRose)
        {
            listRose.Add(orderRose);
        }

        public void printRose()
        {
            
        }

    }

    class Sunflower: flower
    {
        public List<Sunflower> listSunflower;

        public Sunflower(int id, string inputName, string inputInfo, int Number, string inputHeight, string Circum) : base(id, inputName, inputInfo, Number, inputHeight, Circum) 
        {
            listSunflower = new List<Sunflower>();
        }

        public void addSunflower(Sunflower orderSunflower)
        {
            listSunflower.Add(orderSunflower);
        }

        public void printSun()
        {

        }
    }
}
