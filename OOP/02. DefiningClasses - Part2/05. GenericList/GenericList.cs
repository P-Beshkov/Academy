/*05. Write a generic class GenericList<T> that keeps a list of elements of some parametric type T. 
* Keep the elements of the list in an array with fixed capacity which is given as parameter 
* in the class constructor. Implement methods for adding element, accessing element by index, 
* removing element by index, inserting element at given position, clearing the list, finding 
* element by its value and ToString(). Check all input parameters to avoid accessing elements 
* at invalid positions. 
06. Implement auto-grow functionality: when the internal array is full, create a new 
* array of double size and move all elements to it.  */

using System;
using System.Collections.Generic;

class GenericList<T> where T : IComparable<T>
{
    private static int defaultCapacity = 16;
    private T[] data;
    private int index;
    private int capacity;

    public GenericList()
    {
        this.capacity = GenericList<T>.defaultCapacity;
        data = new T[capacity];
        index = 0;
    }

    public GenericList(int capacity) : this()
    {
        this.Capacity = capacity;
    }

    public override string ToString()
    {
        return string.Format("data: {0}, contains: {1}, capacity: {2}", typeof(T), index, Capacity);
    }

    public int Capacity
    {
        get
        {
            return this.capacity;
        }
        set
        {
            if (value > 0)
            {
                this.capacity = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Capacity must be positive");
            }
        }
    }

    public void Add(T item)
    {
        if (index == this.Capacity)
        {
            Grow();
        }
        this.data[index++] = item;
    }

    public T this[int index]
    {
        get
        {
            if (index < this.index && index >= 0)
            {
                return this.data[index];
            }
            else
            {
                throw new ArgumentOutOfRangeException("Index must be positive and below items count");
            }
        }
        set
        {
            if (index < this.index && index >= 0)
            {
                this.data[index] = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Index must be positive and below items count");
            }
        }
    }

    public void Remove(int at)
    {
        if (at >= this.index || at < 0)
        {        
            throw new ArgumentOutOfRangeException("Index must be positive and below items count");
        }
        T[] newData = new T[this.Capacity];
        for (int i = 0; i < at; i++)
        {
            newData[i] = this.data[i];
        }
        for (int i = at; i < this.index; i++)
        {
            newData[i] = this.data[i+1];
        }
        this.index--;
        data = newData;
    }

    public void Clear()
    {
        this.data = new T[capacity];
    }

    public bool Contains(T item)
    { 
        foreach (T current in this.data)
        {
            if (current.CompareTo(item) == 0)
            {
                return true;
            }
        }
        return false;
    }

    public void InsertAt(int at, T item)
    {
        if (at >= this.index || at < 0)
        {
            throw new ArgumentOutOfRangeException("Index must be positive and below items count");
        }
        if (at+this.index>=this.Capacity)
        {
            this.Grow();
        }
        T[] newData = new T[this.Capacity];
        for (int i = 0; i < at; i++)
        {
            newData[i] = this.data[i];
        }
        newData[at] = item;
        for (int i = at; i < this.index; i++)
        {
            newData[i+1] = this.data[i];
        }
        this.index++;
        data = newData;
    }
    public void ShowItems()
    {
        for (int i = 0; i < index; i++)
        {
            Console.Write(this.data[i] + ", ");
        }
        Console.WriteLine();
    }
    private void Grow()
    {
        int newCapacity = capacity << 1;
        T[] newData = new T[newCapacity];
        this.data.CopyTo(newData, 0);
    }
}