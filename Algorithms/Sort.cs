namespace Algorithms
{
    public class Sort
    {
        // Function to swap two elements in an array
        static void Swap(int[] arr, int i, int j)
        {
            (arr[i], arr[j]) = (arr[j], arr[i]);
        }

        // Function to sort an array using the bubble sort algorithm
        public static void BubbleSort(int[] list)
        {
            int n = list.Length; // Size of list
            bool swapped; // Flag for optimization

            for (int i = 0; i < n - 1; i++) // Outer loop for each pass through the list
            {
                swapped = false; // Reset the flag
                for (int j = 0; j < n - i - 1; j++) // Inner loop for comparing adjacent elements
                {
                    if (list[j] > list[j + 1]) // If the current element is greater than the next
                    {
                        Swap(list, j, j + 1); // Swap the elements
                        swapped = true; // Set the flag
                    }
                }
                if (!swapped) // If no swaps were made, the list is already sorted
                {
                    break; // Exit the loop
                }
            }
        }

        // Function to find the partition position for quick sort
        static int Partition(int[] list, int low, int high)
        {
            int pivot = list[high]; // Choose the last element as pivot
            int i = low - 1; // Index of smaller element

            for (int j = low; j <= high - 1; j++) // Iterate through all elements
            {
                if (list[j] < pivot) // If current element is smaller than pivot
                {
                    i++; // Increment index of smaller element
                    Swap(list, i, j); // Swap current element with the element at i
                }
            }

            Swap(list, i + 1, high); // Place pivot in the correct position
            return i + 1; // Return the partition index
        }
        
        // Function to sort an array using the quick sort algorithm
        public static void QuickSort(int[] list, int low, int high)
        {
            if (low < high) // If there are at least two elements to sort
            {
                int pi = Partition(list, low, high); // Partition the array
                // Recursively sort elements before and after partition
                QuickSort(list, low, pi - 1);
                QuickSort(list, pi + 1, high);
            }
        }
    }
}