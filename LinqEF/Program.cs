using (ApplicationContext db = new ApplicationContext())
{
    // Добавить пользователей, если их нет в Db
    /*User tom = new User { Name = "Tom", Age = 33 };
    User alice = new User { Name = "Alice", Age = 26 };
    db.Add(tom);
    db.Add<User>(alice);
    db.SaveChanges();*/

    IQueryable<User> myUsers = db.Users;

    foreach (User u in myUsers)
    {
        Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
    }
}