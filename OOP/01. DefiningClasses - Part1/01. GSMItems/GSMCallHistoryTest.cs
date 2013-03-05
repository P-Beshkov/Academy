/*12. Write a class GSMCallHistoryTest to test the call history functionality of the MobilePhone class.
- Create an instance of the MobilePhone class.
- Add few calls.
- Display the information about the calls.
- Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
- Remove the longest call from the history and calculate the total price again.
- Finally clear the call history and print it. */
using System;

class GSMCallHistoryTest
{
    static void Main(string[] args)
    {
        //GSMTest test = new GSMTest();
        //test.ShowAllPhones();
        MobilePhone samplePhone = new MobilePhone("Sony", "Cedar", "Bobi", 180M);        
        samplePhone.AddCall();
        samplePhone.AddCall();
        samplePhone.AddCall();
        samplePhone.AddCall();
        Console.Write(samplePhone.CallHistory);
        Console.WriteLine("{0}'s bill = {1}",samplePhone.Owner,samplePhone.CalculateBill(0.37M));
        samplePhone.DeleteCall();
        Console.WriteLine("Recalculated bill = {0}",samplePhone.CalculateBill(0.37M));
        Console.WriteLine(samplePhone.CallHistory);
        samplePhone.ClearCallHistory();
        Console.WriteLine("Calls after clear function");
        Console.WriteLine(samplePhone.CallHistory);
    }
}

