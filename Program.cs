﻿Console.WriteLine("-- Números Múltiplos --");
Console.WriteLine("");
Console.WriteLine("Digite um número...");

int numero1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite um número para comparar se ele é múltiplo ou não...");

int numero2 = Convert.ToInt32(Console.ReadLine());

if (numero1 % numero2 == 0)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"O número {numero1} é múltiplo de {numero2}!");
    Console.WriteLine("");
}

else
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"O número escrito ({numero1}) não é múltiplo do outro número escrito ({numero2})!");
    Console.WriteLine("");
}
Console.ResetColor();
