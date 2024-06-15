using NMemory;
using NMemory.Tables;

namespace FastEndpointsDemo;

public class DemoDatabase : Database
{
    public DemoDatabase()
    {
        this.Persons = this.Tables.Create<Person, int>(x => x.Id, new IdentitySpecification<Person>(x => x.Id, 1, 1));
    }

    public ITable<Person> Persons { get; }

}