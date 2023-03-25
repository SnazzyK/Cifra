//namespace BoolWork
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string _UserInPut;
//            int _UserValue = 0;
//            Console.WriteLine("Введите число: ");
//            CheckValue();

//            int CheckValue(string message)
//            {
//                int result = 0;
//                bool tryparse = true;
//                while (tryparse)
//                {
//                    Console.Write(message);
//                    _UserInPut = (Console.ReadLine());
//                    if(int.TryParse(_UserInPut, out result))
//                    {
//                        tryparse= false;

//                    }
//                    if (tryparse)
//                    {
//                        Console.WriteLine("Неизвестное число");
//                        Console.ReadKey();
//                    }
//                    return result;
//                }


//            }
//            void CheckIntager()
//            {
//                if(_UserValue % 1 == 0)
//                {
//                    Console.WriteLine("Целое число");

//               }
//                else
//                {
//                    Console.WriteLine("Вещественное");
//                }
//            }

//            void CheckPositive()
//            {
//                if (_UserInPut > 0)
//                {
//                    Console.WriteLine("Положительное число");
//                }
//                if (_UserInPut < 0)
//                {
//                    Console.WriteLine("Отрицательное число ");


//                }

//            }
//        }

//    }
}