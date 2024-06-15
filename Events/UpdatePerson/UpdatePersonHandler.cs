using FastEndpoints;

namespace FastEndpointsDemo;

public class UpdatePersonHandler : IEventHandler<UpdatePersonEvent>
{
    private readonly DemoDatabase _db;

    public UpdatePersonHandler(DemoDatabase db)
    {
        _db = db;
    }

    public Task HandleAsync(UpdatePersonEvent eventModel, CancellationToken ct)
    {
        var person = _db.Persons.First(x => x.Id == eventModel.Id);
        person.Age = eventModel.Age;
        person.EditedAt = DateTime.Now;
        person.FirstName = eventModel.FirstName;
        person.LastName = eventModel.LastName;
        _db.Persons.Update(person);

        return Task.CompletedTask;
    }
}