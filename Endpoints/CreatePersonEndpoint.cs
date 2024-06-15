using FastEndpoints;

namespace FastEndpointsDemo;

public class CreatePersonEndpoint : Endpoint<CreatePersonRequest>
{
    public override void Configure()
    {
        Post("/api/person");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CreatePersonRequest rq, CancellationToken ct)
    {
        await PublishAsync(new CreatePersonEvent
        {
            FirstName = rq.FirstName,
            LastName = rq.LastName,
            Age = rq.Age
        });

        await SendOkAsync();
    }
}