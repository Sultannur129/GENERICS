using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class MyDictionary<T,K>
    {
        T[] array1;
        T[] tmparray1;
        K[] array2;
        K[] tmparray2;
        public MyDictionary()
        {
            array1 = new T[0];
            array2 = new K[0];

        }
        public void Add(T item1, K item2)
        {
            tmparray1 = array1;
            array1 = new T[array1.Length + 1];
            tmparray2 = array2;
            array2 = new K[array2.Length + 1];

            for (int i = 0; i < tmparray1.Length; i++)
            {
                array1[i]=tmparray1 [i];
                array2[i]=tmparray2 [i];
            }
            array1[array1.Length-1]=item1 ;
            array2[array2.Length-1]=item2 ;

        }


        public int Count { 
            get { return array1.Length; } 
        }  

        
    }
}
