//tworzy liste 
List<string> todo_list = new List<string>();

void WriteList(List<string> list)
{
    Console.Clear();
    Console.WriteLine("To-Do list: \n");
    for (int i = 0; i < todo_list.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {todo_list[i]}");
    }
}

void SwapList(List<string> list, int a)
{
    a--;
    try
    {
        string temp = list[0];
        list[0] = list[a];
        list[a] = temp;
    }
    catch (System.Exception)
    {
        Console.WriteLine("Blad");
    }

}