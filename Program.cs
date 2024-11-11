using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClydeConservtion
{
    internal class Program
    {
        public static void Menu() // main menu
        {
            Console.WriteLine("Please chose one of the options:");
            Console.WriteLine("***********************************");
            Console.WriteLine("1) Mammals.");
            Console.WriteLine("2) Reptiles.");
            Console.WriteLine("3) Exit.");

        }
        public static void MammalsMenuDisplay() // mammal menu
        {
            Console.WriteLine("Please chose one of the options:");
            Console.WriteLine("***********************************");
            Console.WriteLine("1) Add Mammal.");
            Console.WriteLine("2) Print Mammal.");
            Console.WriteLine("3) Exit.");
        }
        public static void ReptileMenuDisplay() // reptiels menu
        {
            Console.WriteLine("Please chose one of the options:");
            Console.WriteLine("***********************************");
            Console.WriteLine("1) Add Reptile.");
            Console.WriteLine("2) Print Reptile details.");
            Console.WriteLine("3) Exit.");
        }

        public static void SubMenu(Mammal m, Reptile r,int NumAnimal) // second menu
        {
            
            int option = 0;
            
            while (option != 3)
            {
                try // error handling to read input from user
                {
                    Console.Clear();
                    Console.WriteLine("Welcome to Clyde Conservation");
                    Console.WriteLine("******************************");
                    Console.WriteLine("");
                    Menu();
                    option = int.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            MammalMenu(m, NumAnimal);
                            break;
                        case 2:
                            ReptileMenu(r, NumAnimal);
                            break;
                        case 3:
                            break;
                        default:
                            Console.WriteLine("Invalid input.");
                            Console.ReadLine();
                            break;
                    }

                
                }catch (Exception ex)
                {
                    Console.WriteLine($"Error : {ex.Message}");
                    Console.ReadLine();
                }
                
            }
            
            
            

        }
        public static void MammalMenu(Mammal m, int NumAnimal) // mammal menu
        {
            
            int option = 0;

            while (option != 3)
            {
                try // error handling to read input from user
                {
                    Console.Clear();
                    MammalsMenuDisplay();
                    option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            m.SetAnimalDetails(NumAnimal);
                            break;
                        case 2:
                            m.PrintAnimalDetail();
                            Console.ReadLine();
                            break;
                        case 3:
                            break;
                        default:
                            Console.WriteLine("Invalid input");
                            Console.ReadLine();
                            break;

                    }
                }catch(Exception ex) { Console.WriteLine("Error : Invalid input"); Console.ReadLine(); };
                
            }
            

            
        }

        public static void ReptileMenu(Reptile r, int NumAnimal) // reptile menu
        {
            int option = 0;

            while (option != 3)
            {
                try // error handling to read input from data
                {
                    Console.Clear();
                    ReptileMenuDisplay();
                    option = int.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            r.SetAnimalDetails(NumAnimal);
                            break;
                        case 2:
                            r.PrintAnimalDetail();
                            Console.ReadLine();
                            break;

                        case 3:
                            break;
                        default:
                            Console.WriteLine("Invalid input");
                            Console.ReadLine();
                            break;



                    }
                }catch (Exception ex)
                {
                    Console.WriteLine("Error: Invalid input.");
                    Console.ReadLine();
                }
            }
            
        }
        

        


        static void Main(string[] args)
        {
            Mammal m = new Mammal(); // new object from mammal
            Reptile r = new Reptile();  // new object from reptils

            int NumAnimal = 1;
            
            
            SubMenu(m, r, NumAnimal);
            Console.ReadLine();
        }
    }
}
