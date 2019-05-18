using System;


namespace QueueAndDeque {
    class DuplexLinkedDeque <T>{
        private DuplexItem<T> head;
        private DuplexItem<T> tail;
        public int Count { get; private set; }

        public DuplexLinkedDeque() { }
        public DuplexLinkedDeque(T data) {
            var item = new DuplexItem<T>(data);
            SetHeadItem(item);
        }

        public void PushBack(T data) {
            var item = new DuplexItem<T>(data);
            if (Count == 0) {
                SetHeadItem(item);
            } else {
                item.Next = tail;
                tail.Pevious = item;
                tail = item;
            }
            Count++;
        }
        public void PushFront(T data) {
            var item = new DuplexItem<T>(data);
            if (Count == 0) {
                SetHeadItem(item);
            } else {
                head.Next = item;
                item.Pevious = head;
                head = item;
                item.Next = null;
            }
            Count++;
        }

        public DuplexItem<T> PopBack() {
            if(Count > 0) {
                var result = tail;
                tail.Next.Pevious = null;
                tail = tail.Next;
                Count--;
                return result;
            } else {
                return default(DuplexItem<T>);
            }
            
        }
        public DuplexItem<T> PopFront() {
            if (Count > 0) {
                var result = head;
                head.Pevious.Next = null;
                head = head.Pevious;
                Count--;
                return result;
            } else {
                return default(DuplexItem<T>);
            }
        }
        public DuplexItem<T> PeekBack() {
            if (Count > 0) {
                return tail;
            } else {
                return default(DuplexItem<T>);
            }
        }
        public DuplexItem<T> PeekFront() {
            if (Count > 0) {
                return head;
            } else {
                return default(DuplexItem<T>);
            }
        }



        public void SetHeadItem(DuplexItem<T> item) {
            head = item;
            tail = item;
            Count = 1;
        }
    }
}
