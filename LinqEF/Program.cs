using (ApplicationContext db = new ApplicationContext())
{
    // создаем два объекта User
    //User tom = new User { Name = "Tom", Age = 33 };
    //User alice = new User { Name = "Alice", Age = 26 };

    //db.SaveChanges();
    //Console.WriteLine("Объекты успешно сохранены");

    // получаем объекты из бд и выводим на консоль
    /*var users = db.Users.ToList();

    foreach (User u in users)
    {
        Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
    }*/

    IQueryable<User> myUsers = db.Users.Where(item => item.Name.Equals("Tom"));

    foreach (User u in myUsers)
    {
        Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
    }
}