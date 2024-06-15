using FastEndpoints;

namespace FastEndpointsDemo;

public class GetPersonsEndpoint : EndpointWithoutRequest<PersonsResponse>
{
    private readonly DemoDatabase _db;

    public GetPersonsEndpoint(DemoDatabase db)
    {
        _db = db;
    }

    public override void Configure()
    {
        Get("/api/person");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        var rs = new PersonsResponse
        {
            Persons = _db.Persons.ToList()
        };

        await SendOkAsync(rs);
    }
}