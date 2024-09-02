// See https://aka.ms/new-console-template for more information
using DynamicArrayUsingStaticArray;

Console.WriteLine("Hello, World!");
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
Console.WriteLine(arr.Contains(5)?"Yes":"No");
Console.WriteLine("Is element 6 present?");
Console.WriteLine(arr.Contains(6) ? "Yes" : "No");
Console.WriteLine("Index of element 6?");
Console.WriteLine(arr.IndexOf(6));
Console.WriteLine("Index of element 4?");
Console.WriteLine(arr.IndexOf(4));
Console.WriteLine("Array Cleanup!");
arr.Clear();
Console.WriteLine(arr.ToString());

