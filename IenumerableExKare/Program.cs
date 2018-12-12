using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

// enumerable ara yüzünü kullanarak 1 den başlayarak bütünın tam sayıların karelerini 1,4,9,16,...
//foreach ile dolasarak ekrana alt alta yazacak console app hazırla.kullanıcı Ctrl+C tusu ile program
//sonlanana kadar devam etmelidir.
namespace IenumerableExKare
{
    class Program
    {
        static void Main(string[] args)
        {
            Kareler f = new Kareler();
            foreach (int n in f)
            {
                Console.WriteLine(n);
                System.Threading.Thread.Sleep(200);
            }
            Console.ReadKey();
        }

        class Kareler : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                return new KareEnumerator();
            }
        }
        class KareEnumerator : IEnumerator
        {
            private int currentNumber;
            public KareEnumerator()
            {
                Reset();
            }
            public object Current { get { return currentNumber * currentNumber; } }
            public bool MoveNext()
            {
                ++currentNumber;
                return true;
            }
            public void Reset()
            {
                currentNumber = 0;
            }
        }
    }
}
