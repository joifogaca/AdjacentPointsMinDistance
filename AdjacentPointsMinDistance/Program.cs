using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdjacentPointsMinDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = new List<int>();

            string line;
            do
            {
                Console.Write("Write 'end' to exit or Enter with a number ");
                 line = Console.ReadLine();
                if (line != "end")
                {
                    number.Add(int.Parse(line));
                }
                
            } while (line != "end");

            Console.WriteLine("The Result: ");
            Console.WriteLine(solution(number.ToArray()));
            Console.ReadLine();
        }

        public static int solution(int[] A)
        {
            if (A.Count() < 2 || A == null)
                return -2;


            int? minDistance = null;
            

            for (int i = 0; i < A.Count(); i++)
            {
                for (int j = i+1; j < A.Count(); j++)
                {
                    int min = A[i];
                    int max = A[j];

                    bool isAdjacente = true;
                    int distance = min - max;

                        foreach (int item in A)
                        {
                            if (item > min && item < max)
                            {
                            isAdjacente = false;
                            break;
                            }
                        }

                        if ((isAdjacente && distance >= 0 )&& (minDistance > distance || minDistance == null))
                        {
                            minDistance = distance;
                        }
                    }
                }
            if (minDistance > 10000000)
            {
                return -1;
            }

            if (minDistance == null)
            {
                return -2;
            }

            return (int)minDistance;
        }

           

        }

   
}
