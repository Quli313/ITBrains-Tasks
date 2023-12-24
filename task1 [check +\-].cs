
//IT Brains
// Ali Guliyev (check positive or negative or zero)

internal class Program
{
    private static void Main(string[] args)
    {
        int a = 23; //variable
        

        if (a == 0)
        {
            Console.WriteLine("Bu ədəd 0-a bərabərdir. Nə müsbət, nə də mənfidir!");
            
        }
        else if (a % 2 == 0)
        {
            Console.WriteLine("Bu ədəd cütdür...");
       
        }
        else
        {
            Console.WriteLine("Bu ədəd təkdir...");
            
        }
    }
}
