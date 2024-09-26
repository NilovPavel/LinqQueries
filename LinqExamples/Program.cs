using System.Xml.Linq;
using System.Linq;
using LinqExamples;


//Инициализация коллекции 
List<Employer> source = new List<Employer>()
{
    new Employer{ Id = 1, Name = "Alice", Department = new Department{ Id = 1, DepartmentName = "Бухгалтерия" } }
    , new Employer{ Id = 2, Name = "John", Department = new Department{ Id = 1, DepartmentName = "Бухгалтерия" } }
    , new Employer{ Id = 3, Name = "Bob" , Department = new Department{ Id = 2, DepartmentName = "ИТ"} }
    , new Employer{ Id = 4, Name = "James", Department = new Department{ Id = 2, DepartmentName = "ИТ"}  }
};


//1. Самый простой запрос без условий. Возвращает коллекцию как есть
IEnumerable<Employer> 
    asIs = 
            from item in source
            select item;

//2. Пример с демеонстрацией фильтров
IEnumerable<Employer>
    onlyIT =
            from item in source
            where item.Department.DepartmentName.Equals("ИТ")
            select item;

//3. Пример сортировки order by
IEnumerable<Employer> 
    orderBy =
            from item in source
            //where item.Department.DepartmentName.Equals("ИТ")
            orderby item.Name
            select item;

//4. Пример group by
IEnumerable<IGrouping<int,Employer>>
    employee 
    = 
        from item in source
        //where item.Department.DepartmentName.Equals("ИТ")
        group item by item.Department.Id;

//5. Пример использования let
//IEnumerable<string> 
    var
    emplInDeprtms
    =
        from item in source
        let description = ($"{item.Name} работает в отделе: {item.Department}")
        //select description;
        select new { id = item.Id, Name = item.Name, Department = item.Department,
                    Description = description};

//6. Пример использования into
//IEnumerable<string>
    var
    emplWithHashCode
    = from item in source
      group item by item.Department.Id into dprtId
      where dprtId != null
      select new { Id=dprtId.Key, Employee = string.Join(",", dprtId.Select(item => item.Name)) };
;

//7. Пример использования