namespace ConsoleApp3
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.Write("1. Задание с чётным числами \n2. Задание со словами \n3. Задание с кубом\n");
        //    Console.Write("введите номер задания: ");
        //    int num = Convert.ToInt32(Console.ReadLine());

        //    if (num == 1)
        //    {
        //        Console.Write("введите число n: ");

        //        int n = Convert.ToInt32(Console.ReadLine());

        //        Console.WriteLine(GetOddNumbers(n));
        //    }

        //    if (num == 2)
        //    {
        //        Console.Write("Введите слово: ");
        //        string strok = Console.ReadLine();

        //        Console.WriteLine(SearchWord(strok, "hello"));
        //    }
        //    if (num == 3)
        //    {
        //        Console.Write("введите число n: ");
        //        int n = Convert.ToInt32(Console.ReadLine());
        //        Console.Write("введите символ: ");
        //        string s = Console.ReadLine();
        //        Console.WriteLine(GetFigures(n, s));
        //    }


        //}

        ///// <summary>
        ///// Формируем строку из четные числа от 0 до <paramref name="n"/> через запятую
        ///// </summary>
        ///// <param name="n"></param>
        ///// <returns></returns>
        //static string GetOddNumbers(int n)
        //{
        //    string stroka = "";

        //    for (int i = 1; i <= n; i += 2)
        //    {
        //        stroka += i.ToString() + ",";
        //    }
        //    stroka = stroka.Substring(0, stroka.Length - 1);

        //    return stroka;
        //}

        ///// <summary>
        ///// Формирует фигуры используя <paramref name="n"/>, из символов параметра <paramref name="symbol"/>
        ///// </summary>
        ///// <param name="n">Количество значений в одной стороне.</param>
        ///// <param name="symbol">Символ, из которого будет состоять квадрат.</param>
        ///// <returns></returns>
        ///// 

        ////todo сделать stringBuilder.
        //static string GetFigures(int n, string symbol) 
        //{
        //    string result = "";

        //    // Пустой квадрат

        //    for (int i = 1; i <= n; i += 1)
        //    {
        //        if (i == 1 || i == n)
        //        {
        //            for (int j = 1; j <= n; j += 1)
        //            {
        //                if (i == 1 || i == n)
        //                    result += symbol + " ";
        //            }
        //        }
        //        else //todo оптимизировать построение
        //        {
        //            for (int j = 1; j <= n; j += 1)
        //            {
        //                if (j == 1 || j == n)
        //                {
        //                    result += symbol + " ";
        //                }
        //                else
        //                    result += "  ";
        //            }
        //        }

        //        result += "\n";
        //    }

        //    result += "\n";

        //    // Пустой ромб

        //    int mid = n/2;
        //    for (int i = 0; i < n; i++)
        //    {
        //        int diff;
        //        if (i > mid)
        //        {
        //            diff = n - 1 - i;
        //        }
        //        else
        //        {
        //            diff = i;
        //        }

        //        for (int j = 0; j < n; j++)
        //        {
        //            if (j == mid - diff || j == mid + diff)
        //            {
        //                if (i == mid && j == mid)
        //                    result += "  ";  
        //                else
        //                    result += symbol + " ";
        //            }
        //            else
        //            {
        //                result += "  ";
        //            }
        //        }
        //        result += "\n";

        //    }

        //    // Треугольник

        //    for (int i = 1; i <= n; i++)
        //    {
        //        if (i == 1 || i == 2)
        //        {
        //            for (int j = 1; j <= i; j++)
        //            {
        //                result += symbol;
        //            }
        //        }
        //        else if (i < n)
        //        {
        //            result += symbol;
        //            for (int j = 1; j <= i - 2; j++)
        //            {
        //                result += " ";
        //            }
        //            result += symbol;
        //        }
        //        else
        //        {
        //            for (int j = 1; j <= n; j++)
        //            {
        //                result += symbol;
        //            }
        //        }
        //        result += "\n";
        //    }
        //    result += "\n";

        //    // Стрелка вправо

        //    for (int i = 0; i < n; i++)
        //    {
        //        if (i <= mid)
        //        {
        //            // Верхняя половина стрелки (растущая ширина)
        //            for (int j = 0; j <= i; j++)
        //            {
        //                if (j == 0 || j == i)
        //                    result += symbol;
        //                else
        //                    result += " ";
        //            }
        //        }
        //        else
        //        {
        //            // Нижняя половина стрелки (уменьшающая ширина)
        //            for (int j = 0; j < n - i; j++)
        //            {
        //                if (j == 0 || j == n - i - 1)
        //                    result += symbol;
        //                else
        //                    result += " ";
        //            }
        //        }

        //        result += "\n";
        //    }

        //    return result;

        //}
        ///// <summary>
        ///// Проверка есть ли в введенном слове <paramref name="inputstr"/> последовательность букв слова Hello
        ///// </summary>
        ///// <param name="inputstr"></param>
        ///// <returns></returns>

        //static bool SearchWord(string inputstr, string word)
        //{
        //    int count = 0;

        //    for (int i = 0; i < inputstr.Length; i++)
        //    {
        //        if (inputstr[i] == word[count])
        //        {
        //            count++;
        //        }
        //        if (count == word.Length) 
        //        {
        //            return true;
        //        }
        //    } 

        //    return false;
        //}

        //todo Спроектируйте и реализуйте систему для обработки заказов в интернет-магазине. Минимальные сущности:
        //Заказ (Order), Товар (Product), Корзина (Cart), Платеж (Payment) и Пользователь (Customer).

        // У пользователя могу быть несколько заказов(состоящих из товаров и платежей ) и корзина

        /// <summary>
        /// Пользователь
        /// </summary>
        class Customer //Пользователь
        {

            private string name;
            private decimal balance;
            public Cart cart { get; set; }
            private List<Order> orders; // У пользователя несколько заказов

            public Customer(string name, decimal balance)
            {
                this.name = name;
                this.balance = balance;
                this.orders = new List<Order>();
                this.cart = new Cart();

            }
            public string GetName() => name;
            public decimal GetBalance() => balance;

            // Свойство для доступа к корзине
            public Cart Cart => cart;

            // Методы для работы с заказами
            public void AddOrder(Order order)
            {
                orders.Add(order);
            }

            public List<Order> GetOrders() => new List<Order>(orders);

            // Метод для оплаты
            public bool ProcessPayment(Payment payment)
            {
                if (balance >= payment.GetTotalPrice())
                {
                    balance -= payment.GetTotalPrice();
                    return true;
                }
                return false;
            }


        }
        /// <summary>
        /// Платеж
        /// </summary>
        class Payment //Платеж
        {
            private decimal amount;
            private string description;
            private DateTime paymentDate;
            private PaymentStatus status;

            public Payment(decimal amount, string description)
            {
                this.amount = amount;
                this.description = description;
                this.paymentDate = DateTime.Now;
                this.status = PaymentStatus.Pending;
            }

            // Реализация интерфейса ITotalCost
            public decimal GetTotalPrice() => amount;

            public string GetDescription() => description;
            public DateTime GetPaymentDate() => paymentDate;
            public PaymentStatus GetStatus() => status;

            public void MarkAsCompleted() => status = PaymentStatus.Completed;
            public void MarkAsFailed() => status = PaymentStatus.Failed;
        }
        public enum PaymentStatus
        {
            Pending,
            Completed,
            Failed,
            Refunded
        }


        /// <summary>
        /// 
        /// </summary>
        class Product  //Товар
        {
            public string name;
            private int price;

            public decimal GetPrice()
            {
                return price;
            }
        }
        /// <summary>
        /// Заказ,есть метод возвращения общей стоимости товаров
        /// </summary>
        class Order : TotalCost
        {

            private string customer;
            private List<Product> products;

            public Order(string customer, List<Product> products)
            {

                this.customer = customer;
                this.products = new List<Product>(products);
            }

            public decimal GetTotalPrice()
            {
                decimal totalprice = 0;

                foreach (var product in products)
                {
                    totalprice += product.GetPrice();
                }

                return totalprice;
            }

            public IReadOnlyList<Product> GetProducts() => products.AsReadOnly();
        }
        /// <summary>
        /// Корзина, есть метод возвращения общей стоимости товаров
        /// </summary>
        class Cart : TotalCost
        {
            public string name;
            public string path;
            public List<Product> products;

            public decimal GetTotalPrice()
            {
                decimal totalprice = 0;
                foreach (var product in products)
                {
                    totalprice += product.GetPrice();
                }
                return totalprice;
            }

        }

        public interface TotalCost
        {
            decimal GetTotalPrice();
        }

    }
}

