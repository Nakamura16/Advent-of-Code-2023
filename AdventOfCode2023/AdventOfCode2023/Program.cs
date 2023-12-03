// See https://aka.ms/new-console-template for more information
// the calibration value can be found by combining the first digit and the last digit (in that order)
// to form a single two-digit number.

using System.Threading;
using System.Xml;

String line;
string firstNumber = "";
string secondNumber = "";
int soma = 0;
try
{
    StreamReader sr = new StreamReader("C:\\Andre\\Advent of Code 2023\\Advent-of-Code-2023\\AdventOfCode2023\\AdventOfCode2023\\input.txt");

    do
    {
        line = sr.ReadLine();
        string newLine = line
            .Replace("one", "o1ne")
            .Replace("two", "t2wo")
            .Replace("three", "th3ree")
            .Replace("four", "fo4ur")
            .Replace("five", "fi5ve")
            .Replace("six", "s6ix")
            .Replace("seven", "sev7en")
            .Replace("eight", "ei8ght")
            .Replace("nine", "ni9ne");
        string invertido = new String(newLine.Reverse().ToArray());

        foreach (var letra in newLine)
        {
            string aux = letra.ToString();
            if (int.TryParse(aux, out int numericValue))
            {
                firstNumber = aux;
                break;
            }
        }

        foreach (var letra in invertido)
        {
            string aux = letra.ToString();
            if (int.TryParse(aux, out int numericValue))
            {
                secondNumber = aux;
                break;
            }
        }
        
        int resultadoNumeroLinha = int.Parse(firstNumber + secondNumber);
        soma += resultadoNumeroLinha;

    } while (sr.EndOfStream != true);

    Console.WriteLine(soma);

    sr.Close();
}
catch (Exception e)
{
    Console.WriteLine("Exception: " + e.Message);
}
