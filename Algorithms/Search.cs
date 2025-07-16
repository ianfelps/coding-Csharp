namespace Algorithms
{
    public class Search
    {
        // Function to find a value in a sorted array using linear search
        public static bool LinearSearch(int[] list, int value)
        {
            for (int i = 0; i < list.Length; i++) // Iterate through each element in the array
            {
            if (list[i] == value) // Check if the current element matches the target value
            {
                return true; // Value found
            }
            }
            return false; // Value not found
        }

        // Function to find a value in a sorted array using binary search
        public static bool BinarySearch(int[] list, int value, int start, int end)
        {
            // Base case: if start index exceeds end index, value is not found
            if (start > end)
            {
                return false;
            }

            int mid = (start + end) / 2; // Find the middle index

            if (list[mid] == value) // Check if the middle element matches the target value
            {
                return true; // Value found
            }
            else if (list[mid] < value) // If target value is greater, search right half
            {
                return BinarySearch(list, value, mid + 1, end);
            }
            else // If target value is smaller, search left half
            {
                return BinarySearch(list, value, start, mid - 1);
            }
        }
    }
}