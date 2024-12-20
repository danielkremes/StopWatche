Menu();

static void Menu () {

    Console.WriteLine("S (second) 10 second = 10S");
    Console.WriteLine("M (minute) 10 minute = 10M");
    Console.WriteLine("0 (quit)");
    Console.WriteLine("Timer wished");

    // ToLower =  converted to low case time wished
    var timerWished = Console.ReadLine()?.ToLower();

    // Get last character in string
    // in this case the last character is the option
    // Command bellow give the last character in list
    // Substring(timerWished.Length - 1, 1);
    char option = Char.Parse(timerWished.Substring(timerWished.Length - 1, 1));
    Console.WriteLine($"option wished {option}");
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


