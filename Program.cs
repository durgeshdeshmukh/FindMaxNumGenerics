namespace FindMaxNumGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find max number using Generics");
            int output = UC1_FindMaxOfThreeIntegers.MaximumIntegerNumber(11, 22, 33);
            Console.WriteLine(output);
        }
    }
}