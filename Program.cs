// Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
//*/
int lenArray = ReadInt("Длинна массива: ");
int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
 randomArray[i] = new Random(). Next (1,32);
    Console.Write(randomArray[i] + " ");
}
int ReadInt(string msg)
{
 Console.Write(msg);
return Convert.ToInt32(Console.ReadLine());
}