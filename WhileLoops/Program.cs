Random  rnd = new Random();

int cpuRandom;

bool loopActive = true;
while (loopActive)
{
    cpuRandom = rnd.Next(1, 4);
   // Console.WriteLine($"cpu has generated {cpuRandom}");
    Console.WriteLine("Make a guess. Enter a number 1-3");
    int userNumber = Int32.Parse(Console.ReadLine());

    if (userNumber == cpuRandom)
    {
        Console.WriteLine("Congratz, you won!");
        //loopActive = false;
        break;
    }
    else
    {
        Console.WriteLine("oops. Try again.");
    }
}
Console.WriteLine("have a nice day");
