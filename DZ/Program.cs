namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Введите число N: ");
            //string input = Console.ReadLine();

            //if (int.TryParse(input, out int N))
            //{
            //    Console.WriteLine($"Нечетные числа от 1 до {N}:");
            //    for (int i = 1; i <= N; i += 2)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            Console.Write("Введите слово: ");
            string s = Console.ReadLine();
            //Console.WriteLine(GetOddNumbers(N));
            //Console.WriteLine(GetKubX(N));
            Console.WriteLine(GetHello(s));

        }
        static string GetOddNumbers(int n)
        {
            string stroka = "";

            for (int i = 1; i <= n; i += 2)
            {
                stroka += i.ToString() + ",";
            }
            stroka = stroka.Substring(0, stroka.Length - 1);
            return stroka;

        }
        static string GetKubX(int n)
        {
            string result = "";

            for (int i = 1; i <= n; i += 1)
            {
                if (i == 1 || i == n)
                {
                    for (int j = 1; j <= n; j += 1)
                    {
                        result += "x ";
                    }
                }
                else
                {
                    for (int j = 1; j <= n; j += 1)
                    {
                        if (j == 1 || j == n)
                        {
                            result += "x ";
                        }
                        else
                            result += "  ";
                    }
                }


                result += "\n";
            }

            return result;

        }
        static string GetHello(string s)
        {
            //ueellooohll
            string hello = "hello";
            int count = 0;
            

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == hello[count])
                {
                    count++;
                }
                if (count == hello.Length) 
                {
                    return "YES";
                }
            } 
            return "NO";
        }
    }
}

