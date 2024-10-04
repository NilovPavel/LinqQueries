// Если делегат не содержит аргументов, используйте круглые скобки
using System;

Func<string> f = () => "Jeff";

// можно в явном виде указать типы
Func<int, string> f2 = (Int32 n) => n.ToString();
Func<int, int, string> f3 = (int n1, int n2) => (n1 + n2).ToString();

// Компилятор может самостоятельно определить типы для делегатов
// с одним и более аргументами
Func<int, string> f4 = (n) => n.ToString();
Func<int, int, string> f5 = (n1, n2) => (n1 + n2).ToString();

// Если аргумент у делегата всего один, круглые скобки можно опустить
Func<int, string> f6 = n => n.ToString();

// Для аргументов ref/out нужно в явном виде указывать ref/out и тип
//var b = (out int n) => n = 5;

//общий вид
//Тип делегата  имя делегата    аргументы в "()" или без, если он один  лямбда          Тело функции
Action<int>     action  =       (x)                                     =>              Console.WriteLine(x);

//Пример
Predicate<int> predicate =      (x)        => 
{
    if (x % 2 == 1)
        return true;  
    return false;    
};

