// 1.Использует Action<T> для печати каждого элемента
List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

//Явная инициализация делегата
Action<int> action = Console.WriteLine;
action = (item) => Console.WriteLine(item);

numbers.ForEach(item => action(item));


// 2.Использование Predicate<T> для поиска элементов по условию

//Явная инициализация делегата
Predicate<int> predicate = item => item > 3;

List<int> numberBiggerThan3 = numbers.FindAll(predicate);
;
numberBiggerThan3 = numbers.FindAll(item => item > 3);
;

// 3.Использование Func<T> для получения списка строк из чисел

//Явная инициализация делегата
Func<int, string> intToString = x => x.ToString();

List<string> numberStrings = numbers.Select(intToString)
    .ToList();


// можно в явном виде указать типы
Func<int, string> f2 = (Int32 n) => n.ToString();
Func<int, int, string> f3 = (int n1, int n2) => (n1 + n2).ToString();

// Компилятор может самостоятельно определить типы для делегатов
// с одним и более аргументами
Func<int, string> f4 = (n) => n.ToString();
Func<int, int, string> f5 = (n1, n2) => (n1 + n2).ToString();

// Если аргумент у делегата всего один, круглые скобки можно опустить
Func<int, string> f6 = n => n.ToString();