using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Dynamic_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[8];

            int currentCount = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Print")
                {
                    Console.WriteLine(array.Length);
                }
                else
                {
                    array[currentCount] = int.Parse(command);
                    currentCount++;

                    if (currentCount == array.Length)
                    {
                        int[] temporary = new int[array.Length];

                        for (int i = 0; i < array.Length; i++)
                        {
                            temporary[i] = array[i];
                        }

                        array = new int[array.Length * 2];

                        for (int i = 0; i < temporary.Length; i++)
                        {
                            array[i] = temporary[i];
                        }
                    }
                    
                }
            }
        }
    }
}
