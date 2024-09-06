using System.ComponentModel;

namespace LA_Auftrag_Eingabefeld_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie heissisch du?");
         string name = Console.ReadLine();


            
            Console.WriteLine("Kuhle Name");
            Console.WriteLine("Wie alt bisch du?");
            int age = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Grüezi " + name);
            Console.WriteLine("Du bisch also " + age + " Johr alt");

            Console.WriteLine("Und wo wonsch du?");
            string Wohnort = Console.ReadLine();
            Console.WriteLine("Ah döt bini au mol gsie");

            Console.WriteLine();
            
            Console.ReadKey();


        }
    }
}
