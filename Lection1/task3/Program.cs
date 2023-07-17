namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first and then second strings.");
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();
            string result;

            if (firstString.Length > secondString.Length)
            {
                result = firstString + " " + secondString;
            }
            else if (firstString.Length == secondString.Length)
            {
                result = "None";
            }
            else
            {
                char splitter = firstString.First();
                if (secondString.Contains(splitter))
                {
                    result = secondString.Substring(0, secondString.IndexOf(splitter));
                }
                else
                {
                    result = "Longest string does not have first symbol from shortest string.";
                }
            }

            Console.WriteLine("Your result is: {0}", result);

        }
    }
}