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
            var Ekaterinburg = new Ekaterinburg(4106235);
            var Munhen = new Munhen(1234567);
            var Leon = new Leon(1326546);



            Console.WriteLine("Сравнение населения 3 столиц:");
            Console.WriteLine($"Москва, Россия: {Moscow.Population} человек");
            Console.WriteLine($"Берлин, Германия: {Berlin.Population} человек");
            Console.WriteLine($"Екатеринбург, Россия: {Ekaterinburg.Population} человек");
            Console.WriteLine($"Леон, Франция: {Leon.Population} человек");
            Console.WriteLine($"Мюнхен, Германия: {Munhen.Population} человек");

            Console.WriteLine($"Население Страны Россия: {Moscow.Population + Ekaterinburg.Population}");
            Console.WriteLine($"Население Страны Германия: {Berlin.Population + Munhen.Population}");
            Console.WriteLine($"Население Страны Франция: {Leon.Population + Paris.Population}");






        }
    }
}
