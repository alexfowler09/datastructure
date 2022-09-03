namespace Lists
{
    public class Node<T> 
        where T : struct
    {
        public T Element { get; set; }
        public Node<T>? Next { get; set; }

        public Node(T element, Node<T>? next)
        {
            Element = element;
            Next = next;
        }

        public static Node<T> CreateNodeWithAutoReference(T element)
        {
            var node = new Node<T>(element, null);
            node.Next = node;

            return node;
        }
    }
}
