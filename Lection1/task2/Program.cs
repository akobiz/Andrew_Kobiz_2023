namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            Console.WriteLine("Enter 10 numbers: ");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter {0} number: ", i + 1);
                numbers.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine("Enter number to dublicate it: ");
            int numberToDublicate = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numberToDublicate == numbers[i])
                {
                    numbers.Insert(i, numberToDublicate);
                    i += 1;
                }
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write($"{numbers[i]}, ");
            }
        }
    }
}