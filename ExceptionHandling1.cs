namespace Exc_Handlling
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            try
            {
                int[] arr1 = new int[] { 1, 10, 100, 50 };
                //Console.WriteLine(arr1[4]);
                //Console.WriteLine("insert First Number");
                int Num1 = 10;
                //Console.WriteLine("insert Second Number");
                int Num2 = 0;
                int result = Num1 / Num2;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
