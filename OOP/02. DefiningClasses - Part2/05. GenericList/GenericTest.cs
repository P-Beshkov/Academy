/*07.Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal 
 * element in the  GenericList<T>. You may need to add a generic constraints for the type T. */

using System;
using System.Collections.Generic;

class GenericTest
{
    public T Min<T>(T firstItem, T secondItem) where T:IComparable
    {
        if (firstItem.CompareTo(secondItem)<0)
        {
            return firstItem;
        }
        else
        {
            return secondItem;
        }
    }
    public T Max<T>(T firstItem, T secondItem) where T : IComparable
    {
        if (firstItem.CompareTo(secondItem) > 0)
        {
            return firstItem;
        }
        else
        {
            return secondItem;
        }
    }
    static void Main()
    {
        GenericList<int> test = new GenericList<int>();
        test.Add(5);
        test.Add(-32);
        test.Add(10);
        test.Add(256);
        test.ShowItems();
        test.InsertAt(2, -1000);
        test.ShowItems();
        test.Remove(1);
        test.ShowItems();
    }
}