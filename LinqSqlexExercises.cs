using Microsoft.EntityFrameworkCore;
using revision.Data;
using revision.Models;

namespace revision;

public static class LinqSqlexExercises
{
    public static void Run()
    {
        Console.Write("Enter the number of the exercise you want to run: ");
        if (int.TryParse(Console.ReadLine(), out var choice))
        {
            switch (choice)
            {
                case 1:
                    Ex1();
                    break;
                case 2:
                    Ex2();
                    break;
                case 3:
                    Ex3();
                    break;
                case 4:
                    Ex4();
                    break;
                case 5:
                    Ex5();
                    break;
                case 6:
                    Ex6();
                    break;
                case 7:
                    Ex7();
                    break;
                case 8:
                    Ex8();
                    break;
                case 9:
                    Ex9();
                    break;
                case 10:
                    Ex10();
                    break;
                case 11:
                    Ex11();
                    break;
                case 12:
                    Ex12();
                    break;
                case 13:
                    Ex13();
                    break;
                case 14:
                    Ex14();
                    break;
                case 15:
                    Ex15();
                    break;
                case 16:
                    Ex16();
                    break;
                case 17:
                    Ex17();
                    break;
                case 18:
                    Ex18();
                    break;
                case 19:
                    Ex19();
                    break;
                case 20:
                    Ex20();
                    break;
                case 21:
                    Ex21();
                    break;
                case 22:
                    Ex22();
                    break;
                default:
                    Console.WriteLine("{0} not available.", choice);
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }

    private static void Ex1()
    {
        using var context = new AppDbContext();
        var e = context.Salesmen.Take(5);
        foreach (var v in e)
        {
            Console.WriteLine($"{v.SalesmanId} - {v.Name} - {v.City} - {v.Commission}");
        }
    }
    private static void Ex2()
    {
        using var context = new AppDbContext();
        var e = context.Salesmen.Select(s=> new {s.Name,s.Commission});
        foreach (var v in e)
        {
            Console.WriteLine($"{v.Name} - {v.Commission}");
        }
    }
    private static void Ex3()
    {
        using var context = new AppDbContext();
        var e = context.Orders.Select(o => new {o.OrdDate,o.SalesmanId,o.OrdNo,o.PurchAmt});
        foreach (var v in e)
        {
            Console.WriteLine($"{v.OrdDate} - {v.SalesmanId} - {v.OrdNo} - {v.PurchAmt}");
        }
    }
    private static void Ex4()
    {
        using var context = new AppDbContext();
        var e = context.Orders.Select(o => o.SalesmanId).Distinct().OrderBy(salesmanId => salesmanId);
        foreach (var v in e)
        {
            Console.WriteLine(v);
        }
    }
    private static void Ex5()
    {
        using var context = new AppDbContext();
        var e = context.Salesmen.Where(s => s.City == "Paris").Select(s => new { s.SalesmanId, s.City });
        foreach (var v in e)
        {
            Console.WriteLine($"{v.SalesmanId} - {v.City}");
        }
    }
    private static void Ex6()
    {
        using var context = new AppDbContext();
        var e = context.Customers.Where(c => c.Grade == 200)
            .Select(c => new { c.CustomerId, c.CustName, c.Grade, c.SalesmanId });
        foreach (var v in e)
        {
            Console.WriteLine($"{v.CustomerId} - {v.CustName} - {v.Grade} - {v.SalesmanId}");
        }
    }
    private static void Ex7()
    {
        using var context = new AppDbContext();
        var e = context.Orders.Where(o => o.SalesmanId == 5001).Select(o => new { o.OrdNo, o.OrdDate, o.PurchAmt });
        foreach (var v in e)
        {
            Console.WriteLine($"{v.OrdNo} - {v.OrdDate} - {v.PurchAmt}");
        }
    }
    private static void Ex8()
    {
        using var context = new AppDbContext();
        var e = context.NobelWins.Where(n => n.Year == 1970).Select(n => new { n.Year, n.Subject, n.Winner });
        foreach (var v in e)
        {
            Console.WriteLine($"{v.Year} - {v.Subject} - {v.Winner}");
        }
    }
    private static void Ex9()
    {
        using var context = new AppDbContext();
        var e = context.NobelWins.Where(n => n.Year > 1950 && n.Subject == "Physics").Select(n => n.Winner);
        foreach (var v in e)
        {
            Console.WriteLine(v);
        }
    }
    private static void Ex10()
    {
        using var context = new AppDbContext();
        var e = context.NobelWins.Where(n=> n.Winner != null && n.Winner.StartsWith("Louis") )
            .Select(n=> new { n.Year, n.Subject, n.Winner ,n.Country,n.Category});
        foreach (var v in e)
        {
            Console.WriteLine($"{v.Year} - {v.Subject} - {v.Winner} - {v.Country} - {v.Category}");
        }
    }
    private static void Ex11()
    {
        using var context = new AppDbContext();
        var e = context.NobelWins.Where(n => n.Subject != null && !n.Subject.StartsWith("P"))
            .Select(n => new { n.Year, n.Subject, n.Winner, n.Country, n.Category })
            .OrderByDescending(n => n.Year).ThenBy(n => n.Winner);
        foreach (var v in e)
        {
            Console.WriteLine($"{v.Year} - {v.Subject} - {v.Winner} - {v.Country} - {v.Category}");
        }
    }
    private static void Ex12()
    {
        using var context = new AppDbContext();
        var e = context.ItemMasts.GroupBy(i => i.ProCom).Select(g => new { code = g.Key, avgprice = g.Average(i => i.ProPrice) });
        foreach (var v in e)
        {
            Console.WriteLine($"{v.code} - {v.avgprice}");
        }
    }
    private static void Ex13()
    {
        using var context = new AppDbContext();
        var minprice = context.ItemMasts.Min(i => i.ProPrice);
        var e = context.ItemMasts.Where(i => i.ProPrice == minprice).Select(i => i.ProName);
        foreach (var v in e)
        {
            Console.WriteLine($"{v} - {minprice}");
        }
    }
    private static void Ex14()
    {
        using var context = new AppDbContext();
        var e = context.EmpDetails.Select(emp => emp.EmpLname).Distinct();
        foreach (var v in e)
        {
            Console.WriteLine(v);
        }
    }
    private static void Ex15()
    {
        var context = new AppDbContext();
        var e = context.Orders.Select(o => new { o.OrdNo, o.OrdDate, o.PurchAmt, o.CustomerId, o.SalesmanId })
            .Where(o => o.OrdDate == new DateOnly(2012, 9, 10) && o.SalesmanId>5005 || o.PurchAmt > 1000);
        foreach (var v in e)
        {
            Console.WriteLine($"{v.OrdNo} - {v.OrdDate} - {v.PurchAmt} - {v.CustomerId} - {v.SalesmanId}");
        }
    }
    private static void Ex16()
    {
        var context = new AppDbContext();
        var e = context.Orders.Where(o => o.PurchAmt > 3000).Select(o => new { o.OrdNo, o.PurchAmt });
        foreach (var v in e)
        {
            Console.WriteLine($"{v.OrdNo} - {v.PurchAmt} - Achieved: {100*v.PurchAmt/6000}% - Unachieved: {100 - 100*v.PurchAmt/6000}%");
        }
    }
    private static void Ex17()
    {
        var context = new AppDbContext();
        var e = context.Salesmen.Where(s => string.Compare(s.Name.Substring(0, 1).ToUpper(), "N") >= 0);
        foreach (var v in e)
        {
            Console.WriteLine($"{v.SalesmanId} - {v.Name} - {v.City} - {v.Commission}");
        }
    }
    private static void Ex18()
    {
        var context = new AppDbContext();
        var e = context.Customers.Where(c => c.CustName.ToUpper().EndsWith("N"));
        foreach (var v in e)
        {
            Console.WriteLine($"{v.CustomerId} - {v.CustName} - {v.City} - {v.Grade} -{v.SalesmanId}");
        }
    }
    private static void Ex19()
    {
        var context = new AppDbContext();
        var e = context.Salesmen.Where(s => s.Name.StartsWith("N") && s.Name.Substring(3, 1).ToUpper() == "L");
        foreach (var v in e)
        {
            Console.WriteLine($"{v.SalesmanId} - {v.Name} - {v.City} - {v.Commission}");
        }
    }
    private static void Ex20()
    {
        var context = new AppDbContext();
        var e = context.Testtables.Where(t => EF.Functions.Like(t.Col1,"%\\_%","\\"));
        foreach (var v in e)
        {
            Console.WriteLine($"{v.Col1}");
        }
    }
    private static void Ex21()
    {
        var context = new AppDbContext();
        var sa = context.Salesmen.Select(s => new {s.Name ,s.City}).ToList();
        var cu =context.Customers.Select(c=> new {c.CustName,c.City}).ToList();
        foreach (var v1 in cu)
        {
            foreach (var v2 in sa)
            {
                if (v2.City == v1.City)
                {
                    Console.WriteLine($"{v1.CustName} - {v2.Name} - {v2.City}");
                }
            }
        }
    }
    private static void Ex22()
    {
        var context = new AppDbContext();
        var e = context.Customers.Join(context.Salesmen, customer => customer.SalesmanId,
            salesman => salesman.SalesmanId,
            (customer, salesman) => new
            {
                customer.CustName, ccity = customer.City, customer.Grade , salesman.Name, scity = salesman.City,
                customer.CustomerId
            }).OrderBy(g => g.CustomerId);
        foreach (var v in e)
        {
            Console.WriteLine($"{v.CustName} - {v.ccity} - {v.Grade} - {v.Name} -{v.scity}");
        }
    }
}
