using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AL.Services
{
    public class SolutionsThird
    {
        public static void Main(string[] args)
        {
            GeneratingTheSequence();
        }

        public static void GeneratingTheSequence() 
        {
            var nq = Console.ReadLine();
            int n = Convert.ToInt32(nq!.Split()[0]);
            int q = Convert.ToInt32(nq!.Split()[1]);
            List<long> a = new List<long>();
            string aString = Console.ReadLine()!;
            List<string> aSplit = aString.Split().ToList();
            List<string> outputs = new List<string>();
            foreach (var elem in aSplit) 
            {
                a.Add(Convert.ToInt64(elem));
            }
            for (int i = 0; i < q; i++) 
            {
                List<string> input = Console.ReadLine()!
                    .Split()
                    .ToList();
                if (input[0] == "1")
                {
                    for (int j = Convert.ToInt32(input[1]) - 1;
                        j <= Convert.ToInt32(input[2]) - 1; j++)
                    {
                        a[j] += Convert.ToInt64(input[3]);
                    }
                }
                else 
                {
                    long mult = 1;
                    for (int j = Convert.ToInt32(input[1]) - 1;
                        j <= Convert.ToInt32(input[2]) - 1; j++)
                    {
                        mult *= a[j];
                        mult = mult % 1048576;
                    }
                    outputs.Add(mult.ToString());
                }
            }
            foreach (var output in outputs)
            {
                Console.WriteLine(output);
            }
        }
    }
}
