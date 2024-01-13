using System.IO;
using System;

class Program
{
    //Function for the first array exercise
    static void MaxandMinElements(int[] numbers)
    {
        int max = numbers[0];
        int min = numbers[0];

        for(int i = 0; i < numbers.Length; i++) {
            if (numbers[i] > max) {
                max = numbers[i];
            }
            if (numbers[i] < min) {
                min = numbers[i];
            }
        }
        Console.WriteLine("Max number of given array is " + max);
        Console.WriteLine("Min number of given array is " + min);
    }

    //Functions for the second array exercise
    static int[] ReverseArray(int[] numbers)
    {
        int start = 0;
        int end = numbers.Length - 1;
        while (start < end) {
            int temp = numbers[start];
            numbers[start] = numbers[end];
            numbers[end] = temp; //swapping two variables, using another empty one
            start++;
            end--;
        }
        return numbers;

    }
    static void PrintArray(int[] numbers)
    {
        for(int i = 0; i < numbers.Length; i++) {
            Console.Write(numbers[i] + " ");
        }
    }

    //Third exercise function
    static int secondLargest(int[] numbers)
    {
        int second = 0;
        int largest = 0;
        foreach (int i in numbers) {
            if (i > largest) {
                second = largest;
                largest = i;
            } else if (i > second)
                second = i;
        }
        
        return second;
    }
    //Last exercise function
    static void sumOfArrays(int[] arr1, int[] arr2)
    {
        if(arr1.Length != arr2.Length){
            Console.WriteLine("ERROR!");
        }
        
        int[] result = new int[arr1.Length];
        for(int i = 0; i < arr1.Length; i++){
            result[i] = arr1[i] + arr2[i];
        }
        PrintArray(result);
    }
    
    static void Main()
    {
        int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        MaxandMinElements(numbers);
        Console.WriteLine("So, here's the original array: ");
        PrintArray(numbers);
        Console.WriteLine("\nAnd here is the reversed one: ");
        PrintArray(ReverseArray(numbers));
        
        Console.WriteLine("\nThe second largest element is " + secondLargest(numbers));
        
        int[] arr1 = {1, 2, 3};
        int[] arr2 = {4, 5, 6};
        Console.WriteLine("So, here are the two arrays: ");
        PrintArray(arr1);
        PrintArray(arr2);
        Console.WriteLine("\nAnd here is the sum of their elements!");
        sumOfArrays(arr1, arr2);
    }
}