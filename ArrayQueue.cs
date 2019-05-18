using System;
using System.Linq;

namespace QueueAndDeque {
    class ArrayQueue<T> {
        private T[] items;
        private T head => items[Count>0? Count - 1 : 0];
        private T tail => items[0];
        private int maxCount => items.Length;
        public int Count { get; private set; }

        public ArrayQueue(int size) {
            items = new T[size];
            Count = 0;
        }
        public ArrayQueue(int size, T data) {
            items = new T[size];
            items[0] = data;
            Count = 1;
        }

        public void Enqueue(T data) {
            if (Count < maxCount) {
                var result = (new T[] { data }).Concat(items);
                items = result.ToArray();
                Count++;
            }
            
            //if (Count < maxCount) {
            //    var result = new T[maxCount];
            //    result[0] = data;
            //    for (int i = 0; i < Count; i++) {
            //        result[i + 1] = items[i];
            //    }
            //    items = result;
            //    Count++;
            //}
        }
        public T Dequeue() {
            var item = head;
            Count--;
            return item;
        }
        public T Peak() {
            return head;
        }

    }
}
