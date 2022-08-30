namespace Lists
{
    public class LinkedList<T> 
        where T : struct
    {
        private Node<T>? head = null;
        private Node<T>? tail = null;

        public int Lenght { get; private set; }        

        public LinkedList()
        {

        }

        public bool IsEmpty() =>
            Lenght == 0;

        public void AddLast(T element) 
        {
            var node = new Node<T>(element, null);
            
            if (IsEmpty())
                head = node;
            else
                tail!.Next = node;
            
            tail = node;
            Lenght++;
        }

        public void AddLeading(T element)
        {
            var node = new Node<T>(element, null);

            if (IsEmpty())
                tail = node;            
            else            
                node.Next = head;

            head = node;
            Lenght++;
        }

        public void AddElement(T element, int position)
        {
            if (position > (Lenght - 1))
                throw new IndexOutOfRangeException();

            var newNode = new Node<T>(element, null);

            Node<T> nodeBeforePosition;

            if (Lenght == 1)
                nodeBeforePosition = GetNode(0);
            else
                nodeBeforePosition = GetNode(position - 1);

            newNode.Next = nodeBeforePosition.Next;
            nodeBeforePosition.Next = newNode;
            Lenght++;
        }

        public Node<T> GetNode(int position)
        {
            if (position > (Lenght - 1))
                throw new IndexOutOfRangeException();

            Node<T> node = head!;

            int i = 0;            
            while (i < position)
            {
                node = node.Next!; 
                i++;
            }

            return node;
        }

        public void Display()
        {
            Node<T>? actualNode = head;
            while (actualNode != null)
            {
                Console.WriteLine($"{actualNode.Element} --> ");
                actualNode = actualNode.Next;
            }
        }
    }
}
