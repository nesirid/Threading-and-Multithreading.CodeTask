void Method1()
{
    //Thread.Sleep(2000);
    for (int i = 0; i < 100; i++)
    {
        Console.WriteLine("Method1 - " + i);
    }
}
void Method2()
{
    for (int i = 0; i < 100; i++)
    {
        Console.WriteLine("Method2 - " + i);
    }
}

void Method3()
{
    for (int i = 0; i < 100; i++)
    {
        Console.WriteLine("Method3 - " + i);
    }


}

Thread thread1 = new Thread(Method1);
thread1.Start();

Method3();

Thread thread2 = new Thread(Method2);
thread2.Start();

