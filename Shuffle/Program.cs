using System;
using System.Linq;
using System.Threading;

namespace Shuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            IShuffler ioShuffler = new DurstenfeldShuffler();
            foreach (var i in ioShuffler.Shuffle(a))
                Console.Write(i + " ");
            Console.WriteLine();
            foreach (var i in a)
                Console.Write(i + " ");
            //Console.WriteLine();
            //Thread.Sleep(100);
            //foreach (var i in ioShuffler.Shuffle(a).OrderBy(x => x))
            //    Console.Write(i + " ");
            Console.WriteLine();
            IShuffler fyShuffler = new FisherYatesShuffler();
            foreach (var i in fyShuffler.Shuffle(a))
                Console.Write(i + " ");
        }
    }
}
