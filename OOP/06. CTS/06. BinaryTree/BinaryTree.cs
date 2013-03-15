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

public class TestBST
{
    static void Main()
    {
        BST<int> tree = new BST<int>(20);
        tree.Add(10, 25, 18, 6, 29, 50);
        //int searched = tree.Search(6).data;
        //Console.WriteLine(searched);
        tree.PrintDFS();
        tree.Remove(29);
        tree.PrintDFS();
    }
}