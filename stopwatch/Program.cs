Start();

static void Start()
{
    int timer = 10;
    int currentTime = 0;

    while (currentTime != timer)
    {   
        Console.Clear();
        currentTime++;
        Console.WriteLine("Timer: " + currentTime);
        Thread.Sleep(1000);
    }
}


