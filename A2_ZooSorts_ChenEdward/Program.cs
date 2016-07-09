using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace A2_ZooSorts_ChenEdward
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Test Cases

            //Lions
            Lion aLion = new Lion("Leo", DateTime.Parse("4/04/2012"),
            2500, 360, 1, 9);
            Lion aSecondLion = new Lion("Mustafa", DateTime.Parse("7/02/2010"), 
            2700, 400, 5, 9);
            Lion aThirdLion = new Lion("Simba", DateTime.Parse("3/02/2014"), 
            3100, 250, 6, 12);
            Lion aFourthLion = new Lion("Nala", DateTime.Parse("3/03/2014"), 
            3101, 200, 7, 14);
            Lion aFifthLion = new Lion("Mustafa2", DateTime.Parse("7/02/2010"),
            2700, 400, 5, 9);
            Lion aSixthLion = new Lion("Nala", DateTime.Parse("3/03/2014"),
            3101, 200, 8, 14);
            Lion aSeventhLion = new Lion("OldNala", DateTime.Parse("3/03/2013"),
            3101, 200, 8, 14);

            //Giraffes
            Giraffe aGiraffe = new Giraffe("Amber", DateTime.Parse("3/23/2012"),
            4500, 1400, 2, 25);
            Giraffe aSecondGiraffe = new Giraffe("Charlie", DateTime.Parse("5/2/2006"),
            3645, 2600, 3, 25);
            Giraffe thirdGiraffe = new Giraffe("Shirley", DateTime.Parse("3/23/2013"),
            4565, 1400, 0, 25);
            Giraffe fourthGiraffe = new Giraffe("George", DateTime.Parse("5/2/2009"),
            50, 2600, 0, 25);
            Giraffe fifthGiraffe = new Giraffe("Tess", DateTime.Parse("1/23/2015"),
            1234, 1400, 0, 25);
            Giraffe sixthGiraffe = new Giraffe("Carol", DateTime.Parse("5/2/2010"),
            1111, 2600, 0, 25);
            Giraffe seventhGiraffe = new Giraffe("Shannon", DateTime.Parse("5/2/2010"),
            1111, 2600, 0, 45);
            #endregion

            List<IZoo> aZoo = new List<IZoo>();
            aZoo.Add(aLion);
            aZoo.Add(aSecondLion);
            aZoo.Add(aThirdLion);           
            aZoo.Add(aGiraffe);
            aZoo.Add(aSecondGiraffe);
            aZoo.Add(thirdGiraffe);
            aZoo.Add(aFourthLion);
            aZoo.Add(aFifthLion);
            aZoo.Add(aSixthLion);
            aZoo.Add(fourthGiraffe);
            aZoo.Add(seventhGiraffe);
            aZoo.Add(fifthGiraffe);
            aZoo.Add(sixthGiraffe);

            

            List<Animal> animalList = new List<Animal>();
            animalList.Add(aLion);
            animalList.Add(aSecondLion);
            animalList.Add(aThirdLion);
            animalList.Add(aFourthLion);            
            animalList.Add(aSecondGiraffe);
            animalList.Add(thirdGiraffe);
            animalList.Add(aFifthLion);
            animalList.Add(aSixthLion);
            animalList.Add(aSeventhLion);
            animalList.Add(aGiraffe);
            animalList.Add(fourthGiraffe);
            animalList.Add(fifthGiraffe);
            animalList.Add(sixthGiraffe);

            ///* WORKS */
            //Sorting based on Purchase Cost
            aZoo.Sort();

            Console.WriteLine("Sorting based on Purchase Cost:\n");
            Console.WriteLine(PrintReportHeader());
            foreach (IZoo animalData in aZoo)
            {
                Console.WriteLine($"{animalData}");
            }


            /* TESTING DELEGATE SORTING */
            // Testing out delegate sort by sorting via ID
            //aZoo.Sort(
            //    delegate (IZoo a1, IZoo a2)
            //    {
            //        int ID_Difference = a1.ID.CompareTo(a2.ID);
            //        if (ID_Difference != 0)
            //            return a1.ID.CompareTo(a2.ID);
            //        else
            //            return a1.Name.CompareTo(a2.Name);
            //    }

            //);
            //Console.WriteLine("Sorting based on ID and then Name:\n");
            //Console.WriteLine(PrintReportHeader());
            //foreach (IZoo animalData in aZoo)
            //{
            //    Console.WriteLine($"{animalData}");
            //}


            /* WORKS */
            // Sorting based on animal's weight and date of birth            
            animalList.Sort(
                delegate (Animal a1, Animal a2)
                {

                    int weight_Diff = a1.Weight.CompareTo(a2.Weight);
                    if (weight_Diff != 0)
                        return a1.Weight.CompareTo(a2.Weight);
                    else
                        return a1.GetAge().CompareTo(a2.GetAge());
                }
            );
            Console.WriteLine("\nSorting based on Weight and Age:\n");
            Console.WriteLine(PrintReportHeader());
            foreach (IZoo animalData in animalList)
            {
                Console.WriteLine($"{animalData}");
            }

            /* WORKS */
            // Sorting based on cage number, purchase cost, animal name, ID
            aZoo.Sort(
                delegate (IZoo a1, IZoo a2)
                {
                    int cage_Diff = a1.CageNumber.CompareTo(a2.CageNumber);
                    if (cage_Diff != 0)
                        return a1.CageNumber.CompareTo(a2.CageNumber);
                    else
                    {
                        if (a1.PurchaseCost.CompareTo(a2.PurchaseCost) != 0)
                            return a1.PurchaseCost.CompareTo(a2.PurchaseCost);
                        else
                        {
                            if (a1.Name.CompareTo(a2.Name) != 0)
                                return a1.Name.CompareTo(a2.Name);
                            else
                                return (a1.ID.CompareTo(a2.ID));
                        }
                    }
                }
            );
            Console.WriteLine("\nSorting based on Cage number, Purchase Cost, Animal Name and ID:\n");
            Console.WriteLine(PrintReportHeader());
            foreach (IZoo animalData in aZoo)
            {
                Console.WriteLine($"{animalData}");
            }

            /*WORKS*/
            // Sorting based on animal's age, then weight
            animalList.Sort(
                delegate (Animal a1, Animal a2)
                {

                    int Age_Diff = a1.GetAge().CompareTo(a2.GetAge());
                    if (Age_Diff != 0)
                        return a1.GetAge().CompareTo(a2.GetAge());
                    else
                        return a1.Weight.CompareTo(a2.Weight);
                }
            );
            Console.WriteLine("\nSorting based on Age and Weight:\n");
            Console.WriteLine(PrintReportHeader());
            foreach (IZoo animalData in animalList)
            {
                Console.WriteLine($"{animalData}");
            }


            // Sorting based on animal type, purchase cost, cage number and name
            aZoo.Sort(
                delegate (IZoo a1, IZoo a2)
                {

                    if (a1.animalType.CompareTo(a2.animalType) != 0)
                        return a1.animalType.CompareTo(a2.animalType);
                    else
                    {
                        int purchase = a1.PurchaseCost.CompareTo(a2.PurchaseCost);
                        if (purchase != 0)
                            return a1.PurchaseCost.CompareTo(a2.PurchaseCost);
                        else
                        {
                            if (a1.CageNumber.CompareTo(a2.CageNumber) != 0)
                                return a1.CageNumber.CompareTo(a2.CageNumber);
                            else
                            {
                                if (a1.Name.CompareTo(a2.Name) != 0)
                                    return a1.Name.CompareTo(a2.Name);
                                else
                                    return (a1.ID.CompareTo(a2.ID));
                            }
                        }
                    }
                }
            );

            Console.WriteLine("\nSorting based on Animal Type, Purchase Cost, Cage and Name:\n");
            Console.WriteLine(PrintReportHeader());
            foreach (IZoo animalData in aZoo)
            {
                Console.WriteLine($"{animalData}");
            }

            // Sorting based on Purchase Cost, cage number, animal type, weight, age, name and ID
            aZoo.Sort(
                delegate (IZoo a1, IZoo a2)
                {

                    if (a1.animalType.CompareTo(a2.animalType) != 0)
                        return a1.animalType.CompareTo(a2.animalType);
                    else
                    {
                        int purchase = a1.PurchaseCost.CompareTo(a2.PurchaseCost);
                        if (purchase != 0)
                            return a1.PurchaseCost.CompareTo(a2.PurchaseCost);
                        else
                        {
                            if (a1.CageNumber.CompareTo(a2.CageNumber) != 0)
                                return a1.CageNumber.CompareTo(a2.CageNumber);
                            else
                            {
                                if (a1.Name.CompareTo(a2.Name) != 0)
                                    return a1.Name.CompareTo(a2.Name);
                                else
                                    return (a1.ID.CompareTo(a2.ID));
                            }
                        }
                    }
                }
            );

            Console.WriteLine("\nSorting based on Purchase Cost, Cage, Type, Weight, Age, Name and ID:\n");
            Console.WriteLine(PrintReportHeader());
            foreach (IZoo animalData in aZoo)
            {
                Console.WriteLine($"{animalData}");
            }


            Console.WriteLine("\nPress <ENTER> to quit...");
            Console.ReadKey();
        }


        public static string PrintReportHeader()
        {
            return $"{"ID",-7} {"Animal Type",-15} {"Name",-15} {"Weight",-8}" +
            $"{"Age",-5} {"Purchase Cost",-16} {"Cage No.",-10}\n" +
            $"{"==",-7} {"===========",-15} {"====",-15} {"======",-8}" +
            $"{"===",-5} {"=============",-16} {"========",-10}";
        }
    }
}
    

