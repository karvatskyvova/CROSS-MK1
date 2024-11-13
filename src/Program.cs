using System;
using System.IO;

class Program
{
    // Функція для обчислення total_strings і total_sets
    public static (int, int) CountStringsAndSets(int N, int K)
    {
        int totalStrings = 0;

        // Обчислення totalStrings як суми K^i для i від 1 до N
        for (int i = 1; i <= N; i++)
        {
            totalStrings += (int)Math.Pow(K, i);
        }

        // totalSets завжди 1 за умовами
        int totalSets = 1;

        return (totalStrings, totalSets);
    }

    static void Main(string[] args)
    {
        // Зчитування даних з INPUT.TXT
        string[] input = File.ReadAllLines("INPUT.TXT");
        var NandK = input[0].Split();
        int N = int.Parse(NandK[0]);
        int K = int.Parse(NandK[1]);

        // Виклик функції для обчислення
        var (totalStrings, totalSets) = CountStringsAndSets(N, K);

        // Запис результату у OUTPUT.TXT
        File.WriteAllText("OUTPUT.TXT", $"{totalStrings}\n{totalSets}\n");

        // Виведення для перевірки
        Console.WriteLine($"{totalStrings}\n{totalSets}");
    }
}
