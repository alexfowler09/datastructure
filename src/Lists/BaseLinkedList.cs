using Lists.Interfaces;

namespace Lists
{
    public abstract class BaseLinkedList<T> : ILinkedList<T>
        where T : struct
    {
        public Node<T>? Head { get; protected set; } = null;
        public Node<T>? Tail { get; protected set; } = null;
        public int Lenght { get; protected set; }

        public bool IsEmpty() =>
            Lenght == 0 && Head == null && Tail == null;

        public Node<T> GetNode(int position)
        {
            if (position > (Lenght - 1))
                throw new IndexOutOfRangeException();

            Node<T> node = Head!;

            int i = 0;
            while (i < position)
            {
                node = node.Next!;
                i++;
            }

            return node;
        }

        public abstract void Add(T element);
        public abstract void Add(T element, int position);        
        public abstract void AddLeading(T element);        
        public abstract void Remove(int position);
        public abstract int Search(T element);        
    }
}
