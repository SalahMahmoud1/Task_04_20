namespace ExceptionHandlling2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arr1 = new int[] { 1, 10, 100, 50 };
                Console.WriteLine(arr1[4]);
                Console.WriteLine("insert First Number");
                int Num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("insert Second Number");
                int Num2  = Convert.ToInt32(Console.ReadLine());
                int result = Num1 / Num2;
            }
            catch (IndexOutOfRangeException e1)
            {
                Console.WriteLine(e1.Message);
            }
            catch (DivideByZeroException e2)
            {
                Console.WriteLine(e2.Message);
            }
            finally
            {
                Console.WriteLine("finally done");
            }
        }
    }
}
