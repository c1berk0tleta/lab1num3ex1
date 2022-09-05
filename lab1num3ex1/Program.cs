
namespace lab1num3ex1
{
    class wordlength
    {
        static void Main() {

            string w1, w2, w3, w4;
            int k = 0;
            bool e = false;

            Console.WriteLine("Введие 1 слово");
            w1 = Console.ReadLine();
            Console.WriteLine("Введие 2 слово");
            w2 = Console.ReadLine();
            Console.WriteLine("Введие 3 слово");
            w3 = Console.ReadLine();
            Console.WriteLine("Введие 4 слово");
            w4 = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Список одинаковых слов:");

            if ((w1 == w2) || (w1 == w3) || (w1 == w4)) 
            {
                k = 1;
                Console.WriteLine(w1);
            }
            if ((w2 == w3) || (w2 == w4))
            {
                k = 1;
                Console.WriteLine(w2);
            }
            if (w3 == w4)
            {
                k = 1;
                Console.WriteLine(w3);
            }
            if (k == 0)
            {
                Console.WriteLine("Одинаковые слова отсутствуют");
            }
        }

    }
}