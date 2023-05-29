using HospitalDatabase;
using HospitalDatabase.Models;

using (ApplicationContext db = new ApplicationContext())
{
    // создаем два объекта User
    Medicaments tom = new Medicaments { Name = "Tom" };
    Medicaments alice = new Medicaments { Name = "Alice" };

    // добавляем их в бд
    db.Medicaments.Add(tom);
    db.Medicaments.Add(alice);
    db.SaveChanges();
    Console.WriteLine("Объекты успешно сохранены");

    // получаем объекты из бд и выводим на консоль
    var users = db.Medicaments.ToList();
    Console.WriteLine("Список объектов:");
    foreach (Medicaments u in users)
    {
        Console.WriteLine($"{u.MedicamentId}-{u.Name} ");
    }
}