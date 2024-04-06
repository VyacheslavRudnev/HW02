using System.Diagnostics;
using System.Text;


Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

while (true)
{
    Console.WriteLine("\nМеню:");
    Console.WriteLine("1. Запустити Калькулятор");
    Console.WriteLine("2. Запустити Paint");
    Console.WriteLine("3. Запустити Блокнот");
    Console.WriteLine("0. Вийти з програми");

    Console.Write("Оберіть потрібну програму: ");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            StartProcess("calc.exe");
            break;
        case "2":
            StartProcess("mspaint.exe");
            break;
        case "3":
            StartProcess("notepad.exe");
            break;
        case "0":
            Console.WriteLine("Дякую за використання програми!");
            return; 
        default:
            Console.WriteLine("Здається ви промахнулись. Спробуйте ще раз.");
            break;
    }
}
static void StartProcess(string processName)
{
    try
    {
        Process.Start(processName);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Помилка при запуску процесу: {ex.Message}");
    }
}