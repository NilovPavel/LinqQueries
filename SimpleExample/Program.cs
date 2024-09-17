int[] numbers = { 1, 2, 3, 4, 5 };

// Запрос создается, но не выполняется
var query = from n in numbers
            where n > 2
            select n;

// Запрос выполнится только здесь, когда мы начнем итерировать результаты
foreach (var number in query)
{
    Console.WriteLine(number);
}