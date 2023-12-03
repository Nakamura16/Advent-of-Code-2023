
using System.Drawing;
using System.Reflection.PortableExecutable;

string line;
int somaCorrectGames = 0;
int somaPower = 0;
int minBlue = 0;
int minRed = 0;
int minGreen = 0;
try
{
    StreamReader sr = new StreamReader("C:\\Andre\\Advent of Code 2023\\Advent-of-Code-2023\\AdventOfCode2023\\Dia2\\input.txt");

    do {
        line = sr.ReadLine();
        var game = line.Split(':');
        int gameNbr = int.Parse(game[0].Remove(0,5));
        var play = game[1].Split(';',',');
        foreach(string cor in play) {
            if (cor.Contains("blue"))
            {
                var aux = cor.Split("blue");
                int qtd = int.Parse(aux[0]);
                if (minBlue < qtd)
                {
                    minBlue = qtd;
                }
            }else if (cor.Contains("red"))
            {
                var aux = cor.Split("red");
                int qtd = int.Parse(aux[0]);
                if (minRed < qtd)
                {
                    minRed = qtd;
                }
            }
            else if (cor.Contains("green"))
            {
                var aux = cor.Split("green");
                int qtd = int.Parse(aux[0]);
                if (minGreen < qtd)
                {
                    minGreen = qtd;
                }
            }
        }
        int power = minBlue * minRed * minGreen;
        somaPower += power;

        minBlue = 0;
        minRed = 0;
        minGreen = 0;

    } while (sr.EndOfStream != true);

    Console.WriteLine(somaPower);
}
catch (Exception e)
{
    Console.WriteLine("Exception: " + e.Message);
}