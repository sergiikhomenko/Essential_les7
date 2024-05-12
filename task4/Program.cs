namespace task4;
/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
 * Створіть структуру з ім'ям – Notebook. Поля структури: модель, виробник, вартість.
 * У структурі має бути реалізований конструктор для ініціалізації полів та метод для
 * виведення вмісту полів на екран.
 */
class Program
{
    static void Main(string[] args)
    {
        string model, manufactor;
        double price;
        
        Console.WriteLine("Введіть модель ноутбуку");
        model = Console.ReadLine();
        
        Console.WriteLine("Введіть  виробника");
        manufactor = Console.ReadLine();
        
        Console.WriteLine("Введіть ціну");
        Double.TryParse(Console.ReadLine(), out price);

        Notebook notebook = new Notebook(model, manufactor, price);

        Console.WriteLine(new string('*',40));
        notebook.ShowInform();

    }
}