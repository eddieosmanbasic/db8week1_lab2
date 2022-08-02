Console.WriteLine("Welcome! Please enter your name.");
string name = Console.ReadLine();
bool breakFlag = false;
do
{
    Console.WriteLine($"{name}, Please enter an integer between 1 and 100.");
    int entry = int.Parse(Console.ReadLine());
   
    while (!breakFlag && entry > 0 && entry < 100)
    {
        if (entry % 2 != 0 && entry < 60)
        {
            Console.WriteLine($"{name}, the number you entered is odd and less than 60.");
        }
        else if (entry % 2 == 0 && entry >= 2 && entry <= 24)
        {
            Console.WriteLine($"{name}, the number you entered is even and less than 25.");
        }
        else if (entry % 2 == 0 && entry >= 26 && entry <= 60)
        {
            Console.WriteLine($"{name}, the number you entered is even and between 26 and 60 inclusive.");
        }
        else if (entry % 2 == 0 && entry > 60)
        {
            Console.WriteLine($"{name}, the number you entered is even and greater than 60.");
        }
        else if (entry % 2 != 0 && entry > 60)
        {
            Console.WriteLine($"{name}, the number you entered is odd and greater than 60.");
        }
        Console.WriteLine($"{name}, would you like to enter another number? Please enter yes or no.");
        string answer = Console.ReadLine();
        if (answer != "yes")
        {
            breakFlag = true;
            break;
        }
        else
        {
            entry = 0;
        }
        break;

    }

    
    

} while (!breakFlag);


