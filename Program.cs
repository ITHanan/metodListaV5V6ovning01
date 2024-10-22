using System.Collections.Generic;

namespace metodListaV5V6ovning01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listNumbers = new List<int>() { 1, 2, 3, 3, 3, 4, 4, 5, 6, 7 };
            List<string> names = new List<string>() {"Henrik","Jonsson","Sara","Bob" };




            List<int> reversNumber = ReversList(new List<int>(listNumbers));
            Console.WriteLine("Reversed List:");

            foreach (int number in reversNumber)
            {

                Console.WriteLine(number);

            }

            Console.WriteLine("\n");


            List<int> RemovseDuplicatesNumbers = RemovesDuplicates(listNumbers);
            Console.WriteLine("List with dublicates:");

            foreach (int number in RemovseDuplicatesNumbers)
            {

                Console.WriteLine(number);

            }

            Console.WriteLine("\n");

            List<string> SortedList = SortListByLength(names);
            Console.WriteLine("Sorted by List:");

            foreach (string name in SortedList) 
            {
             
                Console.WriteLine(name);
            
            }

            Console.WriteLine("\n");
            List<int> RemoveEvenNumber = RemoveAllEvenNumber(new List<int>(listNumbers));
            Console.WriteLine("Reversed even number:");

            foreach (int number in RemoveEvenNumber)
            {

                Console.WriteLine(number);

            }

        }


        static List<int> ReversList(List<int> listNumbers)
        {
            listNumbers.Reverse();
            return listNumbers;
        }

        static List<int> RemovesDuplicates(List<int> listNumbers) 
        {
          var unikaTal =   listNumbers.Distinct();
           return unikaTal.ToList();
        }

        static List<string> SortListByLength(List<string> names) 
        {
            names.Sort();
            return names;
        }

        static List<int> RemoveAllEvenNumber(List<int> listNumbers) 
        {
        
         listNumbers.RemoveAll(number => number % 2 ==0);
         return listNumbers;
        
        }



    }
}
