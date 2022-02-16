
namespace Lab1
{
    static class Programm
    {
        static void Main()
        {
            var F1 = new Models.ConstantFunction();
            var F2 = new Models.ConstantFunction();
            System.Console.WriteLine(F1.Equals(F2));
        }
    }
}