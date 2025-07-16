using Algorithms;

// Sort Algorithms
Console.WriteLine("\n===== Sort Algorithms =====");
int[] numbers = { 3, 2, 1, 5, 4 }; // Create a list of numbers
Console.WriteLine("List: " + string.Join(", ", numbers)); // Print the original list

Console.WriteLine("=== Quick Sort ===");
Sort.QuickSort(numbers, 0, numbers.Length - 1); // Sort the list with quick sort
Console.WriteLine("Ordered List: " + string.Join(", ", numbers)); // Print the ordered list

Console.WriteLine("=== Bubble Sort ===");
numbers = new int[] { 3, 2, 1, 5, 4 };
Sort.BubbleSort(numbers); // Sort the list with bubble sort
Console.WriteLine("Ordered List: " + string.Join(", ", numbers)); // Print the ordered list

// Search Algorithms
Console.WriteLine("\n===== Search Algorithms =====");
numbers = new int[] {3, 8, 1, 7, 5, 2, 6, 4, 9, 10};
Console.WriteLine("List: " + string.Join(", ", numbers)); // Print the original list
Sort.BubbleSort(numbers); // Sort the list with bubble sort
Console.WriteLine("Ordered List: " + string.Join(", ", numbers)); // Print the ordered list

Console.WriteLine("=== Linear Search ===");
Console.WriteLine("Search for 5: " + Search.LinearSearch(numbers, 5)); // Search for 5 with linear search
Console.WriteLine("Search for 12: " + Search.LinearSearch(numbers, 12)); // Search for 12 with linear search

Console.WriteLine("=== Binary Search ===");
Console.WriteLine("Search for 5: " + Search.BinarySearch(numbers, 5, 0, numbers.Length - 1)); // Search for 5 with binary search
Console.WriteLine("Search for 12: " + Search.BinarySearch(numbers, 12, 0, numbers.Length - 1)); // Search for 12 with binary search