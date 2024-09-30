using LinqUndeclarativeExamples;
using System.Collections;


//Cast
IEnumerable peoples = new List<IPerson>()
{
    new Child {  }
    , new Child {  }
    , new Parent { }
};

var onlyChilds = peoples
    .OfType<Child>()          //Раскомментировать, чтобы убрать Exception
    .Cast<Child>();

//Цикл только для того, чтобы показать Exception
foreach (var child in onlyChilds)
    ;

//В декларативном синтаксисе
IEnumerable<Child> query = from Child child in peoples
            select child;

;
//ToList
var onlyChild = onlyChilds.ToList<Child>();




;