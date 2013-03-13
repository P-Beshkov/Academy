/*06. * Define the data structure binary search tree with operations 
* for "adding new element", "searching element" and "deleting elements".
* It is not necessary to keep the tree balanced. Implement the standard 
* methods from System.Object – ToString(), Equals(…), GetHashCode() and
* the operators for comparison  == and !=. Add and implement the 
* ICloneable interface for deep copy of the tree. 
* Remark: Use two types – structure BinarySearchTree (for the tree) and 
* class TreeNode (for the tree elements). Implement IEnumerable<T> to 
* traverse the tree. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

class BST
{
    Node root;

    public BST(int data)
    {
        root = new Node(data,null);

        root.Left = null;
        root.Right = null;
    }

    public Node Search(int data)
    {
        Node current = root;
        while (true)
        {
            if (data < current.data)
            {
                if (current.Left == null)
                { 
                    return null;
                }
                current = current.Left;
            }
            else if (data > current.data)
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

    public void Add(params int[] newItems)
    {
        for (int i = 0; i < newItems.Length; i++)
        {
            int data = newItems[i];
            Node current = root;    
            while (true)
            {
                if (data < current.data)
                {
                    if (current.Left == null)
                    {
                        current.Left = new Node(data,current);
                        break;
                    }
                    current = current.Left;
                }
                else if (data > current.data)
                {
                    if (current.Right == null)
                    {
                        current.Right = new Node(data,current);
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

    private void PrintDFS(Node root, string spaces)
    {
        if (root == null)
        {
            return;
        }
        Console.WriteLine(spaces + root.data);
        Node child = null;
        child = root.Left;
        PrintDFS(child, spaces + "   ");
        child = root.Right;
        PrintDFS(child, spaces + "   ");
    }

    public void PrintDFS()
    {
        this.PrintDFS(this.root, string.Empty);
    }

    public void Remove(int value)
    {
        Node nodeToDelete = Search(value);
        if (nodeToDelete == null)
        {
            return;
        }

        Remove(nodeToDelete);
    }

    private void Remove(Node node) 
    { 
        // Case 3: If the node has two children. 
        // Note that if we get here at the end  
        // the node will be with at most one child 
        if (node.Left != null && node.Right != null) 
        { 
            Node replacement = node.Right;
            while (replacement.Left != null) 
            { 
                replacement = replacement.Left; 
            }
            node.data = replacement.data; 
            node = replacement;          
        }
 
        // Case 1 and 2: If the node has at most one child 
        Node theChild = node.Left != null ? node.Left : node.Right; 
 
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

    static void Main()
    {
        BST tree = new BST(20);
        tree.Add(10, 25, 18, 6, 29, 50);
        //int searched = tree.Search(6).data;
        //Console.WriteLine(searched);
        tree.PrintDFS();
        tree.Remove(29);
        tree.PrintDFS();
    }
}

class Node
{
    public int data;
    public Node Left;
    public Node Right;
    public Node parent;

    public Node(int data)
    {
        this.data = data;
        this.parent = null;
    }

    public Node(int data, Node parent) : this(data)
    {
        this.parent = parent;
    }
}