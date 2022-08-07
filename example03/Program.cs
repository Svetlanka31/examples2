// Имеется одномерный массив array из n элементов, требуется найти элемент массива равный find
int [] array = {13, 35, 65,  24, 86, 9, 65, 13, 4};

int n = array.Length;
int find = 65;

int index = 0;

while(index<n){
if (array[index]==find){
    Console.WriteLine(index);
    break;
}
    index++;
}
