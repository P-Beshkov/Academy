﻿/*12. Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
- Create an instance of the GSM class.
- Add few calls.
- Display the information about the calls.
- Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
- Remove the longest call from the history and calculate the total price again.
- Finally clear the call history and print it. */
using System;
using System.Collections.Generic;

class GSMCallHistoryTest
{
    static void Main(string[] args)
    {
        GSM samplePhone = new GSM("Sony", "Cedar", "Bobi", 180M);
        samplePhone.AddCall();
        samplePhone.AddCall();
        samplePhone.AddCall();
        samplePhone.AddCall();
        samplePhone.DisplayCallHistory();
        Console.WriteLine("{0}'s bill = {1}",samplePhone.Owner,samplePhone.CalculateBill(0.37M));
        samplePhone.DeleteCall();
        Console.WriteLine("Recalculated bill = {0}",samplePhone.CalculateBill(0.37M));

    }
}
