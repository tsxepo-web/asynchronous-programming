class Program
{
    static void Main()
    {
        Console.WriteLine("Synchronous Operation");
        RsaPresidents();
        Console.WriteLine();
        Console.WriteLine("Asynchronous Operation");
        RsaPresidentTimePeriod();
        Console.Read();
    }

    static void RsaPresidents()
    {
        President1();
        President2();
        President3();
        President4();
    }

    static void RsaPresidentTimePeriod()
    {
        Task.Run(() =>
        {
            President1();
        });
        Task.Run(() =>
        {
            President2();
        });
        Task.Run(() =>
        {
            President3();
        });
        Task.Run(() =>
        {
            President4();
        });
    }
    static string President1()
    {
        Thread.Sleep(300);
        Console.WriteLine("Nelson Rholihlahla Mandela");
        return "1994";
    }

    static string President2()
    {
        Thread.Sleep(200);
        Console.WriteLine("Thabo Mbeki");
        return "1999";
    }

    static string President3()
    {
        Thread.Sleep(100);
        Console.WriteLine("Jacob Gedleyihlekisa Zuma");
        return "2009";
    }

    static string President4()
    {
        Console.WriteLine("Cyril Ramaphosa");
        return "Current";
    }
}