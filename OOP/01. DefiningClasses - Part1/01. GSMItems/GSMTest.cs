/* 07. Write a class GSMTest to test the MobilePhone class:
 - Create an array of few instances of the MobilePhone class.
 - Display the information about the GSMs in the array.
 - Display the information about the static property IPhone4S. */
using System;
using System.Collections.Generic;

internal class GSMTest
{
    private List<MobilePhone> phones = new List<MobilePhone>();
    public GSMTest()
    {
        MobilePhone tempPhone = new MobilePhone("Nokia", "", "Moni", 305.23M);
        phones.Add(tempPhone);
        tempPhone = new MobilePhone("Samsung", "Note 2", "Nakov", 605.0M);
        phones.Add(tempPhone);
        tempPhone = new MobilePhone("HTC", "One X", "Joro");
        phones.Add(tempPhone);
        tempPhone = MobilePhone.IPhone;
        phones.Add(tempPhone);
    }
    public void ShowAllPhones()
    {
        foreach (MobilePhone item in phones)
        {
            Console.WriteLine(item);
            Console.WriteLine();
        }
    }
    public static void ShowTheStatic()
    {
        Console.WriteLine(MobilePhone.IPhone);
    }
    
}

