namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            float b = float.Parse(Console.ReadLine());

            
            Console.Write($"Какую операцию провести над числами?\n\t{a} \"операция\" {b}\n");
            Console.WriteLine("1. Сложение\n2. Вычитание\n3. Умножение\n4. Деление");
            int choise = Int32.Parse(Console.ReadLine());
            switch(choise)
            {
                case 1:
                    Console.WriteLine($"Сложение: {a} + {b} = {a + b}");
                    break;
                case 2:
                    Console.WriteLine($"Сложение: {a} - {b} = {a - b}");
                    break;
                case 3:
                    Console.WriteLine($"Умножение: {a} * {b} = {a * b}");
                    break;
                case 4:
                    if(b == 0)
                    {
                        Console.WriteLine("Второе число равно нулю! На ноль делить нельзя!");
                        break;
                    }
                    Console.WriteLine($"Деление: {a} / {b} = {a / b}");
                    break;
                default:
                    Console.WriteLine("Неправильный пункт меню!");
                    break;
            }
        }
    }
}
