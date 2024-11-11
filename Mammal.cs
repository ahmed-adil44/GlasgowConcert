using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClydeConservtion
{
    internal class Mammal : Animal // derived class from base Animal 
    {
        private string _MateName;
        private char _GivenBirth;


        public override void SetAnimalDetails(int NumAnimal) //setter method
        {
            bool choice = true;
            bool choice2 =true;
            bool choice3 = true;
            Console.WriteLine($"Animal name:");
            _AnimalName = Console.ReadLine();
            Console.WriteLine($"Animal type:");
            _AnimalType = Console.ReadLine();



            while(choice) // loop keep asking the correct input
            {
                try // error handling
                {
                    Console.WriteLine($"Dengar rate (1-5):");
                    _DangerRate = int.Parse(Console.ReadLine());
                    if (_DangerRate <= 0 || _DangerRate > 5) // if input out of range then display message
                    {

                        Console.WriteLine("Invalid input, re-enter (1-5)");
                    }
                    else
                    {
                        choice = false; // if input between 1 - 5 exit the loop
                    }

                }
                catch (Exception)
                { Console.WriteLine("Error : invalid Input"); }
            }
                
            
            
            
            
                
            while (choice2)
            {

                try // error handiling
                {
                    Console.WriteLine($"Sex (M - F):");
                    _Sex = char.Parse(Console.ReadLine().ToLower());

                    if(_Sex == 'f' || _Sex =='m')
                    {
                        choice2 = false;
                        
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, re-enter M - F");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }

            
           
            Console.WriteLine($"Mate name:");
            _MateName = Console.ReadLine();
            if(_Sex == 'f' || _Sex =='F') // ask if the animal given birth in case of Female
            {
                while(choice3)
                {
                    try
                    {
                        Console.WriteLine($"Animal Given birthe (Y/N):");
                        _GivenBirth = char.Parse(Console.ReadLine().ToLower());
                        
                        if(_GivenBirth == 'y' || _GivenBirth == 'n' )
                        {
                            choice3 = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input, please re-enter Y/N");
                        }
                    }catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }

                }
                
            }
            
        }

        public string GetMateName()
        {
            return _MateName;
        }
        public char GetGivingBirth()
        {
            return _GivenBirth;
        }

        public override void PrintAnimalDetail() // override the same print function in the base class with adjesment
        {
            Console.WriteLine("Animal details");
            Console.WriteLine("******************");
            Console.WriteLine($"Animal ID: {GetID()}");
            Console.WriteLine($"Animal name: {GetAnimalName()}");
            Console.WriteLine($"Animal type: {GetAnimalType()}");
            Console.WriteLine($"Animal danger rate: {GetDangerRate()}");
            Console.WriteLine($"Animal sex: {GetSex()}");
            Console.WriteLine($"Mate Name: {GetMateName()}");
            if (_Sex == 'f') // if the mammal female will display this message
            {
                Console.WriteLine($"Given birth: {GetGivingBirth()}");
            }
            
            Console.WriteLine($"Insurance cost: {CalculateInsurance(GetDangerRate())}") ;
        }
        public override double CalculateInsurance(int DangerRate) // overrid method to calculate insurance
        {
            double InsuranceCost = 0;
            double Base = 5000;
            
                    switch (DangerRate)
                    {
                        case 1:
                            InsuranceCost = (Base * 10) * 0.02;
                            break;
                        case 2:
                            InsuranceCost = (Base * 20) * 0.05;
                            break;
                        case 3:
                            InsuranceCost = (Base * 30) * 0.05;
                            break;
                        case 4:
                            InsuranceCost = (Base * 40) * 0.05;
                            break;
                        case 5:
                            InsuranceCost = (Base * 50) * 0.10;
                            break;
                        default:
                            Console.WriteLine("Invalid input.");
                            break;
                    }
                
            
            
            return InsuranceCost;


        }

    }
}
