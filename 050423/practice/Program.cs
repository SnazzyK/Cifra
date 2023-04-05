string _operatorors = "+";
string line = Console.ReadLine();
line = line.Replace(_operatorors, " " + _operatorors + " ");

List<string> items = GetItems(line);

float value1 = 0;
float value2 = 0;
string oper = "";
bool _success = true;

value1 = TryParse(items[0], ref _success);
oper = items[1].Trim();
value2 = TryParse(items[2], ref _success);

if (_success==false)
{
    Console.WriteLine("Ошиибка");
}
else
{
    Console.WriteLine("Результат:"+Calculate());
}




Console.ReadKey();

float Calculate()
{
    if (oper == "+")
    {
        return value1 + value2;
    }
    return 0;
}

float TryParse(string line, ref bool success)
{
    float result = 0f;
    try
    {
    result = float.Parse(line);

    }
    catch
    {
        success = false;
    }
    if (success == false)
    {
        return result;
    }
    return result;
}

List<string> GetItems(string text)
{
    List<string> items = line.Split(' ').ToList();

    foreach (var item in items.ToList())
    {
        if (item == "")
        {
            items.Remove(item);
        }
       
    }
    return items;
}