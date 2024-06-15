using FastEndpoints;

namespace FastEndpointsDemo;

public class UpdatePersonEndpoint : Endpoint<UpdatePersonRequest>
{
    public override void Configure()
    {
        Put("/api/person");
        AllowAnonymous();
    }

    public override async Task HandleAsync(UpdatePersonRequest rq, CancellationToken ct)
    {
        await PublishAsync(
            new UpdatePersonEvent
            {
                Id = rq.Id,
                LastName = rq.LastName,
                FirstName = rq.FirstName,
                Age = rq.Age
            });
        await SendOkAsync();
    }
}