﻿using System;

public class Matriz
{
    private int[,] mat;

    public void Ingresar()
    {
        mat = new int[3, 4];
        for (int f = 0; f < 3; f++)
        {
            for (int c = 0; c < 4; c++)
            {
                Console.Write("Ingrese componente:");
                string linea = Console.ReadLine();
                mat[f, c] = int.Parse(linea);
            }
        }
    }

    public void Imprimir()
    {
        for (int f = 0; f < 3; f++)
        {
            for (int c = 0; c < 4; c++)
            {
                Console.Write(mat[f, c] + " ");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Matriz ma = new Matriz();
        ma.Ingresar();
        ma.Imprimir();
    }
}