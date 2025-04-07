//============ Collections ========================//
// 1. List //
string sepLine = "=========";
Console.WriteLine($"{sepLine} List {sepLine}\n");
List<string> bookList = new List<string>();
bookList.Add("Head First C");
bookList.Add("Head First C#");
bookList.AddRange(new string[] { "OOP","DevOps","Machine Learning"});

foreach (string bookItem in bookList)
{
    Console.WriteLine(bookItem);
}
for (int i=0; i<bookList.Count; i++)
{
    Console.WriteLine(bookList[i]);
}
// 2. Set //
Console.WriteLine($"{sepLine} Set {sepLine}\n");
HashSet<string> bookSet = new HashSet<string>();
bookSet.Add("Bangla");
bookSet.Add("English");
// Doesn't Support AddRange()
bookSet.Add("Bangla");
bookSet.Add("Physics");
bookSet.Add("Chemistry");

foreach (string bookItem in bookSet)
{
    Console.WriteLine(bookItem);
}

// 3. Dictionary //
Console.WriteLine($"{sepLine}Dictionary{sepLine}\n");
Dictionary<int, string> bookDictionary = new Dictionary<int, string>();
bookDictionary.Add(101,"Differential Calculus");
bookDictionary.Add(102,"Integral Calculus");
bookDictionary.Add(103,"Geometry and System of linear equations");
bookDictionary.Add(104, "Fourier Transform");

foreach(int id in bookDictionary.Keys)
{
    Console.WriteLine($"Book ID: {id} Book Name: {bookDictionary[id]}");
}

// 4. Queue //
Console.WriteLine($"\n{sepLine} Queue {sepLine}\n");
Queue<string> orderQueue = new Queue<string>();
orderQueue.Enqueue("Rice Order");
orderQueue.Enqueue("Oil Order");
orderQueue.Enqueue("Mineral Water Order");
orderQueue.Enqueue("Onion Order");

while(orderQueue.Count > 0)
{
    Console.WriteLine(orderQueue.Dequeue());
}

// 5. Stack //
Console.WriteLine($"\n{sepLine} Stack {sepLine}\n");
Stack<int> historyStack = new Stack<int>();
historyStack.Push(0);
historyStack.Push(1);
historyStack.Push(2);
historyStack.Push(3);
historyStack.Push(4);

while(historyStack.Count > 0)
{
    Console.WriteLine(historyStack.Pop());
}

// 5. Sorted List //
Console.WriteLine($"\n{sepLine} SortedList {sepLine}\n");
SortedList<int, string> sortedBooks = new SortedList<int, string>();
sortedBooks.Add(202, "Refactoring");
sortedBooks.Add(101, "Clean Code");
sortedBooks.Add(100, "SRS");
sortedBooks.Add(105, "Design Pattern");

foreach (var bookItem in sortedBooks)
{
    Console.WriteLine($"{bookItem.Key}: {bookItem.Value}");
}

// 7. LinkedList //
Console.WriteLine($"\n{sepLine} LinkedList {sepLine}\n");
LinkedList<string> bookSteps = new LinkedList<string>();
bookSteps.AddLast("Select Book");
bookSteps.AddLast("Add to Cart");
bookSteps.AddFirst("Login");

LinkedListNode<string> targetNode = books.Find("OOP Concepts");

// Insert after the target node
if (targetNode != null)
{
    books.AddAfter(targetNode, "Delegates & Events");
}


foreach (var step in bookSteps)
{
    Console.WriteLine(step);
}