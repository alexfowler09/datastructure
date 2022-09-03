namespace Lists.Interfaces
{
    public interface ILinkedList<T> 
        where T : struct
    {
        public Node<T>? Head { get; }
        public Node<T>? Tail { get; }
        public int Lenght { get; }

        public bool IsEmpty();
        void Add(T element);
        void AddLeading(T element);
        void Add(T element, int position);
        Node<T> GetNode(int position);
        void Remove(int position);
        int Search(T element);
    }
}
