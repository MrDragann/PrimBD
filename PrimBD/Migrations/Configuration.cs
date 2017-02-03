namespace PrimBD.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PrimBD.Models.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PrimBD.Models.DataContext context)
        {
            context.Students.AddOrUpdate(
               p => p.Id,
               new Student { Name = "Ivan", Surname = "Ivanov", IdGroup = 1 },
               new Student { Name = "Roman", Surname = "Romanov", IdGroup = 2 },
               new Student { Name = "Fedor", Surname = "Fedorov", IdGroup = 2 }
             );

            context.Groups.AddOrUpdate(p => p.Id,
                new Group { Name = "DT405", Curator = "Fedorova N.N" },
                new Group { Name = "GH103", Curator = "Andreeva M.N" }
                );
        }
    }
}
