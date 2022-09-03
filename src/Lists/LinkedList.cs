namespace Lists
{
    public sealed class LinkedList<T>  : BaseLinkedList<T>
        where T : struct
    {
        public override void Add(T element) 
        {
            var node = new Node<T>(element, null);
            
            if (IsEmpty())
                Head = node;
            else
                Tail!.Next = node;
            
            Tail = node;
            Lenght++;
        }

        public override void AddLeading(T element)
        {
            var node = new Node<T>(element, null);

            if (IsEmpty())
                Tail = node;            
            else            
                node.Next = Head;

            Head = node;
            Lenght++;
        }

        public override void Add(T element, int position)
        {
            if (position > (Lenght - 1))
                throw new IndexOutOfRangeException();

            var itsLastPosition = position == (Lenght - 1);

            var newNode = new Node<T>(element, null);

            Node<T> nodeBeforePosition;

            if (position == 0)
            {
                nodeBeforePosition = GetNode(0);
                newNode.Next = nodeBeforePosition;
                Head = newNode;
            }
            else
            {
                nodeBeforePosition = GetNode(position - 1);
                newNode.Next = nodeBeforePosition.Next;
                nodeBeforePosition.Next = newNode;
            }
     
            Lenght++;

            if (itsLastPosition)
                Tail = newNode.Next;
        }

        public override void Remove(int position)
        {
            if (IsEmpty() || (position > (Lenght - 1)))
                throw new IndexOutOfRangeException();

            var nodeToDelete = GetNode(position);            
            
            if (position > 0)
            {
                var nodeBeforePosition = GetNode(position - 1);
                nodeBeforePosition.Next = nodeToDelete.Next;                

                if (Tail == nodeToDelete)                
                    Tail = nodeBeforePosition;

                if (Head == nodeToDelete)
                    Head = nodeBeforePosition;
            }
            else if (position == 0)
            {
                if (Lenght > 1)                
                    Head = nodeToDelete.Next;                                    
                else
                {
                    Head = null;
                    Tail = null;
                }
            }

            Lenght--;
        }

        public override int Search(T element)
        {
            var index = 0;
            var actualNode = Head;
            while (actualNode != null)
            {
                if (actualNode.Element.Equals(element))
                    return index;

                actualNode = actualNode.Next;
                index++;
            }

            return -1;
        }

        public void Display()
        {
            var actualNode = Head;
            while (actualNode != null)
            {
                Console.WriteLine($"{actualNode.Element} --> ");
                actualNode = actualNode.Next;
            }
        }        
    }
}
