namespace Lists
{
    public sealed class CircularLinkedList<T> : BaseLinkedList<T>
        where T : struct
    {
        public override void Add(T element)
        {
            var node = new Node<T>(element, null);

            if (IsEmpty())
            {
                Head = node;                
                node.Next = node;
            }
            else
            {
                node.Next = Tail!.Next;
                Tail.Next = node;                                
            }

            Tail = node;
            Lenght++;
        }

        public override void Add(T element, int position)
        {
            throw new NotImplementedException();
        }

        public override void AddLeading(T element)
        {
            throw new NotImplementedException();
        }

        public override void Remove(int position)
        {
            throw new NotImplementedException();
        }

        public override int Search(T element)
        {
            throw new NotImplementedException();
        }
    }
}
