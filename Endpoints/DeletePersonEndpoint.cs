using FastEndpoints;

namespace FastEndpointsDemo;

public class DeletePersonEndpoint : Endpoint<DeletePersonRequest>
{
    public override void Configure()
    {
        Delete("/api/person/{id}");
        AllowAnonymous();
    }

    public override async Task HandleAsync(DeletePersonRequest rq, CancellationToken ct)
    {
        await PublishAsync(new DeletePersonEvent { Id = rq.Id });
        await SendOkAsync();
    }
}