using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        int[] numArray = new int[5];
        numArray[0] = 5;
        numArray[1] = 2;
        numArray[2] = 10;
        numArray[3] = 200;
        numArray[4] = 5000;

        int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300};
        
        int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };
        numArray2[5] = 650;

        Console.WriteLine(numArray[3]);
        Console.WriteLine(numArray1[3]);
        Console.WriteLine(numArray2[3]);
        Console.WriteLine(numArray2[5]);

        List<int> intList = new List<int>();
        List<string> intList1 = new List<string>();
        intList1.Add("Hello");
        intList1.Add("World");
        intList.Add(4);
        intList.Add(10);
        intList.Remove(10);

        byte[] byteArray = new byte[5000];

        Console.WriteLine(intList[0]);
        Console.WriteLine(intList1[0]);


        Console.ReadLine();

    }
}

