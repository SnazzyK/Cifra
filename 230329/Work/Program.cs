using System.Data;

bool _needExit = false;

string _directory = "";
string _fileName = "Data.txt";
    
string _fullPath = "";
List<string> _data = new List<string>();

_data = ReadFile();

while (!_needExit)
{

    PrintData();
    string line = Console.ReadLine();
    
    
    if (CheckComands(line))
    {
        ExecuteCommand(line);
    }
    else
    {
        AppendData(line);
        WriteDataToFile();
    }


}

Console.ReadLine();
//Exit Programm

void ExecuteCommand(string command)
{
    string line = null;
    
    switch (command)
    {
        case "exit":
            _needExit = true;
            break;
        case "remove":
            RemoveLine() ;
            break;
        case "help":
            ShowHelp();
            break;
        case "clear":
            ClearConsole();
            break;
        case "Upper":
            UppercaseLine();
            break;
        case "SymbolSun":
            SymbolSun();
            break;
    }

    
}
void SymbolSun()
{
    int sum = 0;
    foreach (var line in _data)
    {
        sum += line.Length;
    }
}
void UppercaseLine()
{
    Console.WriteLine("\n Какую строку написать Капсом");
    int lineNumber = int.Parse(Console.ReadLine());
    try
    {
        _data[lineNumber] = _data[lineNumber].ToUpper();
    }
    catch
    {
        Console.WriteLine("Ошибка!\nПопробуйте еще раз:\n");
    }

}
void RemoveLine()
{
    Console.Write("\nКакую строку удаляем? (номер от нуля): \n");
    int lineNumber = int.Parse(Console.ReadLine());
    try
    {
        _data.RemoveAt(lineNumber);
    }
    catch
    {
        Console.WriteLine("Ошибка!\nПопробуйте еще раз:\n");
    }
}
 void ShowHelp()
    {
    Console.Clear();
    Console.WriteLine("Выберите команду:\n\"remove\" - удаление строки\n\"exit\" - выйти из программы\n\"clear\" - Очитить консоль\n\"SymbolSun\" - Очитить консоль\n\"Upper\" - Очитить консоль");
}

bool CheckComands(string line)

{
    line = line.Trim().ToLower();
    return line == "exit" || line == "?" || line == "help" || line == "remove" || line == "clear" || line == "SymbolSun" || line == "UppercaseLine";
}


void ClearConsole()
{
    Console.Clear();

}

void AppendData(string data)
{
    _data.Add(data);
}

List<string> ReadFile()
{
    _directory = Directory.GetCurrentDirectory(); //Путь до exe-файла
    _directory = new DirectoryInfo(_directory).Parent.Parent.Parent.FullName; //Перейти по каталогу на 3 уровня вверх и получить полный путь
    _fullPath = Path.Combine(_directory, _fileName); //Комбинировать путь +папка или +файл
    return File.ReadAllLines(_fullPath).ToList(); //Чтение файла и запись в string переменную
}

void PrintData()
{
    int i = 0;

    Console.WriteLine("DATA: ");
    foreach (string note in _data)
    {
        Console.WriteLine($"{i++}. " + note);
    }
    Console.WriteLine("--------------------");
}

void WriteDataToFile()
{
    File.WriteAllLines(_fullPath, _data); //Запись string-данных в файл по пути _fullPath
    Console.WriteLine("Файл сохранен");
}