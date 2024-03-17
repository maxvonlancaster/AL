namespace AL.Services
{
    public class SolutionsFourth
    {
        public static void Main(string[] args) 
        {
            FindTheLength();
        }

        public static void FindTheLength() 
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var a = Console.ReadLine();
            var aList = a?.Split(" ")
                .Select(x => Convert.ToInt32(x))
                .ToList();
            var outputs = Enumerable.Repeat(0, n)
                .ToList();
            int k = 0;
            if (n == 1) 
            {
                Console.WriteLine(1);
                return;
            }
            if (aList == null) 
            {
                return;
            }
            for (int i = 0; i < n - 2; i++) 
            {
                if (aList[i] < aList[i + 2])
                {
                    k++;
                }
                else 
                {
                    outputs[i] = k;
                    k = 0;
                }
            }
            outputs[n - 2] = k;
            Console.WriteLine(outputs.Max() + 2);
        }
    }
}
