using LinkedList;

Console.WriteLine("\nLet's create a simple Linked List of 56,30 and 70");

int flag = 0;

while (flag == 0)
{
    LinkedListSequence call = new LinkedListSequence();

    Console.WriteLine("\n1 - Inserting element at the front ");
    Console.WriteLine("2 - Inserting element at the last ");
    Console.WriteLine("3 - Inserting element between two nodes ");
    Console.WriteLine("4 - Deleting element at the front ");
    Console.WriteLine("5 - Deleting element at the last ");
    Console.WriteLine("6 - Search element in the linked list ");
    Console.WriteLine("7 - Search and than insert element in the linked list ");
    Console.WriteLine("8 - Search and than delete element in the linked list ");
    Console.WriteLine("9 - Sorting elements in the linked list ");

    Console.Write("\nYour Pick : ");
    int pick = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    switch (pick)
    {
        case 1:
            call.Adding(70);
            call.Adding(30);
            call.Adding(56);
            call.Display();
            break;
        case 2:
            call.Appending(56);
            call.Appending(30);
            call.Appending(70);
            call.Display();
            break;
        case 3:
            call.Appending(56);
            call.Appending(70);
            call.Display();
            call.InsertInBetween(2, 30);
            call.Display();
            break;
        case 4:
            call.Appending(56);
            call.Appending(30);
            call.Appending(70);
            call.Display();
            call.Pop();
            call.Display();
            break;
        case 5:
            call.Appending(56);
            call.Appending(30);
            call.Appending(70);
            call.Display();
            call.PopLast();
            call.Display();
            break;
        case 6:
            call.Appending(56);
            call.Appending(70);
            call.Appending(30);
            call.Display();
            call.Search(30);
            call.Search(10);
            break;
        case 7:
            call.Appending(56);
            call.Appending(30);
            call.Appending(70);
            call.Display();
            call.SearchAndInsert(30, 40);
            call.Display();
            break;
        case 8:
            call.Appending(56);
            call.Appending(30);
            call.Appending(40);
            call.Appending(70);
            call.Display();
            call.SearchAndDelete(40);
            call.Display();
            call.Size();
            break;
        case 9:
            call.Sorting(56);
            call.Sorting(30);
            call.Sorting(40);
            call.Sorting(70);
            Console.WriteLine("\nAfter Sorting ");
            call.Display();
            break;
        default:
            flag = 1;
            Console.WriteLine("Enter valid number");
            break;
    }
}

