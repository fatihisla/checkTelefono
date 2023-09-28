using System;

public static class Telefono
{
    public static string Check(string[] input)
    {
        foreach (string numero in input)
        {
            if (numero.Length == 10 && numero.StartsWith("3"))
            {
                return numero;
            }
            else if (numero.Length == 13 && numero.StartsWith("+39"))
            {
                return numero;
            }
            else if (numero.Length == 14 && numero.StartsWith("0039"))
            {
                return numero;
            }
            
        }

        return "";
    }
}

public class Program
{
public static void main(string[] args)
{
    string[] numeri1 = { "05417373", "3367726712", "778823" };
    string risultato1 = Telefono.Check(numeri1);
    Console.WriteLine(risultato1); // Output: 3367726712

    string[] numeri2 = { "33677267", "33677232", "778823" };
    string risultato2 = Telefono.Check(numeri2);
    Console.WriteLine(risultato2);  // Output: ""

    string[] numeri3 = { "", "05417723", "+391231231234" };
    string risultato3 = Telefono.Check(numeri3);
    Console.WriteLine(risultato3);  // Output: +391231231234

    string[] numeri4 = { "3", "05417723", "00391231231230" };
    string risultato4 = Telefono.Check(numeri4);
    Console.WriteLine(risultato4);  // Output: ""
}
}