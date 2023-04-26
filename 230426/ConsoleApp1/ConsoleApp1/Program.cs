
//try
//{

//Console.WriteLine(Func(2,5,3,8,6,4));
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//double Power(double a, uint n)
//{
//    if (n == 0)
//    {
//        return 1;
//    }
//    if (n == 1)
//    {
//        return a;
//    }
//    else
//    {
//        return a * Power(a, n - 1);
//    }
//}


//double Sum(int n)
//{
//    if (n < 10) return n; else return n % 10 + Sum(n / 10);
//}


//int Count(int n)           //Подсчет колличества цифр
//{
//    if (n < 10) return 1;
//    else return 1 + Count(n / 10);
//}

//int Func(int a, int b, int c, int d, int e, int f)
//{
//    return (a*Fact(b)+c*Fact(b)) / (Fact(e)+Fact(f));
//    int Fact(int n)
//    {
//        if (n == 0 || n == 1) return 1;
//        else return n * Fact(n - 1);
//    }
//}



//try
//{
//    Console.Write("Введите номер дня недели:"); int n = int.Parse(Console.ReadLine());
//    Console.WriteLine(DayWeek(n)); Console.WriteLine(DayWeekNew(n));
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//string DayWeek(int n)
//{
//    string result;
//    switch (n)
//    {
//        case 1: result = "Понедельник"; break;
//        case 2: result = "Вторник"; break;
//        case 3: result = "Среда"; break;
//        case 4: result = "Четверг"; break;
//        case 5: result = "Пятница"; break;
//        case 6: result = "Суббота"; break;
//        case 7: result = "Воскресенье"; break;
//        default: result = "Нет такого дня недели"; break;
//    }
//    return result;
//}
//string DayWeekNew(int n)
//{
//    string s;
//    return s = n switch
//    {
//        1 => "Понедельник",
//        2 => "Вторник",
//        3 => "Среда",
//        4 => "Четверг",
//        5 => "Пятница",
//        6 => "Суббота",
//        7 => "Воскресенье",
//        _ => "Нет такого дня недели"
//    };
//}
//People man = new People();
//man.name = "Виктор";
//man.surname = "Цой";
//Console.WriteLine(man.name + "" + man.surname);


//People superman = new People() { name = "Артур", surname = "Ходаев" };
//People[] peoples = new People[5];

//for (int i = 0; i < 5; i++)
//{
//    peoples[i] = new People();
//    Console.WriteLine($"Введите имя {i + 1} ученика");
//    peoples[i].name = Console.ReadLine();
//    Console.WriteLine($"Введите Фамилию {i + 1} ученика");
//    peoples[i].surname = Console.ReadLine();
//}
//foreach(People item in peoples)
//{
//    Console.WriteLine(item.name +""+item.surname);
//}



//struct People
//{
//    public string name;
//    public string surname;
//}

Console.WriteLine("********1******");



PhoneBookDicital[] bookphone=new PhoneBookDicital[3];
for(int i = 0; i < bookphone.Length; i++)
{
    Console.WriteLine("Введите фамилию:");
    bookphone[i].SurName = Console.ReadLine();
    Console.WriteLine("Введите адрес:");
    bookphone[i].Address = Console.ReadLine();
    Console.WriteLine("Введите телефон:");
    bookphone[i].phone = long.Parse(Console.ReadLine());

}
foreach(PhoneBookDicital item in bookphone)
{
    if (item.phone / 10000000 == 3) Console.WriteLine(item.SurName+""+item.Address+""+item.phone);
}


struct PhoneBookDicital
{
    public string SurName;
    public string Address;
    public long phone;
}
