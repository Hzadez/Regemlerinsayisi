namespace Example_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir regem girin: ");
            int regem = Convert.ToInt32(Console.ReadLine());
            int sayan = 0;
            do
            {
                regem /= 10;
                sayan++;

            } while (regem != 0);
            Console.WriteLine(sayan);
        }
    }
}
    