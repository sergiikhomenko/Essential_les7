namespace task4;
/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
 * Створіть структуру з ім'ям – Notebook. Поля структури: модель, виробник, вартість.
 * У структурі має бути реалізований конструктор для ініціалізації полів та метод для
 * виведення вмісту полів на екран.
 */
public struct Notebook
{
    private string _model;
    private string _manufactor;
    private double _price;

    public Notebook (string model, string manufactor, double price)
    {
        _model = model;
        _manufactor = manufactor;
        _price = price;
    }

    public void ShowInform()
    {
        Console.WriteLine($"Модель: {this._model}");
        Console.WriteLine($"Виробник: {this._manufactor}");
        Console.WriteLine($"Ціна {this._price:F2} UAH");
    }
}