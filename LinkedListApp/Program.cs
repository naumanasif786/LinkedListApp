// See https://aka.ms/new-console-template for more information
using LinkedListApp;



/*Please not that generic linked List position starts at 0*/

RunInsertExample();

RunDeleteExample();

Console.ReadLine();


static void RunInsertExample()
{
    Console.WriteLine("***********INSERT EXAMPLE**********\r\n");
    Console.WriteLine("---Initial List---");
    var list = GetFruitsList();
    list.PrintAll();

    Console.WriteLine("---Inserting at specified position---");
    list.InsertAt(2, "Blueberry");
    list.InsertAt(4, "BlackBerry");
        
    Console.WriteLine("\r\n---Updated list after inserting new data at specified positions--");
    list.PrintAll();

}

static void RunDeleteExample()
{
    Console.WriteLine("***********DELETE EXAMPLE**********\r\n");
    Console.WriteLine("---Initial List---");
    var list = GetFruitsList();
    list.PrintAll();

    Console.WriteLine("---Deleting at specified position---");
    list.RemoveAt(2);
    
    Console.WriteLine("\r\n---Updated list after removing data at specified positions--");
    list.PrintAll();

}

static GenericLinkedList<string> GetFruitsList()
{
    var list =  new GenericLinkedList<string>("Apple");
    list.Insert("Orange");
    list.Insert("Banana");
    list.Insert("Grapes");
    list.Insert("pineapple");

    return list;
}


