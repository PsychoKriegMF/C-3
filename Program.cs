using Russia;
using France;
using Germany;
namespace C_3
{
    internal class Program
    {
        struct Name
        {
            public Name(string name) { }
        }
        static void Main(string[] args)
        {
            //int a = 3; int b;
            //Class cl = new Class();
            //cl.Method3(ref a, out b);
            //Console.WriteLine(b);

            //cl.Asd2 = "asd2";
            //Console.WriteLine(cl.Asd2);



            // Задача про столицы

            var Moscow = new Moscow(13149803);
            var Berlin = new Berlin(33611222);
            var Paris = new Paris(2102650);

            Console.WriteLine("Сравнение населения 3 столиц:");
            Console.WriteLine($"Москва, Россия: {Moscow.Population} человек");
            Console.WriteLine($"Берлин, Германия: {Berlin.Population} человек");
            Console.WriteLine($"Париж, Франция: {Paris.Population} человек");





        }
    }
}
