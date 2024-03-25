using DemoEntityFrameWork.Contexts;
using DemoEntityFrameWork.Entities;
using DemoEntityFrameWork.Repositories;

using (DemoContext context = new DemoContext())
{

    //Ajouter des données dans la table
    //Person person = new Person()
    //{
    //    FirstName = "David",
    //    LastName = "Gaillet",
    //    Pseudo = "Surcula",
    //    Email = "bbbb"
    //};
    //Person person2 = new Person()
    //{
    //    FirstName = "Dark",
    //    LastName = "Vador",
    //    Pseudo = "Seigneur Noir",
    //    Email = "66@deathstar.co"
    //};
    //context.Persons.Add(person);
    //context.Persons.Add(person2);
    //context.SaveChanges();

    //Recherche tous les éléments
   //IEnumerable<Person> people = context.Persons.ToList();
   // foreach (var item in people)
   // {
   //     Console.WriteLine($"{item.LastName} {item.FirstName} {item.Pseudo} {item.Email}");
   // }


}


PersonRepository personRepository = new PersonRepository();
Person p3 = personRepository.GetOne(p => p.Id == 2);