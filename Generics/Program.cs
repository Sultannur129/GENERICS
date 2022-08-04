namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add(" ");
            
            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Ankara");
            Console.WriteLine(sehirler2.Count);


        }
    }



    class MyList<T>
    {
        T[] array;
        T[] tmpArray;

        public MyList()
        {
            array = new T[0];
        }
        public void Add(T item)
        {
            tmpArray = array;
            array = new T[array.Length+1];
            for (int i = 0; i < tmpArray.Length; i++)
            {
                array[i] = tmpArray[i];
            }

            array[array.Length-1] = item;

        }

        public int Count
        {
            get { return array.Length; }
        }

    }
}