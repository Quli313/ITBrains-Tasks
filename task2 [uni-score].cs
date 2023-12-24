//IT Brains
// Ali Guliyev (University Score)

internal class Program
{
    private static void Main(string[] args)
    { 
        double score = 70.999999;

        if (score >= 51 && score < 61)
        {
            Console.WriteLine("F :(");
        }
        else if (score >= 61 && score < 71)
        {
            Console.WriteLine("D");
        }
        else if (score >= 71 && score < 81)
        {
            Console.WriteLine("C");
        }
        else if (score >= 81 && score < 91)
        {
            Console.WriteLine("B");
        }
        else if (score >= 91 && score <= 100)
        {
            Console.WriteLine("A");
        }
        else
        {
            Console.WriteLine("Qiymət düzgün daxil edilməyib");
        }
    }
}
