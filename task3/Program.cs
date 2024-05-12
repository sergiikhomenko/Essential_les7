namespace task3;
/*
 * Створіть клас MyClass і структуру MyStruct, які містять поля public string change.
 * У класі Program створіть два методи:
 * 
 * static void ClassTaker(MyClass myClass),який надає полю change екземпляра myClass значення «змінено».
 * 
 * static void StruktTaker(MyStruct myStruct), який надає полю change екземпляра myStruct значення «змінено».
 * Продемонструйте різницю у використанні
 * класів та структур, створивши у методі Main() екземпляри структури та класу.
 * Змініть значення полів екземплярів на «не змінено»,
 * а потім викличте методи ClassTaker і StruktTaker.
 * Виведіть на екран значення полів екземплярів. Проаналізуйте отримані результати.
 */
class Program
{
    static void Main(string[] args)
    {
        MyClass myClass = new MyClass();
        MyStruct myStruct = new MyStruct();

        myClass.change = "не змінено";
        myStruct.change = "не змінено";

        Console.WriteLine($"{myClass.change}");
        Console.WriteLine($"{myStruct.change}");
        
        ClassTaker(myClass);
        StruktTaker(myStruct);
        Console.WriteLine("Після зміни");
        Console.WriteLine($"{myClass.change}");
        Console.WriteLine($"{myStruct.change}");
    }

    static void ClassTaker(MyClass myClass)
    {
        myClass.change = "змінено";
    }

    static void StruktTaker(MyStruct myStruct)
    {
        myStruct.change = "змінено";
    }
}