using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. Задание с чётным числами \n2. Задание со словами \n3. Задание с кубом\n");
            Console.Write("введите номер задания: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num == 1)
            {
                Console.Write("введите число n: ");

                int n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(GetOddNumbers(n));
            }

            if (num == 2)
            {
                Console.Write("Введите слово: ");
                string strok = Console.ReadLine();

                Console.WriteLine(SearchHello(strok, "hello"));
            }
            if (num == 3)
            {
                Console.Write("введите число n: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.Write("введите символ: ");
                string s = Console.ReadLine();
                Console.WriteLine(GetFigures(n, s));
            }


        }

        /// <summary>
        /// Формируем строку из четные числа от 0 до <paramref name="n"/> через запятую
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Выводит квадрат со сторонами <paramref name="n"/>, каждая сторона состоит из символов параметра <paramref name="symbol"/>
        /// </summary>
        /// <param name="n">Количество значений в одной стороне.</param>
        /// <param name="symbol">Символ, из которого будет состоять квадрат.</param>
        /// <returns></returns>
        /// 
       
        static string GetFigures(int n, string symbol)
        {
            string result = "";

            for (int i = 1; i <= n; i += 1)
            {
                if (i == 1 || i == n)
                {
                    for (int j = 1; j <= n; j += 1)
                    {
                        if (i == 1 || i == n)
                            result += symbol + " ";
                    }
                }
                else //todo оптимизировать построение
                {
                    for (int j = 1; j <= n; j += 1)
                    {
                        if (j == 1 || j == n)
                        {
                            result += symbol + " ";
                        }
                        else
                            result += "  ";
                    }
                }

                result += "\n";
            }

            result += "\n";

            // Ромб
            int mid = n/2;
            for (int i = 0; i < n; i++)
            {
                int diff;
                if (i > mid)
                {
                    diff = n - 1 - i;
                }
                else
                {
                    diff = i;
                }

                for (int j = 0; j < n; j++)
                {
                    if (j == mid - diff || j == mid + diff)
                    {
                        if (i == mid && j == mid)
                            result += "  ";  
                        else
                            result += symbol + " ";
                    }
                    else
                    {
                        result += "  ";
                    }
                }
                result += "\n";
            
            }

            // Треугольник
            for (int i = 1; i <= n; i++)
            {
                if (i == 1 || i == 2)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        result += symbol;
                    }
                }
                else if (i < n)
                {
                    result += symbol;
                    for (int j = 1; j <= i - 2; j++)
                    {
                        result += " ";
                    }
                    result += symbol;
                }
                else
                {
                    for (int j = 1; j <= n; j++)
                    {
                        result += symbol;
                    }
                }
                result += "\n";
            }
            result += "\n";

            // Стрелка вправо
            for (int i = 0; i < n; i++)
            {
                if (i <= mid)
                {
                    // Верхняя половина стрелки (растущая ширина)
                    for (int j = 0; j <= i; j++)
                    {
                        if (j == 0 || j == i)
                            result += symbol;
                        else
                            result += " ";
                    }
                }
                else
                {
                    // Нижняя половина стрелки (уменьшающая ширина)
                    for (int j = 0; j < n - i; j++)
                    {
                        if (j == 0 || j == n - i - 1)
                            result += symbol;
                        else
                            result += " ";
                    }
                }

                result += "\n";
            }
            return result;

        }
        /// <summary>
        /// Проверка есть ли в введенном слове <paramref name="inputstr"/> последовательность букв слова Hello
        /// </summary>
        /// <param name="inputstr"></param>
        /// <returns></returns>

        static bool SearchHello(string inputstr, string word)
        {
            int count = 0;
            
            for (int i = 0; i < inputstr.Length; i++)
            {
                if (inputstr[i] == word[count])
                {
                    count++;
                }
                if (count == word.Length) 
                {
                    return true;
                }
            } 

            return false;
        }
    }
}

