string _directory = "";
string _fileName = "Data.txt";
string _fullPath = "";
string _data = "";
List<string> _data2 = new List<string>();

while (true)
{
    PrintData2();
    string line = Console.ReadLine();

    if (line == "exit")
    {
        break;
    }
    if(line == "remove")
    {
        Console.WriteLine("Какую строку удаляем?(номер от нуля): ");
        int lineNumber = int.Parse(Console.ReadLine());
        _data2.RemoveAt(lineNumber);
        continue;
    }
    AppendData(line);
    Console.Clear();
}
Console.Read();

void AppendData(string data)
{
    _data2.Add(Environment.NewLine + data);
}

List<string> ReadFile()
{
    _directory = Directory.GetCurrentDirectory();//Путь до exe файла
    _directory = new DirectoryInfo(_directory).Parent.Parent.Parent.FullName;//Перейти по каталогу 
    _fullPath = Path.Combine(_directory, _fileName);//Комбинировать путь +папка или +файл
    return _data2 = File.ReadAllLines(_fullPath).ToList();//Чтение файла и запись в string переменную 


    void PrintData2()
    {
        Console.WriteLine("Data: \n" + Environment.NewLine + _data);
        Console.WriteLine("----------------------------------");
    }

    void WriteDataToFile()
    {
        File.WriteAllLines(_fullPath, _data2);//Запись string - данных в файл по пути _FullPath
        Console.WriteLine("Файл сохранен");
    }
}