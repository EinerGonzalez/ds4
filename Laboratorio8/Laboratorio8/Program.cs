﻿using Laboratorio8;

internal class Program
{
    public static void Main()
    {
        Trabajador p = new Trabajador("Josan", 22, "77588260-z", 100000);
         Console.WriteLine("Nombre="+p.Nombre);
        Console.WriteLine("Edad=", p.Edad);
        Console.WriteLine("NIF"+p.NIF);
        Console.WriteLine("Sueldo="+ p.Sueldo);
             }
}