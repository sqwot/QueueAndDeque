using System;


namespace QueueAndDeque {
    class Item<T> {
        public T Data { get; set; }
        public Item<T> Next { get;set; }

        public Item(T data) {
            this.Data = data;
        }
        public override string ToString() {
            return Data.ToString();
        }
    }
}
