using System;


namespace QueueAndDeque {
    class LinkedQueue<T> {
        private Item<T> head;
        private Item<T> tail;
        public int Count { get; private set; }

        public LinkedQueue() { }
        public LinkedQueue(T data) {
            var item = new Item<T>(data);
            SetHeadItem(item);
        }

        public void Enqueue(T data) {
            var item = new Item<T>(data);
            if (Count == 0) {
                SetHeadItem(item);
            } else {
                item.Next = tail;
                tail = item;
            }
            Count++;
        }
        public T Dequeue() {
            if(Count > 0) {
                var data = head.Data;
                var current = tail.Next;
                var previous = tail;
                while(current != null && current.Next != null) {
                    previous = current;
                    current = current.Next;
                }
                head = previous;
                head.Next = null;
                Count--;
                return data;
            }else {
                throw new NullReferenceException("Queue is empty");
            }
        }
        public T Peak() {
            return head.Data;
        }
        public void SetHeadItem(Item<T> item) {
            head = item;
            tail = item;
            Count = 1;
        }
    }
}
