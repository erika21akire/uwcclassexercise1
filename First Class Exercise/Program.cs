using System.Reflection.Metadata.Ecma335;

namespace First_Class_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string reversedString = Reverse(Console.ReadLine()); 
            //Console.WriteLine("Output: " + reversedString);
            bool forwardBackwardResult = IsSameForwardsAndBackwards(Console.ReadLine());
        }

        static bool IsSameForwardsAndBackwards(string FrontBackText)
        {
            string reverse = String.Empty;
            for (int i = FrontBackText.Length - 1; i > -1; i--)
            { reverse += FrontBackText[i]; }
            if (FrontBackText == reverse)
            { Console.WriteLine("True"); }
            else { Console.WriteLine("False"); }
            return false;
        }
    }
}
