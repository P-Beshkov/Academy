/* 07. Write a class GSMTest to test the GSM class:
 - Create an array of few instances of the GSM class.
 - Display the information about the GSMs in the array.
 - Display the information about the static property IPhone4S. */
using System;
using System.Collections.Generic;

class GSMTest
{
    private List<GSM> phones = new List<GSM>();
    public GSMTest()
    {
        GSM tempPhone = new GSM("Nokia", "N95", "Moni", 305.23M);
        phones.Add(tempPhone);
        tempPhone = new GSM("Samsung", "Note 2", "Nakov", 605.0M);
        phones.Add(tempPhone);
        tempPhone = new GSM("HTC", "One X", "Joro");
        phones.Add(tempPhone);
        tempPhone = GSM.IPhone;
        phones.Add(tempPhone);
    }
    public void ShowAllPhones()
    {
        foreach (GSM item in phones)
        {
            Console.WriteLine(item);
            Console.WriteLine();
        }
    }
    public static void ShowTheStatic()
    {
        Console.WriteLine(GSM.IPhone);
    }
    
}

