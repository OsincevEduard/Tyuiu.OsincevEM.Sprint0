using Tyuiu.OsincevEM.Sprint0.Task6.V0.Lib;

namespace Tyuiu.OsincevEM.Sprint0.Task6.V0;

class Program
{
    static void Main(string[] args)
    {
        int[] arraynums = new int[] { 1, 2, 3, 4, 5 };

        // Пример циклической структуры находится в библиотеке классов в методе AdditionArray
        Console.WriteLine("Сумма элементов массива = " + DataService.AdditionArray(arraynums));

        // Пример циклической структуры находится в библиотеке классов в методе SubtractionArray
        Console.WriteLine("Разность элементов массива = " + DataService.SubtractionArray(arraynums));

        // Пример циклической структуры находится в библиотеке классов в методе MultiplicationArray
        Console.WriteLine("Произведение элементов массива = " + DataService.MultiplicationArray(arraynums));

        Console.ReadKey();
    }
}