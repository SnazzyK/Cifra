namespace Bool_v2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
                string UserInPut = null;
                int value = 0;
                bool tryparse = true;
            CheckInteger();
            CheckPositive();
            
            //Проверка числа на вшивость
            
            while (tryparse)
            {
                UserInPut= Console.ReadLine();
                if(int.TryParse(UserInPut, out value))
                {
                    tryparse= false;
                }
                if(tryparse)
                {
                    Console.WriteLine("Неизвестное число");
                }
            }
                return;

            //Проверка числа на целостность
            void CheckInteger() 
            {
            if(value % 1 == 0)
            {
                Console.WriteLine("Целое число");
            }
            else
            {
                Console.WriteLine("Вещественное число");
            }
                
            }

            //Проверка на + или - числа .
            void CheckPositive()
            {

            if(value>=0)
            {
                Console.WriteLine("Положительное число");
            }
            if (value < 0)
            {
                Console.WriteLine("Отрицательное число");
            }
            }
        }
    }
}