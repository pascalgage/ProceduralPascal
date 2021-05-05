using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionAetB
{
    public class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;


            //saisie des entrées
            Console.WriteLine("Entrez une valeur pour a :");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Entrez une valeur pour b :");
            b = double.Parse(Console.ReadLine());

            //traitement
            Inversion(ref a, ref b);

            //Affichage du résultat
            Console.WriteLine("a est égal à:" + a);
            Console.WriteLine("b est égal à:" + b);

            Console.ReadKey();
        }
        public static void Inversion(ref double _a,ref double _b)
        {
            double temp;
            temp = _a;
            _a = _b;
            _b = temp;
        }
    }
}
