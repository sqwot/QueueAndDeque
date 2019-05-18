using System;

namespace QueueAndDeque {
    class Program {
        static void Main() {
            var easyQueue = new EasyQueue<int>();
            easyQueue.Enqueue(1);
            easyQueue.Enqueue(2);
            easyQueue.Enqueue(3);
            easyQueue.Enqueue(4);
            easyQueue.Enqueue(5);

            Console.WriteLine(easyQueue.Dequeue());
            Console.WriteLine(easyQueue.Peak());
            Console.WriteLine(easyQueue.Dequeue());

            Console.ReadKey();

            var arrayQueue = new ArrayQueue<int>(5);
            arrayQueue.Enqueue(6);
            arrayQueue.Enqueue(7);
            arrayQueue.Enqueue(8);
            arrayQueue.Enqueue(9);
            arrayQueue.Enqueue(10);

            Console.WriteLine(arrayQueue.Dequeue());
            Console.WriteLine(arrayQueue.Peak());
            Console.WriteLine(arrayQueue.Dequeue());
            Console.WriteLine(arrayQueue.Dequeue());
            Console.WriteLine(arrayQueue.Dequeue());
            Console.WriteLine(arrayQueue.Dequeue());
            Console.WriteLine(arrayQueue.Dequeue());

            Console.ReadKey();
            Console.WriteLine();

            var linkedQueue = new LinkedQueue<int>();
            linkedQueue.Enqueue(11);
            linkedQueue.Enqueue(12);
            linkedQueue.Enqueue(13);
            linkedQueue.Enqueue(14);
            linkedQueue.Enqueue(15);

            Console.WriteLine(linkedQueue.Dequeue());
            Console.WriteLine(linkedQueue.Peak());
            Console.WriteLine(linkedQueue.Dequeue());


            Console.ReadKey();

            Console.WriteLine();

            var easyDeque = new EasyDeque<int>();
            easyDeque.PushBack(10);
            easyDeque.PushBack(20);
            easyDeque.PushBack(30);
            easyDeque.PushBack(40);
            easyDeque.PushBack(50);
            easyDeque.PushFront(9);
            easyDeque.PushFront(8);

            Console.WriteLine(easyDeque.PeekBack());
            Console.WriteLine(easyDeque.PeekFront());
            Console.WriteLine(easyDeque.PopBack());
            Console.WriteLine(easyDeque.PopBack());
            Console.WriteLine(easyDeque.PopFront());
            Console.WriteLine(easyDeque.PopFront());


            Console.ReadKey();
            Console.WriteLine();

            var duplexLinkedDecue = new DuplexLinkedDeque<int>();
            duplexLinkedDecue.PushBack(100);
            duplexLinkedDecue.PushBack(200);
            duplexLinkedDecue.PushBack(300);
            duplexLinkedDecue.PushBack(400);
            duplexLinkedDecue.PushBack(500);
            duplexLinkedDecue.PushFront(90);
            duplexLinkedDecue.PushFront(80);

            Console.WriteLine(duplexLinkedDecue.PeekBack());
            Console.WriteLine(duplexLinkedDecue.PeekFront());
            Console.WriteLine(duplexLinkedDecue.PopBack());
            Console.WriteLine(duplexLinkedDecue.PopBack());
            Console.WriteLine(duplexLinkedDecue.PopFront());
            Console.WriteLine(duplexLinkedDecue.PopFront());


            Console.ReadKey();
        }
    }
}
