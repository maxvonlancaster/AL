using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AL.Services
{
    public class SolutionsSecond
    {
        public static void Main(string[] args)
        {
            OperatorPrecedence();
        }

        public static void Invocations() 
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int tl = Convert.ToInt32(Console.ReadLine());
            int[] inputs = new int[n];
            bool isOrange = false;
            int max = 0;
            string[] outputs = new string[n];
            for (int i = 0; i < n; i++)
            {
                inputs[i] = Convert.ToInt32(Console.ReadLine()!);
                if (inputs[i] > tl) 
                {
                    outputs[i] = "red";
                    isOrange = true;
                }
                if (inputs[i] <= tl && inputs[i] > tl / 2) 
                {
                    outputs[i] = "orange";
                    isOrange = true;
                }
                if (inputs[i] <= tl / 2) 
                {
                    outputs[i] = "green";
                }
                if (inputs[i] > max) 
                {
                    max = inputs[i];
                }
            }

            for (int i = 0; i < n; i++) 
            {
                if (inputs[i] == max && !isOrange && max >= 100) 
                {
                    outputs[i] = "blue";
                }
            }
            foreach (var output in outputs) 
            {
                Console.WriteLine(output);
            }
        }

        public static void OperatorPrecedence() 
        {
            int t = Convert.ToInt32(Console.ReadLine());
            int[] inputs = new int[t];
            string[] outputs = new string[t];
            int k;

            for (int i = 0; i < t; i++) 
            {
                inputs[i] = Convert.ToInt32(Console.ReadLine()!);
                k = 2 * inputs[i] - 3;
                StringBuilder output = new StringBuilder();
                output.Append(k.ToString());
                for (int j = 0; j < inputs[i] - 1; j++) 
                {
                    output.Append(" 2 -1 ");
                }
                output.Append(" 1");
                outputs[i] = output.ToString();
            }
            foreach (var output in outputs)
            {
                Console.WriteLine(output);
            }
        }
    }
}
