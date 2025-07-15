namespace Structures.Shared
{
    // Node structure
    public class Node<T>
    {
        public T Value { get; set; } // Node value
        public Node<T>? Next { get; set; } // Next node (optional)

        public Node(T value) // Constructor
        {
            Value = value; // Set value
            Next = null; // Set next node to null
        }
    }
}