Menu();

static void Menu () {

    Console.WriteLine("S (second)");
    Console.WriteLine("M (minute)");
    Console.WriteLine("0 (quit)");
    Console.WriteLine("Timer wished");

    // Start(10);
}

static void Start(int timer)
{
    
    int currentTime = 0;

    while (currentTime != timer)
    {   
        Console.Clear();
        currentTime++;
        Console.WriteLine("Timer: " + currentTime);
        Thread.Sleep(1000);
    }
    Console.Clear();
    Thread.Sleep(1500);
    Console.WriteLine("Time over");
    Menu();
}


