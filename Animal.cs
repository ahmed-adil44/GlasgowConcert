using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClydeConservtion
{
    abstract internal class Animal // uninstantiated class.
    {
     
        private protected int _ID;
        private protected string _AnimalName;
        private protected string _AnimalType;
        private protected int _DangerRate;
        private protected char _Sex;

        public static int NumAnimal = 0; // this variable to count the number of animals.
        public Animal() // class constructor
        {
            
            _ID = NumAnimal++; // increment the number of animal.
        }

        public virtual void SetAnimalDetails(int NumAnimal) // setter method
        {
            Console.WriteLine($"Animal name:");
            _AnimalName = Console.ReadLine();
            Console.WriteLine($"Animal type:");
            _AnimalType = Console.ReadLine();
            Console.WriteLine($"Dengar rate (1-5):");
            _DangerRate = int.Parse(Console.ReadLine());
            Console.WriteLine($"Sex (M - F):");
            _Sex = char.Parse(Console.ReadLine().ToLower());

        }
        public int GetID()
        {
            _ID++;
            return _ID;
        }
        public string GetAnimalName()
        {
            return _AnimalName;
        }
        public string GetAnimalType()
        {
            return _AnimalType;
        }
        public int GetDangerRate()
        {
            return _DangerRate;
        }
        public char GetSex()
        {
            return _Sex;
        }

        public virtual void PrintAnimalDetail() // virtual method to use it in the derived classes.
        {
            Console.WriteLine("Animal details");
            Console.WriteLine("******************");
            Console.WriteLine($"Animal ID: {GetID()}");
            Console.WriteLine($"Animal name: {GetAnimalName()}");
            Console.WriteLine($"Animal type: {GetAnimalType()}");
            Console.WriteLine($"Animal danger rate: {GetDangerRate()}");
            Console.WriteLine($"Animal sex: {GetSex()}");
            


        }
        public abstract double CalculateInsurance(int DangerRate); // abstract method to inforce it in derived classes
        
         


    }
}
