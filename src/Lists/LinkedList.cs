namespace Lists
{
    public class LinkedList<T> 
        where T : struct
    {
        public Node<T>? Head { get; private set; } = null;
        public Node<T>? Tail { get; private set; } = null;

        public int Lenght { get; private set; }        

        public LinkedList()
        {
        }

        public bool IsEmpty() =>
            Lenght == 0 && Head == null && Tail == null;

        public void Add(T element) 
        {
            var node = new Node<T>(element, null);
            
            if (IsEmpty())
                Head = node;
            else
                Tail!.Next = node;
            
            Tail = node;
            Lenght++;
        }

        public void AddLeading(T element)
        {
            var node = new Node<T>(element, null);

            if (IsEmpty())
                Tail = node;            
            else            
                node.Next = Head;

            Head = node;
            Lenght++;
        }

        public void Add(T element, int position)
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

        public void Remove(int position)
        {
            if (IsEmpty() || (position > (Lenght -1)))
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

        public void Display()
        {
            Node<T>? actualNode = Head;
            while (actualNode != null)
            {
                Console.WriteLine($"{actualNode.Element} --> ");
                actualNode = actualNode.Next;
            }
        }
    }
}
