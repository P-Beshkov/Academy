using System;
using System.Collections.Generic;
class BST<T> where T : IComparable<T>
{
    Node<T> root;
    private Node<T> child;
    public BST(T root)
    {
        this.root = new Node<T>(root, null);
        this.root.Left = null;
        this.root.Right = null;
    }
    //public IEnumerator<T> GetEnumerator()
    //{
    //    if (root == null)
    //    {
    //        yield return null;
    //    }
    //    yield return root.data;
    //    child = null;
    //    child = root.Left;
    //    GetEnumerator();
    //    child = root.Right;
    //    GetEnumerator();
    //}
    public Node<T> Search(T data)
    {
        Node<T> current = root;
        while (true)
        {
            if (data.CompareTo(current.data) < 0)
            {
                if (current.Left == null)
                {
                    return null;
                }
                current = current.Left;
            }
            else if (data.CompareTo(current.data) > 0)
            {
                if (current.Right == null)
                {
                    return null;
                }
                current = current.Right;
            }
            else
            {
                return current;
            }
        }
    }

    public void Add(params T[] newItems)
    {
        for (int i = 0; i < newItems.Length; i++)
        {
            T data = newItems[i];
            Node<T> current = root;
            while (true)
            {
                if (data.CompareTo(current.data) < 0)
                {
                    if (current.Left == null)
                    {
                        current.Left = new Node<T>(data, current);
                        break;
                    }
                    current = current.Left;
                }
                else if (data.CompareTo(current.data) > 0)
                {
                    if (current.Right == null)
                    {
                        current.Right = new Node<T>(data, current);
                        break;
                    }
                    current = current.Right;
                }
                else
                {
                    Console.WriteLine("Element already in!");
                    break;
                }
            }
        }
    }

    private void PrintDFS(Node<T> root, string spaces)
    {
        if (root == null)
        {
            return;
        }
        Console.WriteLine(spaces + root.data);
        Node<T> child = null;
        child = root.Left;
        PrintDFS(child, spaces + "   ");
        child = root.Right;
        PrintDFS(child, spaces + "   ");
    }

    public void PrintDFS()
    {
        this.PrintDFS(this.root, string.Empty);
    }

    public void Remove(T value)
    {
        Node<T> nodeToDelete = Search(value);
        if (nodeToDelete == null)
        {
            return;
        }
        Remove(nodeToDelete);
    }

    private void Remove(Node<T> node)
    {
        if (node.Left != null && node.Right != null)
        {
            Node<T> replacement = node.Right;
            while (replacement.Left != null)
            {
                replacement = replacement.Left;
            }
            node.data = replacement.data;
            node = replacement;
        }

        Node<T> theChild = node.Left != null ? node.Left : node.Right;

        // If the element to be deleted has one child 
        if (theChild != null)
        {
            theChild.parent = node.parent;

            // Handle the case when the element is the root 
            if (node.parent == null)
            {
                root = theChild;
            }
            else
            {
                // Replace the element with its child sub tree 
                if (node.parent.Left == node)
                {
                    node.parent.Left = theChild;
                }
                else
                {
                    node.parent.Right = theChild;
                }
            }
        }
        else
        {
            // Handle the case when the element is the root 
            if (node.parent == null)
            {
                root = null;
            }
            else
            {
                // Remove the element - it is a leaf 
                if (node.parent.Left == node)
                {
                    node.parent.Left = null;
                }
                else
                {
                    node.parent.Right = null;
                }
            }
        }
    }
}