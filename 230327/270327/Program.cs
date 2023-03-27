namespace _270327
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string test =  "TEST variable";
            int i = 123;
            Extansion.PrintVar("Значение s", test);
            Extansion.PrintVar("Значение i", i);



            try
            {

                //int sum = Exception.Sum(5.10);

            }
            catch(Exception exp)
            {
                Console.WriteLine("Error: "+exp.Message);

            }

            Console.ReadLine();






        }
    }
}