//1 вид. Метод ничего не принимает, ничего не возвращает

// void Method1();
// {
//     Console.WriteLine("Автор ...");
// }
// Method1();

// 2 вид.Ничего не возвращают, но могут примать какие-то аргументы.

// void Method2(string msg);
// {
//     Console.WriteLine(msg);
// }
// Method2("Текст сообщения");

// Метод, для того чтобы показывать на экране определенное колличество сообщений
// void Method21(string msg, int count);
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
//Method21("Текст",4 ); // Вызов метода, указываем что мы хотим увидеть текст и сколько раз
// Можем явно присваивать какому аргументу какую конструкцию мы хотим присвоить
//Method21(msg:"Текст",count:4 );

// 3 вид. Метод что-то возвращает, ничего не принимает 

// int Method3()
// {
//     return Date.Time.Now.Year;
// } 
// int year = Method3();
// Console.WriteLine(year);

// 4 вид. Что-то принимают и что-то возвращают

//string Method4(int count, string text);
//{
//int i = 0;
//string result = String.Empty; // Результатом будет пустая строка
//while(i < count)
//{
 //   result = result + text;
 //   i++;
//}
//return result;

//}
//string res =  Method4(10,"sghdh");
//Console.WriteLine(res);

// Использование с циклом for
string Method5(int count, string text);
{
string result = String.Empty; // Результатом будет пустая строка
for (int i = 0; i < count;  i++)
{
    result = result + text;
}
return result;
}
string res =  Method5(10,"sghdh");
Console.WriteLine(res);
