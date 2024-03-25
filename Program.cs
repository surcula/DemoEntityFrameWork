using DemoEntityFrameWork.Contexts;
using DemoEntityFrameWork.Entities;

using (DemoContext context = new DemoContext())
{
    Person person = new Person()
    {
        FirstName = "David",
        LastName = "Gaillet",
        Pseudo = "Surcula",
        Email = "bbbb"
    };
    Person person2 = new Person()
    {
        FirstName = "Dark",
        LastName = "Vador",
        Pseudo = "Seigneur Noir",
        Email = "66@deathstar.co"
    };
    context.Persons.Add(person);
    context.Persons.Add(person2);
    context.SaveChanges();
   
}