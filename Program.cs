using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cf_div3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int x = a[0];
                int y = a[1];
                    if(x%y==0)
                   {
                        Console.WriteLine("YES");
                    }
                    else
                    {
                        Console.WriteLine("NO");
                    }

                }
             
            }
        }
    }

