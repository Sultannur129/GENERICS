namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary <int,string> dictionary1 = new MyDictionary<int, string>();
            dictionary1.Add(1, "Ahmet");
            dictionary1.Add(2, "Ali");
            Console.WriteLine(dictionary1.Count);
        }
    }
}