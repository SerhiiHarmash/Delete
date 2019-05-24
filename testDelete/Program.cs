using System;
using System.Security.Principal;

namespace testDelete
{
    class Program
    {
        public static event EventHandler MyEvent //публичное событие MyEvent с типом EventHandler
        {
            add
            {
                Console.WriteLine("add operation");
            }

            remove
            {
                Console.WriteLine("remove operation");
            }
        }

        static void Main()
        {
        

            MyEvent += new EventHandler(DoNothing);
            MyEvent -= null;

            Console.ReadKey();
        }

        static void DoNothing(object sender, EventArgs e)
        {
        }

        static void Print(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item+ " ");
            }

            Console.WriteLine();
        }
    }
    
}
