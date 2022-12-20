using SolutionCarwah.Entities;

namespace SolutionCarwah
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carwash carwash = new Carwash();
            carwash.Traiter(new Voiture("1-ABC-001"));
            carwash.Traiter(new Voiture("1-DEF-002"));
        }
    }
}