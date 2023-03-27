string _directory = "";
string _fileName = "Data.txt";
string _fullPath = "";
string _data = "";
_data = ReadFile();

while (true)
{
    PrintData();
    string line = Console.ReadLine();

    if (line == "exit")
    {
        break;
    }
    Console.Clear();
    AppendData(line);
}
Console.Read();

void AppendData(string data)
{
    _data += Environment.NewLine + data;
}

string ReadFile()
{
    _directory = Directory.GetCurrentDirectory();//Путь до exe файла
    _directory = new DirectoryInfo(_directory).Parent.Parent.Parent.FullName;//Перейти по каталогу 
    _fullPath = Path.Combine(_directory, _fileName);//Комбинировать путь +папка или +файл
    return _data = File.ReadAllText(_fullPath);//Чтение файла и запись в string переменную 
}

void PrintData()
{
    Console.WriteLine("Data: \n" + Environment.NewLine + _data);
    Console.WriteLine("----------------------------------");
}

void WriteDataToFile()
{
    File.WriteAllText(_fullPath, _data);//Запись string - данных в файл по пути _FullPath
}