/*
<=========== Learning Span ==========>
1. Span is like pointer in C/C++
2. It's memory efficient while slicing as it don't require memory allocation or copying contents
*/

int [] array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
Span<int> span = new Span<int>(array);
Span<int> slice = span.Slice(0,4);
Console.Write("Original Array: ");
foreach (var item in span)
{
    Console.Write(item + " ");
}
Console.WriteLine();

Console.Write("Sliced Array: ");
foreach(var item in slice)
{
    Console.Write(item + " ");
}
Console.WriteLine();

span[1] = 20;
Console.Write("Array after modification in span: ");
foreach (var item in array)
{
    Console.Write(item + " ");
}
