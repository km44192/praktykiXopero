using System;
using System.Collections.Generic;
using System.Text;

namespace Kolekcje
{
    class Kolejka
    {
        public Queue<string> myqueue = new Queue<string>();
        public Kolejka()
        {
            myqueue.Enqueue("pierwszy w kolejce");
            myqueue.Enqueue("drugi w kolejce");
            myqueue.Enqueue("trzeci w kolejce");
            myqueue.Enqueue("ostatni w kolejce");
            string takeAloog = myqueue.Peek();
            string getFirst = myqueue.Dequeue();
            string getNext = myqueue.Dequeue();
            int howMany = myqueue.Count;
            myqueue.Clear();
            Console.Write("Peak() zwróciło" + takeAloog + "\n" + "Pierwsze Dequeue() zwróciło:" + getFirst + "\n" + "Drugie Dequeue() zwróciło:" + getNext + "\n" + "Count przed clear zwróciło" + howMany + "\n" + "count po clear zwróciło: " + myqueue.Count+ "\n");
        }

    }
}
