using System.Runtime.CompilerServices;

namespace task2;

/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
 * Потрібно: Описати структуру з ім'ям Train, що містить такі поля: назву пункту
 * призначення, номер поїзда, час відправлення.
 * Написати програму, яка виконує такі дії:
 * введення з клавіатури даних до масиву,що складається з восьми
 * елементів типу Train (записи мають бути впорядковані за номерами поїздів);
 * виведення на екран інформації про поїзд, номер якого введено з клавіатури
 * (якщо таких поїздів немає, вивести відповідне повідомлення).
 */

public struct Train
{
    private string _destination;
    private int _nomberTrain;
    private DateTime _time;
    private Train[] _arreyTrains;

  public static void  SerchTrain (int nomberTrain, Train[] arreyTrains)
  {
          bool result = false;
          for (int i = 0; i < arreyTrains.Length; i++)
          {
              if (arreyTrains[i]._nomberTrain == nomberTrain)
              {
                  result = true;
                  Console.WriteLine($"Номер потягу: {arreyTrains[i]._nomberTrain}");
                  Console.WriteLine($"Пункт призначення: {arreyTrains[i]._destination}");
                  Console.WriteLine($"Час відправлення: {arreyTrains[i]._time.Hour}:{arreyTrains[i]._time.Minute}");
              }
          }
          if(!result)
          {
              Console.WriteLine("Нічого не знайдено");
          }
  }

  public Train(string destination, int nomberTrain, DateTime time)
    {
        _destination = destination;
        _nomberTrain = nomberTrain;
        _time = time;
    }
  
    
}

