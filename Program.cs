namespace FindMaxNumGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find max number");
            float output = UC2_FindMaxOfThreeFloats.MaximumFloatNumber(111.2F, 22.45F, 78.56F);
            Console.WriteLine(output);
        }
    }
}