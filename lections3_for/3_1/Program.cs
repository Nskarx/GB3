//Вид№1
// void Method1()
// {
//     Console.WriteLine("Автор...");
// }


//  Method1();




//Вид№2
// void Metod2(string msg) //где void ключевое слово, дальше идентификатор, в скобках
// //указаны какие-то аргументы.
// {
// Console.WriteLine(msg);  //оператор, в скобках указан принятый аргумент.
// }
// // Metod2("Текст сообщения");  //где Metod2 является идентификатором, а в скобках
// //указан текст, выводимый в консоли.

// Именованные аргументы

// void Metod21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {

//         Console.WriteLine(msg); //- где переменная count отображает на экране
// //определённое количество сообщений msg.
// count++; //- а надо i++;
// }
// }
// Metod21("Текст", 4); //- метод вызывает Текст, после запятой указано количество
// // вызовов, в нашем случае 4.

// void Metod21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Metod21(msg: "Текст", count: 4);

//3Вид

// int Metod3()  //не принимает никакие аргументы
// {
//     return DateTime.Now.Year; //- обязательное использование оператора return,
// }
// int year = Metod3();    //- вызываем метод, в левой части используем идентификатор Console.WriteLine(year);                        
// Console.WriteLine(year);  //переменной (year) и через оператор присваивания (=) кладём нужное значение


//Четвёртая группа методов
//Самая важная группа методов, это методы, которые что-то принимают и что-то возвращают.
string Metod4(int count, string text)
{
int i = 0;
string result = String.Empty;
while (i<count)
{
result = result + text;
i++;
}
return result;
}
string res = Metod4(10, "z"); 
Console.WriteLine(res);