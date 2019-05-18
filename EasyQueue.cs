using System;
using System.Collections.Generic;
using System.Linq;

namespace QueueAndDeque {
    class EasyQueue<T> {
        private List<T> items = new List<T>();
        private T head => items.Last();
        private T tail => items.First();
        public int Count => items.Count;

        public EasyQueue() {}
        public EasyQueue(T data) {
            items.Add(data);
        }

        public void Enqueue(T data) {
            items.Insert(0, data);
        }
        public  T Dequeue() {
            var item = head;
            items.Remove(item);
            return item;
        }
        public T Peak() {
            return head;
        }

    }
}
