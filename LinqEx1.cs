namespace revision;

public static class LinqEx1
{
    public static void Run()
    {
        List<int> list = [1, 2, 3, 4, 5, 6, 7, 8, 9];
        List<int> evens = list.Where(x => x % 2 == 0).ToList();
        List<int> odds = list.Where(x => x % 2 != 0).ToList();
        List<int> divBy3 = list.Where(x => x % 3 == 0).ToList();
        List<int> squared = list.Select(x => x * x).ToList();
        IePrint(list);
        IePrint(evens);
        IePrint(odds);
        IePrint(divBy3);
        IePrint(squared);

        List<int> l = (from i in list where (i < 5) select i).ToList();
        int[] numbers = [20, 70, 53, 15, 28, 39, 79, 87, 82, 91];
        IEnumerable<int> lessThan70Query = from number in numbers where number < 70 select number;
        
        IePrint(l);        
        IePrint(numbers);
        IePrint(lessThan70Query);

        for (int i = 10; i > 0; i--)
        {
            IEnumerable<int> ie = LessThanThresholdQuery(list, i);
            IePrint(ie);
        }
    }

    private static void IePrint(IEnumerable<int> ie)
    {
        foreach (int i in ie) Console.Write($"{i} ");
        Console.WriteLine();
    }

    private static IEnumerable<int> LessThanThresholdQuery(IEnumerable<int> ie, int threshold)
    {
        return ie.Where(x => x < threshold);
    }
}
