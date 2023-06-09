using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // создание очереди
        Queue myQueue = new Queue();

        // добавление элементов
        myQueue.Enqueue("John");
        myQueue.Enqueue("Jane");
        myQueue.Enqueue("Bob");

        // удаление элемента
        object dequeuedItem = myQueue.Dequeue();

        Console.WriteLine("dequeuedItem: {0}", dequeuedItem);

        // просмотр элемента в начале очереди, без удаления
        object peekedItem = myQueue.Peek();

        Console.WriteLine("peekedItem: {0}", peekedItem);

        // перебор элементов очереди
        foreach (object item in myQueue)
        {
            Console.WriteLine(item);
        }

        Console.ReadLine();
    }
}