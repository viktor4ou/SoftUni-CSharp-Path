namespace Program
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.ConstrainedExecution;

    class Program
    {
        static void Main()
        {
           List<string> list = Console.ReadLine().Split().ToList();

           foreach (var strings in list.Where(x => x.Length % 2 == 0))
           {
               Console.WriteLine(strings);
           }
        }
    }

}