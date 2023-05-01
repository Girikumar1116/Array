using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Deletion
    {
       /* public static void Main(string[] args)
        {
            Console.WriteLine("enter a arr size");
            int len = int.Parse(Console.ReadLine());
            int[] arr = new int[len];
            for (int i = 0; i < len; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("enter element position to dlt");
            int pos = int.Parse(Console.ReadLine());
            if (pos >= len || pos < 0)
            {
                Console.WriteLine("invalid position");
            }
            else
            {
                //arr.RemoveAt(pos);

                for (int i = pos; i < len; i++)
                {
                    if (i == len - 1)
                    {
                        break;
                    }
                    else { arr[i] = arr[i + 1]; }
                }
                len--;
            }
            Console.Write("\nElements of array after delete are \n ");
            for (int i = 0; i < len; i++)
            {
                Console.Write("{0}\t", arr[i]);
            }
            Console.ReadLine();


        }*/
    }
}
