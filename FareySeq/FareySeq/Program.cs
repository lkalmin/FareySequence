using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Runtime.Hosting;
using System.Text;
using System.Threading.Tasks;

namespace FareySeq
{
   class Program
   {
      /// <summary>
      /// The main.
      /// </summary>
      /// <param name="args">
      /// The args.
      /// </param>
      public static void Main(string[] args)
      {
         if (args.Length == 0)
         {
            Console.WriteLine("Input n value for Farey Sequence");
            return;
         }
         else
         {
            var n = Convert.ToInt32(args[0]);
            Console.WriteLine("Farey Sequence of order " + n.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine();
            FareySeq(n);
         }
      }

      /// <summary>
      /// Compute Farey Sequence of order n
      /// </summary>
      /// <param name="n">sequence order</param>
      public static void FareySeq(int n)
      {       
         Console.Write("F" + n.ToString(CultureInfo.InvariantCulture) + " = { ");

         int a = 0;
         int b = 1;
         int c = 1;
         int d = n;
         Console.Write("{0}/{1} ", a, b);

         // Compute successive terms
         while (c <= n)
         {
            var k = (int)((n + b) / d);
            int aa = a;
            int bb = b;
               
            a = c;
            b = d;
            c = (k * c) - aa;
            d = (k * d) - bb;
            Console.Write("{0}/{1} ", a, b);
         }

      Console.Write("}\n");
      }
   }
}
