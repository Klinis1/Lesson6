using System;
Console.WriteLine("enter number of elements");
int n_elements = int.Parse(Console.ReadLine());
int[] arr = new int[n_elements];
Console.WriteLine("enter elements");
for (int i = 0; i < n_elements; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Choose your alghorithm\n1:selection\n2:bubble\n3:insertion");
int alghorythm = int.Parse(Console.ReadLine());
switch(alghorythm)
{
    case 1:
        Selection(arr);
        break;
    case 2:
        Bubble(arr);
        break;
    case 3:
        Insertion(arr);
        break;
}


for (int i = 0; i<arr.Length; ++i)
    Console.Write(arr[i]+ " ");


int[] Selection(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int min = i;
        for (int j = i + 1; j < arr.Length; j++)
            if (arr[j] < arr[min])
                min = j;
        int less = arr[min];
        arr[min] = arr[i];
        arr[i] = less;
    }
    
    return arr;
}
int[] Bubble(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
        for (int j = 0; j < arr.Length - i - 1; j++)
            if (arr[j] > arr[j + 1])
            {
                int result = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = result;
            }
    return arr;
}
int[] Insertion(int[] arr)
{
    for (int i = 1; i < arr.Length; ++i)
    {
        int main = arr[i];
        int j = i - 1;
        while (j >= 0 && arr[j] > main)
        {
            arr[j + 1] = arr[j];
            j = j - 1;
        }
        arr[j + 1] = main;
    }
    return arr;
}
