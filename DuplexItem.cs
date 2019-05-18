using System;


namespace QueueAndDeque {
    class DuplexItem<T> {
        public T Data { get; set; }
        public DuplexItem<T> Next { get; set; }
        public DuplexItem<T> Pevious { get; set; }

        public DuplexItem(T data) {
            this.Data = data;
        }
        public override string ToString() {
            return Data.ToString();
        }
    }
}
