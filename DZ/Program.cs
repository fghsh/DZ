public class WordSearcher
{
    /// <summary>
    /// Проверяет, содержится ли слово <paramref name="word"/> в строке <paramref name="inputstr"/>.
    /// </summary>
    /// <param name="inputstr">Исходная строка для поиска.</param>
    /// <param name="word">Искомое слово.</param>
    /// <returns>Возвращает true, если слово найдено, иначе false.</returns>
    public static bool SearchWord(string inputstr, string word)
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

            Console.WriteLine(WordSearcher.SearchWord(strok, "hello"));
        }

        if (num == 3)
        {
            Console.Write("введите число n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("введите символ: ");
            string s = Console.ReadLine();
            Console.WriteLine(GetSquare(n, s));
            Console.WriteLine(GetRhombus(n, s));
            Console.WriteLine(GetTriangle(n, s));
            Console.WriteLine(GetRightArrow(n, s));
        }
    }

    /// <summary>
    /// Формирует строку из нечётных чисел от 1 до <paramref name="n"/> через запятую.
    /// </summary>
    /// <param name="n">Верхняя граница диапазона чисел.</param>
    /// <returns>Строка с нечётными числами, разделёнными запятыми.</returns>
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
    /// Формирует квалрат из символов <paramref name="symbol"/> с размером стороны <paramref name="n"/>.
    /// </summary>
    /// <param name="n">Размер стороны квалрата.</param>
    /// <param name="symbol">Символ, используемый для построения квалрата.</param>
    /// <returns>Строка с рисунками квалрата.</returns>
    static string GetSquare(int n, string symbol)
    {
        string result = "";

        for (int i = 1; i <= n; i++)
        {
            if (i == 1 || i == n)
            {
                for (int j = 1; j <= n; j++)
                    result += symbol + " ";
            }
            else
            {
                for (int j = 1; j <= n; j++)
                {
                    if (j == 1 || j == n)
                        result += symbol + " ";
                    else
                        result += "  ";
                }
            }

            result += "\n";
        }

        return result;
    }


    /// <summary>
    /// Формирует ромб из символов <paramref name="symbol"/> с размером стороны <paramref name="n"/>.
    /// </summary>
    /// <param name="n">Размер стороны ромба.</param>
    /// <param name="symbol">Символ, используемый для построения ромба.</param>
    /// <returns>Строка с рисунками ромба.</returns>
    static string GetRhombus(int n, string symbol)
    {
        string result = "";
        result += "\n";

        int mid = n / 2;
        for (int i = 0; i < n; i++)
        {
            int diff = i > mid ? n - 1 - i : i;

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

        return result;
    }


    /// <summary>
    /// Формирует треугольник из символов <paramref name="symbol"/> с размером стороны <paramref name="n"/>.
    /// </summary>
    /// <param name="n">Размер стороны треугольник.</param>
    /// <param name="symbol">Символ, используемый для построения треугольник.</param>
    /// <returns>Строка с рисунками треугольник.</returns>
    static string GetTriangle(int n, string symbol)
    {
        string result = "";
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

        return result;
    }

    /// <summary>
    /// Формирует стрелку вправо из символов <paramref name="symbol"/> с размером стороны <paramref name="n"/>.
    /// </summary>
    /// <param name="n">Размер стороны стрелки вправо.</param>
    /// <param name="symbol">Символ, используемый для построения стрелки вправо.</param>
    /// <returns>Строка с рисунками стрелки вправо.</returns>
    static string GetRightArrow(int n, string symbol)
    {
        string result = "";
        int mid = n / 2;
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
}

/// <summary>
/// Пользователь интернет-магазина с именем, балансом, корзиной и заказами.
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

    /// <summary>
    /// Получить имя пользователя.
    /// </summary>
    /// <returns>Имя пользователя.</returns>
    public string GetName() => name;

    /// <summary>
    /// Получить текущий баланс пользователя.
    /// </summary>
    /// <returns>Баланс пользователя.</returns>
    public decimal GetBalance() => balance;

    /// <summary>
    /// Свойство доступа к корзине пользователя.
    /// </summary>
    public Cart Cart => cart;

    /// <summary>
    /// Добавить заказ в список заказов пользователя.
    /// </summary>
    /// <param name="order">Заказ для добавления.</param>
    public void AddOrder(Order order)
    {
        orders.Add(order);
    }

    /// <summary>
    /// Получить список всех заказов пользователя.
    /// </summary>
    /// <returns>Копия списка заказов.</returns>
    public List<Order> GetOrders() => new List<Order>(orders);

    /// <summary>
    /// Выполнить оплату с использованием объекта <paramref name="payment"/>.
    /// </summary>
    /// <param name="payment">Информация об оплате.</param>
    /// <returns>True если оплата успешна, иначе false.</returns>
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
/// Платеж с суммой, описанием, датой и статусом.
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

    /// <summary>
    /// Получить общую сумму платежа.
    /// </summary>
    /// <returns>Общая сумма.</returns>
    public decimal GetTotalPrice() => amount;

    /// <summary>
    /// Получить описание платежа.
    /// </summary>
    /// <returns>Описание.</returns>
    public string GetDescription() => description;

    /// <summary>
    /// Получить дату платежа.
    /// </summary>
    /// <returns>Дата и время платежа.</returns>
    public DateTime GetPaymentDate() => paymentDate;

    /// <summary>
    /// Получить статус платежа.
    /// </summary>
    /// <returns>Текущий статус.</returns>
    public PaymentStatus GetStatus() => status;

    /// <summary>
    /// Установить статус платежа как выполненный.
    /// </summary>
    public void MarkAsCompleted() => status = PaymentStatus.Completed;

    /// <summary>
    /// Установить статус платежа как неудавшийся.
    /// </summary>
    public void MarkAsFailed() => status = PaymentStatus.Failed;
}

public enum PaymentStatus
{
    /// <summary>
    /// Платеж ожидает выполнения.
    /// </summary>
    Pending,
    /// <summary>
    /// Платеж выполнен.
    /// </summary>
    Completed,
    /// <summary>
    /// Платеж неудачен.
    /// </summary>
    Failed,
    /// <summary>
    /// Платеж возвращён.
    /// </summary>
    Refunded
}

/// <summary>
/// Товар с именем и ценой.
/// </summary>
class Product  //Товар
{
    public string name;
    private int price;

    /// <summary>
    /// Получить цену товара.
    /// </summary>
    /// <returns>Цена товара.</returns>
    public decimal GetPrice()
    {
        return price;
    }
}

/// <summary>
/// Заказ, состоящий из товаров и связанный с покупателем.
/// </summary>
class Order : ITotalPrice
{
    private string _customer;
    private List<Product> _products;

    public Order(string customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    /// <summary>
    /// Получить общую цену заказа.
    /// </summary>
    /// <returns>Сумма цен всех товаров в заказе.</returns>
    public decimal GetTotalPrice()
    {
        decimal totalprice = 0;

        foreach (var product in _products)
        {
            totalprice += product.GetPrice();
        }

        return totalprice;
    }

    /// <summary>
    /// Получить список товаров заказа.
    /// </summary>
    /// <returns>Только для чтения список товаров.</returns>
    public IReadOnlyList<Product> GetProducts() => _products.AsReadOnly();
}

/// <summary>
/// Корзина пользователя с возможностью добавления и удаления товаров.
/// </summary>
class Cart : ITotalPrice
{
    private List<Product> products;
    private Dictionary<Product, int> productQuantities;
    public string price;

    public Cart()
    {
        products = new List<Product>();
        productQuantities = new Dictionary<Product, int>();
    }

    /// <summary>
    /// Добавить товар <paramref name="product"/> в корзину с указанным <paramref name="quantity"/>.
    /// </summary>
    /// <param name="product">Товар для добавления.</param>
    /// <param name="quantity">Количество товаров (по умолчанию 1).</param>
    public void AddProduct(Product product, int quantity = 1)
    {
        if (products.Contains(product))
        {
            productQuantities[product] += quantity;
        }
        else
        {
            products.Add(product);
            productQuantities[product] = quantity;
        }
    }

    /// <summary>
    /// Удалить указанное количество <paramref name="quantity"/> товара из корзины.
    /// </summary>
    /// <param name="product">Товар для удаления.</param>
    /// <param name="quantity">Количество для удаления (по умолчанию 1).</param>
    public void RemoveProduct(Product product, int quantity = 1)
    {
        if (productQuantities.ContainsKey(product))
        {
            int currentQuantity = productQuantities[product];

            if (currentQuantity <= quantity)
            {
                products.Remove(product);
                productQuantities.Remove(product);
            }
            else
            {
                productQuantities[product] = currentQuantity - quantity;
            }
        }
    }

    /// <summary>
    /// Получить общую цену всех товаров в корзине.
    /// </summary>
    /// <returns>Сумма цен товаров.</returns>
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

/// <summary>
/// Интерфейс для объектов, имеющих общую цену.
/// </summary>
public interface ITotalPrice
{
    /// <summary>
    /// Получить общую цену объекта.
    /// </summary>
    /// <returns>Цена объекта.</returns>
    decimal GetTotalPrice();
}



