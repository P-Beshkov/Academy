using System;

class Node<T> where T : IComparable<T>
{
    public T data;
    public Node<T> Left;
    public Node<T> Right;
    public Node<T> parent;

    public Node(T data)
    {
        this.data = data;
        this.parent = null;
    }

    public Node(T data, Node<T> parent) : this(data)
    {
        this.parent = parent;
    }
}