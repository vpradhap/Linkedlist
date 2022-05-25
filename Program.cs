using LinkedList;

Console.WriteLine("\nLet's create a simple Linked List of 56,30 and 70\n");

LinkedListSequence call = new LinkedListSequence();

call.Appending(56);
call.Appending(70);
call.Display();
call.InsertInBetween(2,30);
call.Display();
Console.ReadKey();