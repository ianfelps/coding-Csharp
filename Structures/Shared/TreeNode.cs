namespace Structures.Shared
{
    // Node structure for Binary Tree
    public class TreeNode<T>
    {
        public T Value { get; set; } // Node value
        public Node<T>? Left { get; set; } // Left child node (optional)
        public Node<T>? Right { get; set; } // Right child node (optional)

        public TreeNode(T value) // Constructor
        {
            Value = value; // Set value
            Left = null; // Set left child node to null
            Right = null; // Set right child node to null
        }
    }
}