public class Program
{
    public static void Task1()
    {
        Console.WriteLine("Введите размер матрицы: ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        Console.WriteLine("Введите элементы матрицы: ");
        for (int i = 0; i < n; i++)
        {
            var s = Console.ReadLine().Split();
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = int.Parse(s[j]);
            }
        }

        int sum1 = 0;
        int sum2 = 0;

        for (int i = 0; i < n; i++)
        {
            sum1 += matrix[i, n - i - 1];
        }

        for (int i = 1; i < n; i++)
        {
            for (int j = n - 1; j > n - i - 1; j--)
            {
                sum2 += matrix[i, j];
            }
        }

        Console.WriteLine($"сумма элементов побочной диагонали = {sum1}, сумма элементов под диагональю = {sum2}");

    }

    public static void Task2()


    {
        Console.WriteLine("Введите строку ");
        string s = Console.ReadLine();

        if (s == " " || s == "")
        {

            Console.WriteLine("Введена пустая строка");
            return;
        }
        if (s.IndexOf('h') == -1)
        {
            Console.WriteLine("нет символа h");
            return;
        }

        int begin = s.IndexOf('h');
        int end = s.LastIndexOf('h');

        string s1 = s.Substring(0, begin + 1);
        string s3 = s.Substring(end);
        string s2 = s.Substring(begin + 1, s.Length - begin - s3.Length - 1);
        s2 = s2.Replace('h', 'H');

        s = s1 + s2 + s3;
        Console.WriteLine(s);
    }
    public static void Task3() 
    {
        Console.WriteLine("Ввведите строку английского алфавита ");
        string s = Console.ReadLine();

        Dictionary <char, int> Letters = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (!Letters.ContainsKey(s[i]))
            {
                Letters.Add(s[i], i);
            }
        }

        foreach(var x in Letters.Keys) 
        {
            char y = (char) ('a' + (x - 'a' + 3) % 26);
            s = s.Replace(x, y);
        }
        Console.WriteLine(s);

    }
    public static void Main()
    {
        Task3();
    }
}