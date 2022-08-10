//int[] array ={11,21,13,88,21,55,88,98,22};
int[] array = new int[10];
void FillArray(int[] collection)

{
    int length = collection.Length;
    int index = 0;
while (index < length)
{
collection[index] = new Random().Next (1,10);

index = index+1;
}
}

void PrintArray(int[] col)
{

 int count = col.Length;
    int position = 0;   
    while (position < count)
{
Console.WriteLine(col[position]);

position = position+1;
}
}
FillArray(array);
PrintArray(array);
//int n = array.Length;
//int find = 88;
//int index = 0;
//while (index < n)
//{
   //if (array[index] == find)
    //{Console.WriteLine(index);
    //break;
   // }
   // index = index+1;
   // }
//array[0]=12;
//Console.WriteLine(array[0]);
//Console.WriteLine(n);