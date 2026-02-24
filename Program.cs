




using ConsoleApp19;


IEnumerable<int> list1 = new int[] { 2, 5, 7, 8, 3, 11, 12 };

PrintNumber(list1, n => n < 5, () => Console.WriteLine("numbers less than 6"));

PrintNumber(list1, n => n < 8, () => Console.WriteLine("numbers less than 8"));

PrintNumber(list1, n => n % 2==0, () => Console.WriteLine("numbers is even"));


IEnumerable<decimal> list2 = new decimal[] { 2.22m, 5.55m, 7.33m, 8.45m, 3.34m, 11.34m, 12.34m };


PrintNumber(list2, n => n < 8.5m,()=> Console.WriteLine("numbers less than 8.5"));
PrintNumber(list2, n => n < 12.33m, () => Console.WriteLine("numbers less than 12.33"));


static void PrintNumber<T>(IEnumerable<T> numbers, Func<T,bool> /* Predicate<T> */filter,Action action)
{
    action();
    foreach (T n in numbers)
        if (filter(n))
        {
            Console.WriteLine(n);
        }
}



Action<string> action = Print;
action("mahmoud");
Func<int, int, int> func = Add;
Console.WriteLine(func(2, 3));
Predicate<int> predicate = EvenNum;
Console.WriteLine(predicate(3));


static void Print(string name) => Console.WriteLine(name);
static int Add(int n1,int n2)  => n1 + n2;

static bool EvenNum(int n) => n % 2 == 0;












