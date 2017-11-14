using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaPushPopMin
{
    class Program
    {
        static void Main(string[] args)
        {

            var pilha = new Pilha(9);
            int min;

            pilha.Push(13);
            pilha.Push(14);
            pilha.Push(10);
            pilha.Push(11);
            pilha.Push(9);
            pilha.Push(90);
            pilha.Push(50);
            pilha.Push(3);
            pilha.Push(53);

            min = pilha.Min();
            PrintValues(pilha.Arr, ',');
            Console.ReadKey();
        }

        public static void PrintValues(System.Collections.IEnumerable myCollection, char mySeparator)
        {
            foreach (Object obj in myCollection)
                Console.Write("{0}{1}", mySeparator, obj);
            Console.WriteLine();
        }
    }
}
