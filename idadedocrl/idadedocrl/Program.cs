using System.Threading.Channels;
using System.Collections.Generic;
using System;

class Problem
{
    public static int CalculaIdade(List<int> idades)
    {
        int actualId = 0;
        if (idades[0] > idades[1])
        {
            actualId = idades[1];

            actualId = actualId > idades[2]
                ? actualId
                : idades[0];
        }
        else if (idades[0] < idades[1])
        {
            actualId = idades[0];

            actualId = actualId > idades[2]
                ? actualId
                : idades[1];


        } else
        {
            return idades[2];
        }

        return actualId;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        List<int> idades = new List<int>();

        Console.WriteLine("Digite três idades diferentes:");

        for (int i = 0; i < 3; i++)
        {
            int idade;
            do
            {
                Console.Write($"Idade {i + 1}: ");
            } while (!int.TryParse(Console.ReadLine(), out idade) || idades.Contains(idade));

            idades.Add(idade);
        }

        int idadeDoMeio = Problem.CalculaIdade(idades);

        Console.WriteLine($"A idade do meio é: {idadeDoMeio}");
    }
}