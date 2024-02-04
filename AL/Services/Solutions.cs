namespace AL.Services
{
    public class Solutions
    {
        public static void Main(string[] args)
        {
            GenerateInterestingNumbers();
        }

        public static void ConcatStrings() 
        {
            var nm = Console.ReadLine();
            long n = Convert.ToInt64(nm!.Split()[0]);
            long m = Convert.ToInt64(nm!.Split()[1]);
            List<string> strings = new List<string>();
            for (long i = 0; i < n + m; i++) 
            {
                strings.Add(Console.ReadLine()!);
            }
            strings.OrderByDescending(s => s.Length).ThenBy(s => s);
            long q = Convert.ToInt64(Console.ReadLine());
            string[] answers = new string[q];
            
            for (long j = 0; j < q; j++) 
            {
                long number = Convert.ToInt64(Console.ReadLine());
                long a = number / m + 1;
                long b = number % m + 1;
                answers[j] = a.ToString() + " " + b.ToString();
            }
            foreach (var answer in answers) 
            {
                Console.WriteLine(answer);
            }
        }

        public static void DrawTheCurve()
        {
            var nme = Console.ReadLine();
            int n = Convert.ToInt32(nme!.Split()[0]);
            int m = Convert.ToInt32(nme!.Split()[1]);
            int e = Convert.ToInt32(nme!.Split()[2]);
        }

        public static void GenerateInterestingNumbers() 
        {
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> b = new List<int>();
            foreach (var bread in Console.ReadLine()!.Split())
            {
                b.Add(Convert.ToInt32(bread));
            }
            var interestingNumbers = new List<int>();
            for (int i = 1; i <= Math.Sqrt(b[0]) + 1; i++) 
            {
                var isInteresting = CheckIsInteresting(b, i);
                if (isInteresting) 
                {
                    interestingNumbers.Add(i);
                }
            }
            if (CheckIsInteresting(b, b[0] - 1)) 
            {
                interestingNumbers.Add(b[0] - 1);
            }

            foreach (var number in interestingNumbers) 
            {
                Console.WriteLine(number);
            }
        }

        private static bool CheckIsInteresting(List<int> b, int i) 
        {
            var product = 1;
            int j = 0;
            bool isInteresting = false;
            while (j < b.Count)
            {
                product = product * b[j];
                if ((product - 1) % i == 0)
                {
                    isInteresting = true;
                    j++;
                    continue;
                }
                else
                {
                    isInteresting = false;
                    break;
                }
            }
            return isInteresting;
        }

        public static void HighestScore()
        {
            long t = Convert.ToInt64(Console.ReadLine());
            List<string> scores = new List<string>();
            for (long i = 0; i < t; i++) 
            {
                
                int n = Convert.ToInt32(Console.ReadLine());
                List<int> a = new List<int>();
                foreach (var aread in Console.ReadLine()!.Split()) 
                {
                    a.Add(Convert.ToInt32(aread));
                }
                List<int> b = new List<int>();
                foreach (var bread in Console.ReadLine()!.Split())
                {
                    b.Add(Convert.ToInt32(bread));
                }
                if (n == 1) 
                {
                    scores.Add(a[0].ToString());
                    continue;
                }
                int j = n / 2 + 1;
                int k = n / 2;

                long a_arbu = a.Take(j).Sum() + b.Take(j).Sum();
                long b_arbu = a.Skip(j).Sum() + b.Skip(j).Sum();

                long a_arbr = a.Sum();
                long b_arbr = b.Sum();

                long a_adbu = a[0] + b.Take(n - 1).Sum();
                long b_adbu = b[n - 1] + a.Skip(1).Sum();

                long a_adbr = a.Take(k).Sum() + b.Take(k).Sum();
                long b_adbr = a.Skip(k).Sum() + b.Skip(k).Sum();

                long a_rem;
                long a_down;
                if (b_arbu < b_arbr)
                {
                    a_rem = a_arbr;
                }
                else 
                {
                    a_rem = a_arbu;
                }

                if (b_adbu < b_adbr)
                {
                    a_down = a_adbr;
                }
                else
                {
                    a_down = a_adbu;
                }

                var score = (new[] { a_down, a_rem }).Max().ToString();
                scores.Add(score);
            }
            foreach (var score in scores)
            {
                Console.WriteLine(score.ToString());
            }
        }

        public static void EmulateAncientProc() 
        {
        
        }
    }
}
