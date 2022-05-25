using LinkedList;

Console.WriteLine("\nLet's create a simple Linked List of 56,30 and 70");

int flag = 0;
while (flag == 0)
{
    Console.WriteLine("\n1 - Inserting element at the front ");
    Console.WriteLine("2 - Inserting element at the last ");
    Console.WriteLine("3 - Inserting element between two nodes ");
    Console.WriteLine("4 - Deleting element at the front ");
    
    Console.Write("\nYour Pick : ");
    int pick = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    switch (pick)
    {
        case 1:
            LinkedListSequence call = new LinkedListSequence();
            call.Adding(70);
            call.Adding(30);
            call.Adding(56);
            call.Display();
            break;
        case 2:
            LinkedListSequence call1 = new LinkedListSequence();
            call1.Appending(56);
            call1.Appending(30);
            call1.Appending(70);
            call1.Display();
            break;
        case 3:
            LinkedListSequence call2 = new LinkedListSequence();
            call2.Appending(56);
            call2.Appending(70);
            call2.Display();
            call2.InsertInBetween(2, 30);
            call2.Display();
            break;
        case 4:
            LinkedListSequence call3 = new LinkedListSequence();
            call3.Appending(56);
            call3.Appending(30);
            call3.Appending(70);
            call3.Display();
            call3.Pop();
            call3.Display();
            break;
        default:
            flag = 1;
            Console.WriteLine("Enter valid number");
            break;
    }
}

