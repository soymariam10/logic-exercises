using System;
using System.Collections.Generic;

class Fibonacci
{
    static Dictionary<int, int> memo = new Dictionary<int, int>();

    static void Main()
    {
        do
        {
            Console.Write("Ingrese el número de términos de la secuencia Fibonacci: ");
            int n;

            while (!int.TryParse(Console.ReadLine(), out n) || n < 0)
            {
                Console.WriteLine("Por favor, ingrese un número válido mayor o igual a 0.");
                Console.Write("Ingrese el número de términos de la secuencia Fibonacci: ");
            }

            Console.WriteLine("Secuencia Fibonacci:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(FibonacciRecursivoConMemo(i) + " ");
            }

            Console.WriteLine(); // Imprime una nueva línea para mejorar la presentación

            Console.Write("¿Desea continuar? (S/N): ");
        } while (Console.ReadLine()?.Trim().ToUpper() == "S");
    }

    static int FibonacciRecursivoConMemo(int n)
    {
        if (n <= 1)
            return n;

        if (memo.ContainsKey(n))
            return memo[n];

        memo[n] = FibonacciRecursivoConMemo(n - 1) + FibonacciRecursivoConMemo(n - 2);

        return memo[n];
    }
}
