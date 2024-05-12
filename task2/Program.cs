namespace task2;
/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
 * Потрібно: Описати структуру з ім'ям Train, що містить такі поля: назву пункту
 * призначення, номер поїзда, час відправлення. Написати програму, яка виконує
 * такі дії: введення з клавіатури даних до масиву, що складається з восьми
 * елементів типу Train (записи мають бути впорядковані за номерами поїздів);
 * виведення на екран інформації про поїзд, номер якого введено з клавіатури
 * (якщо таких поїздів немає, вивести відповідне повідомлення). 
 */
class Program
{
    static void Main(string[] args)
    {
        Train[] train = new Train[8];
        for (int i = 0; i < train.Length; i++)
        {
            Console.WriteLine("Пункт призначення");
            string destination = Console.ReadLine();
            
            Console.WriteLine($"Номер поїзду {i+1}");
            
            Console.WriteLine("Час відправлення");
            DateTime.TryParse(Console.ReadLine(), out DateTime time);
            
            train[i] = new  Train(destination,i+1,time);
            Console.WriteLine(new string('*',40));
        }

        Console.WriteLine("Введіть номер потягу для пошуку");
        Int32.TryParse(Console.ReadLine(), out int nomber);
        Train.SerchTrain(nomber,train);
        
        
    }
}