﻿int[] array = { 1, 34, 23, 56, 20, 82, 45, 38, 67, 20 };
int n = array.Length;
int find = 20;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index + 1;
    index++;
}