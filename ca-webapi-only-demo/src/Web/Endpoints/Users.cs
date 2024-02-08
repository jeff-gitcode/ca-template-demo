using ca_webapi_only_demo.Infrastructure.Identity;

namespace ca_webapi_only_demo.Web.Endpoints;

public class Users : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
            .MapIdentityApi<ApplicationUser>();
    }
}
