using System;
using System.Collections.Generic;

class Program
{
    static void Main(String[] args)
    {
        float a = 23;
        float b = 00;
        float c = 11;

        Penjumlahan p = new Penjumlahan();
        var hasil = p.JumlahTigaAngka(a, b, c);
        Console.WriteLine("Hasil Penjumlahan: " + hasil);

        SimpleDataBase<float> db = new SimpleDataBase<float>();
        db.AddNewData(a);
        db.AddNewData(b);
        db.AddNewData(c);

        db.PrintAllData();
    }
}
class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.UtcNow);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine($"Data {i + 1} berisi: {storedData[i]}, disimpan pada waktu UTC: {inputDates[i]}");
        }
    }
}
