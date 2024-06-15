using FastEndpoints;

namespace FastEndpointsDemo;

public class CreatePersonHandler : IEventHandler<CreatePersonEvent>
{
    private readonly DemoDatabase _db;

    public CreatePersonHandler(DemoDatabase db)
    {
        _db = db;
    }

    public Task HandleAsync(CreatePersonEvent eventModel, CancellationToken ct)
    {
        _db.Persons.Insert(
            new Person
            {
                FirstName = eventModel.FirstName,
                LastName = eventModel.LastName,
                Age = eventModel.Age,
                CreatedAt = DateTime.Now,
            });

        return Task.CompletedTask;
    }
}