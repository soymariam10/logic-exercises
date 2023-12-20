using System;
using System.Collections.Generic;

class Fibonacci
{
    static Dictionary<int, int> memo = new Dictionary<int, int>();

    static void Main()
    {
        do
        {
            Console.Write("Ingrese un número para encontrar su posición en la secuencia Fibonacci: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int posicion = EncontrarPosicionEnFibonacci(numero);

            if (posicion != -1)
                Console.WriteLine($"El número {numero} está en la posición {posicion} de la secuencia Fibonacci.");
            else
                Console.WriteLine($"El número {numero} no pertenece a la secuencia Fibonacci.");

            Console.Write("¿Desea continuar? (S/N): ");
        } while (Console.ReadLine()?.Trim().ToUpper() == "S");
    }

    static int EncontrarPosicionEnFibonacci(int numero)
    {
        for (int i = 0; ; i++)
        {
            int valor = FibonacciRecursivoConMemo(i);
            if (valor == numero)
                return i;
            else if (valor > numero)
                return -1; // El número no pertenece a la secuencia Fibonacci
        }
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
