using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AD0001
{
    internal abstract class AbstractAuthorizationFilter : IAsyncAuthorizationFilter
    {
        public Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
            return Task.CompletedTask;
        }
    }
}
