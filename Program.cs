using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        float a = 23;
        float b = 00;
        float c = 11;

        Penjumlahan p = new Penjumlahan();
        var hasil = p.JumlahTigaAngka(a, b, c);
        Console.WriteLine("Hasil Penjumlahan: " + hasil);
    }
}