using FastEndpoints;

namespace FastEndpointsDemo;

public class DeletePersonHandler : IEventHandler<DeletePersonEvent>
{
    private readonly DemoDatabase _db;

    public DeletePersonHandler(DemoDatabase db)
    {
        _db = db;
    }

    public Task HandleAsync(DeletePersonEvent eventModel, CancellationToken ct)
    {
        var person = _db.Persons.First(x => x.Id == eventModel.Id);
        _db.Persons.Delete(person);

        return Task.CompletedTask;
    }
}