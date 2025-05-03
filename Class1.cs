using System;

namespace SearchAlgorithms
{
    public static class Search
    {
        // Realiza una búsqueda lineal en un arreglo.
        public static int LinearSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }

        // Realiza una búsqueda binaria en un arreglo ordenado.
        public static int BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                {
                    return mid;
                }

                if (arr[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }

        // Implementación recursiva de búsqueda binaria (alternativa)
        public static int BinarySearchRecursive(int[] arr, int target, int left, int right)
        {
            if (left > right)
            {
                return -1;
            }

            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
            {
                return mid;
            }

            if (arr[mid] > target)
            {
                return BinarySearchRecursive(arr, target, left, mid - 1);
            }

            return BinarySearchRecursive(arr, target, mid + 1, right);
        }

        // Método auxiliar para la búsqueda binaria recursiva
        public static int BinarySearchRecursive(int[] arr, int target)
        {
            return BinarySearchRecursive(arr, target, 0, arr.Length - 1);
        }
    }
}