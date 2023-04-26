namespace HomeWork_0322
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Ведите число: ");
            int ParseValue = 0;
            int c = 0;
            int countWord = 1;
            //Проверка числа.
            while (true)
            {
                string value = Console.ReadLine();
                bool parse = (int.TryParse(value, out ParseValue));
                if (parse == true)
                {
                    parse = false;

                }
                else
                {
                    if ()
                    {

                        foreach (char x in value)
                            if (x == ' ') countWord++;
                        Console.WriteLine($"{value} - предложение.Количество слов={countWord}");
                    }
                    
                    
                    
                    else if (value == "")
                    {
                   
                        for (int i = 0; i < value.Length; i++)
                    {
                        if (char.IsLetter(value[i]))
                            c++;

                    }
                    Console.WriteLine($"{value} - слово.Длина слова={c}");

                    }
                    

                    
                    
                    

                }
            }

           

            if (ParseValue % 1 == 0)
            {
                Console.WriteLine($"{ParseValue} целое число");

            }
            else
            {
                Console.WriteLine("Вещественное число");

            }




            i

















        }









    }
}