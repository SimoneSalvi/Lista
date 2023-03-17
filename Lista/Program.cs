using Lista;

internal class Program
{
    private static void Main(string[] args)
    {
        ListaItem list = new ListaItem();

        Item item = new(21);


        list.Insert(item);
        list.Print();

        item = new(27);
        list.Insert(item);
        list.Print();

        item = new(25);
        list.Insert(item);
        list.Print();

        item = new(40);
        list.Insert(item);
        list.Print();

        item = new(10);
        list.Insert(item);
        list.Print();

        item = new(22);
        list.Insert(item);
        list.Print();

        Console.WriteLine("após remoção");
 //       list.Pop(item);
        list.Print();
    }
}