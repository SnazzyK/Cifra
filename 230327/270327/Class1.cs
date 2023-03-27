
namespace _270327
{
    public static class Extansion

    {
        public static int Sun(int a ,int b)
        {
            return a + b; 

        }

    public static void PrintVar(string title ,string variable)
        {
            Console.WriteLine("-------string---------");
            Console.WriteLine($"{title}: "+variable);
            Console.WriteLine("----------------------");
        }
        public static void PrintVar(string title, int variable)
        {
            Console.WriteLine("-------integer---------");
            Console.WriteLine($"{title}: " + variable);
            Console.WriteLine("----------------------");
        }



    }
}
