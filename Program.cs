using System;

namespace PM02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Магазин");

            // Создаём товар и заполняем его данные.
            Tovar hleb = new Tovar();
            hleb.Nazvanie = "Хлеб";
            hleb.Cena = 45;

            hleb.Pokazat();

            // Получаем количество.
            Console.WriteLine("Сколько единиц купить?");
            int kolvo;

            if (!int.TryParse(Console.ReadLine(), out kolvo))
            {
                Console.WriteLine("Нужно ввести целое число");
                Console.ReadLine();
                return;
            }

            if (kolvo <= 0)
            {
                Console.WriteLine("Количество должно быть больше нуля");
                Console.ReadLine();
                return;
            }

            // Считаем стоимость. long позволяет вместить большую сумму.
            long summa = (long)hleb.Cena * kolvo;

            Console.WriteLine($"Количество: {kolvo}");
            Console.WriteLine($"К оплате: {summa} рублей");

            Console.ReadLine();
        }
    }

    internal class Tovar
    {
        public string Nazvanie { get; set; }
        public int Cena { get; set; }

        public void Pokazat()
        {
            Console.WriteLine($"Товар: {Nazvanie}");
            Console.WriteLine($"Цена: {Cena} рублей");
        }
    }
}