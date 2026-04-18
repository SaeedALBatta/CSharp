namespace C_Tasks_Methods_Section
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1 : Even Numbers Filter");
            EvenNumbersFilter();
            Console.WriteLine("____________________________");

            Console.WriteLine("Task 2: Remove Duplicates");
            RemoveDuplcate();
            Console.WriteLine("____________________________");
            RemoveDuplcate1();
            Console.WriteLine("____________________________");


            Console.WriteLine("Task 3: Find Maximum Number");
            MaximumNumber();
            Console.WriteLine("____________________________");


            Console.WriteLine(" Task 4: Reverse List");
            ReverseList();
            Console.WriteLine("____________________________");

            Console.WriteLine("Task 5: Count Numbers Greater Than X");
            CountNumGraterThan50();
            Console.WriteLine("____________________________");


        }

        static void EvenNumbersFilter()
        {
            List<int> Numbers = new List<int> { 22, 5, 7, 4, 10, 20, 33, 47 };
            List<int> EvenList = new List<int>();
            var evenNumbers = Numbers.Where(n => n % 2 == 0);
            foreach (var number in evenNumbers) 
            {
                EvenList.Add(number);
            }
            foreach (var number in EvenList)
            {
                Console.WriteLine(number);
            }
        }

        static void RemoveDuplcate()
        {
            List<int> Numbers = new List<int> { 22 , 5 , 7 , 4 , 10 , 20 , 22 , 33 , 47 , 7 , 4, 27 , 25 , 20 };
            List<int> Temp = new List<int>();

            var Sorting = Numbers.OrderBy(n => n);
            for (var i = 0; i < Numbers.Count; i++)
            {
                if (!Temp.Contains(Numbers[i]))
                {
                    Temp.Add(Numbers[i]);
                }
            }
            foreach(var number in Temp)
            {
                Console.WriteLine(number);
            }
               
        }

        static void RemoveDuplcate1()
        {
            List<int> Numbers = new List<int> { 22, 5, 7, 4, 10, 20, 22, 33, 47, 7, 4, 27, 25, 20 };
            var result = Numbers.Distinct();
            foreach (var number in result) 
            {
                Console.WriteLine(number);
            }
        }

        static void MaximumNumber() 
        {
            List<int> Numbers = new List<int> { 22, 5, 7, 4, 10, 20, 22, 33, 47, 7, 4, 27, 25, 20 };
            var maxnum = Numbers.Max();
            Console.WriteLine(maxnum);
        }

        static void ReverseList()
        {
            // This Will Revers Origan list
            List<int> Numbers = new List<int> { 22, 5, 7, 4, 10, 20, 22, 33, 47, 7, 4, 27, 25, 20 };
            Numbers.Reverse();
            foreach (var num in Numbers)
            {
                Console.WriteLine(num);
            }
        }

        static void ReverseList1()
        {
            // This Is new but Reverse
            List<int> Numbers = new List<int> { 22, 5, 7, 4, 10, 20, 22, 33, 47, 7, 4, 27, 25, 20 };
            var Result = Numbers.AsEnumerable().Reverse(); // Return type name is ienymerable
            var Result1 = Numbers.AsEnumerable().Reverse().ToList(); // Return type name is ienymerable Then Convert To List 

            foreach (var num in Result)
            {
                Console.WriteLine(num);
            }
        }

        static void CountNumGraterThan50()
        {
            List<int> Numbers = new List<int> { 22, 5, 7, 4, 10, 20, 22, 33, 47, 7, 4, 27, 25, 20 };
            var Result = Numbers.Count(n => n > 50);
            Console.WriteLine(Result);
        }
    }
}
