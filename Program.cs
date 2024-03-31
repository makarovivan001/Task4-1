using System;
using HomeWork_Makarov_Ivan_number_3;
using HomeWork_Makarov_Ivan_number_3._1;

class program
{
    
    static void Main(string[] args)
    {
        OneDimensionalArray<int> array_1 = new OneDimensionalArray<int>();
        array_1.AddElement(233);
        array_1.AddElement(122);
        array_1.AddElement(231);
        array_1.AddElement(1);
        array_1.AddElement(23);
        array_1.AddElement(10000);
        array_1.AddElement(2);
        int n = int.Parse(Console.ReadLine());
        OneDimensionalArray<int> array_2 = new OneDimensionalArray<int>(n);
        array_2.AddElement(233);
        array_2.AddElement(122);
        array_2.AddElement(231);
        array_2.AddElement(1);
        array_2.AddElement(23);
        array_2.AddElement(10000);
        array_2.AddElement(2);
        array_1.Print();
        array_1.SelectionSortArray();
        array_1.Print();
        Console.WriteLine(array_1.MaxValue());
        Console.WriteLine(array_1.MinValue());
        array_2.Print();
        array_2.SelectionSortArray();
        array_2.Print();
        Console.WriteLine(array_2.MaxValue());
        Console.WriteLine(array_2.MinValue());




        Console.ReadKey();

    }
    
    
}