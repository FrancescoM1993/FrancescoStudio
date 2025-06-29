string pathTest = @"test.txt";
File.Create(pathTest).Close();

string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
string path = $"test_{timestamp}.txt";
File.Create(path).Close();

File.WriteAllText(path, "test di scrittura su un file");

List<string> lines = new List<string> { "linea1", "linea2", "linea3"};
File.WriteAllLines(path, lines);

File.AppendAllText(path, "test di append\n");

File.AppendAllLines(path, lines);

string content = File.ReadAllText(path);
Console.WriteLine(content);

//string[] lines = File.ReadAllLines(path);

foreach (string line in lines)
{
    Console.WriteLine(line);
}