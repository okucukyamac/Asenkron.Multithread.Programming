


#region Thread Sınıfı

//Thread thread = new(() =>
//{
//    for (int i = 0; i < 1000; i++)
//    {
//        Console.WriteLine("thread" + i);
//    }
//});

//thread.IsBackground = false;

//thread.Start();

//for (int i = 0; i < 1000; i++)
//{
//    Console.WriteLine(i);
//}

#endregion

#region Thread Id
//Console.WriteLine("Main thread");
//Console.WriteLine(Environment.CurrentManagedThreadId);
//Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
//Thread thread = new(() =>
//{
//    Console.WriteLine("Worker1 thread");
//    Console.WriteLine(Environment.CurrentManagedThreadId);
//    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
//});

//thread.Start();
//Thread thread2 = new(() =>
//{
//    Console.WriteLine("Worker2 thread");
//    Console.WriteLine(Environment.CurrentManagedThreadId);
//    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
//});

//thread2.Start();

#endregion

#region IsBackground


//int i = 4;

//Thread thread = new(() =>
//{
//    while (i >= 0)
//    {
//        i--;
//        Console.WriteLine(i);
//        Thread.Sleep(1000);
//    }
//    Console.WriteLine($"Worker Thread tamamlandı");
//});
//thread.IsBackground = true;
//thread.Start();

//Console.WriteLine("Main thread tamamlandı");


//isbackground true ise uygulama main thread tamamlanınca biter
//false ise worker thread bitene kadar devam eder.



#endregion

#region Thread State

//int i = 4;

//Thread thread = new(() =>
//{
//    while (i >= 0)
//    {
//        i--;
//        Console.WriteLine(i);
//        Thread.Sleep(1000);
//    }
//    Console.WriteLine($"Worker Thread tamamlandı");
//});

//thread.Start();

//ThreadState state = ThreadState.Running;

//while (true)
//{
//    if(thread.ThreadState==ThreadState.Stopped)
//        break;

//    if (state != thread.ThreadState)
//    {
//        state = thread.ThreadState;
//        Console.WriteLine(thread.ThreadState);
//    }
//}

#endregion

#region Locking
//object locking = new();
//int i = 1;
//Thread thread1 = new(() =>
//{
//    lock (locking)
//    {
//        while (i <= 10)
//        {
//            i++;
//            Console.WriteLine($"Thread 1 : {i}");
//        }
//    }

//});


//Thread thread2 = new(() =>
//{
//    lock (locking)
//    {
//        while (i > 0)
//        {
//            i--;
//            Console.WriteLine($"Thread 2 : {i}");
//        }
//    }

//});

//thread1.Start();
//thread2.Start();

#endregion

#region Sleep

//Thread thread = new(() =>
//{
//    for (int i = 0; i < 10; i++)
//    {
//        Console.WriteLine(i);
//        Thread.Sleep(1000);
//    }
//});

//thread.Start(); 

#endregion

#region Join

//Thread thread1 = new(() =>
//{
//    for (int i = 0; i < 10; i++)
//    {
//        Console.WriteLine($"Thread1 {i}");
//    }
//});

//Thread thread2 = new(() =>
//{
//    for (int i = 0; i < 10; i++)
//    {
//        Console.WriteLine($"Thread2 {i}");
//    }
//});

//thread1.Start();
//thread1.Join();
//thread2.Start();

//join metodu kullanılan thread bitene kadar main thread dahil tüm threadler beklerler.

#endregion

#region Thread İptal Etme

//bool stop = false;
//Thread thread = new(() =>
//{
//    while (true)
//    {
//        if (stop) break;
//        Console.WriteLine("sdlkjsafd");
//    }

//    Console.WriteLine("görev tamamlandı");
//});

//thread.Start();
//Thread.Sleep(3000);
//stop = true;

#endregion

#region Cancellation Token İle Thread İptal Etme

//Thread thread = new((cancellationToken) =>
//{
//    var cancel = (CancellationTokenSource)cancellationToken;
//    while (true)
//    {
//        if (cancel.IsCancellationRequested) break;
//        Console.WriteLine("sdlkjsafd");
//    }

//    Console.WriteLine("görev tamamlandı");
//});

//CancellationTokenSource cancellationToken = new();

//thread.Start(cancellationToken);
//Thread.Sleep(3000);
//cancellationToken.Cancel();
#endregion

#region Interrupt Metodu

Thread thread = new((cancellationToken) =>
{

    try
    {
        Thread.Sleep(Timeout.Infinite);
    }
    catch (ThreadInterruptedException ex)
	{

        Console.WriteLine("hata alındı");
    }
});

thread.Start();
thread.Interrupt();

#endregion



Console.WriteLine("bitti");