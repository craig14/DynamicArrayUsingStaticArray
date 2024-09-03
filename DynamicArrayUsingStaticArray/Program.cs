// See https://aka.ms/new-console-template for more information
using DynamicArrayUsingStaticArray;
using System.ComponentModel;

Console.WriteLine("Hello, World! Select the datatype:");
Console.WriteLine("1)Dynamic Array\n2)Single LinkedList");
string key = Console.ReadLine();

switch (key)
{
    case "1":
        DynamicArr arr = new DynamicArr();
        arr.Add(1);
        arr.Add(2);
        arr.Add(3);
        arr.Add(4);

        Console.WriteLine(arr.ToString());
        arr.Delete(2);
        Console.WriteLine("Deleted at index 2");
        Console.WriteLine(arr.ToString());
        arr.Insert(5);
        Console.WriteLine("Inserted element 5");
        Console.WriteLine(arr.ToString());
        Console.WriteLine("Is element 5 present?");
        Console.WriteLine(arr.Contains(5) ? "Yes" : "No");
        Console.WriteLine("Is element 6 present?");
        Console.WriteLine(arr.Contains(6) ? "Yes" : "No");
        Console.WriteLine("Index of element 6?");
        Console.WriteLine(arr.IndexOf(6));
        Console.WriteLine("Index of element 4?");
        Console.WriteLine(arr.IndexOf(4));
        Console.WriteLine("Array Cleanup!");
        arr.Clear();
        Console.WriteLine(arr.ToString());
        break;
    case "2":
        SingleLinkedList<int> list = new SingleLinkedList<int>();
        list.AddNodeToHead(1);
        list.AddNodeToTail(2);
        list.AddNodeToHead(0);
        list.AddNodeToTail(10);
        Console.WriteLine(list.ToString());
        Console.WriteLine("Adding 20 to tail and -10 to head");
        list.AddNodeToTail(20);
        list.AddNodeToHead(-10);
        Console.WriteLine(list.ToString());
        Console.WriteLine("Removing 20 from tail and -10 from head");
        list.RemoveNodeFromHead();
        list.RemoveNodeFromTail();
        Console.WriteLine(list.ToString());
        Console.WriteLine("Checking if 2 exist?");
        Console.WriteLine(list.Contains(2) ? "Yes" : "No");
        Console.WriteLine("Checking if 20 exist?");
        Console.WriteLine(list.Contains(20) ? "Yes" : "No");
        Console.WriteLine("Checking index of 2?");
        Console.WriteLine(list.IndexOf(2));
        Console.WriteLine("Checking index of 20?");
        Console.WriteLine(list.IndexOf(20));
        Console.WriteLine("Remove element 2.");
        list.Remove(2);
        Console.WriteLine(list.ToString());
        Console.WriteLine("Add null to tail");
        break;
    default:
        Console.WriteLine("Invalid selection!");
        break;
}


