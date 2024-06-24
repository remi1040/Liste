class Program
{
    public static void Main(string[] args)
    {
        List<char> list = new List<char>();

        list.Add('a');
        list.Add('b');
        list.Add('c');

        foreach (char c in list)
        {
            Console.WriteLine(c);
        }
        

        list.RemoveAt(0);
        list.Remove('c');

        list[0] = 'd';

        foreach (char c in list)
        {
            Console.WriteLine(c);
        }
    }
}
