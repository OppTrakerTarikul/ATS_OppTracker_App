// ====================================================
// More Templates: https://www.ebenmonney.com/templates
// Email: support@ebenmonney.com
// ====================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
//using AspNet.Security.OpenIdConnect.Primitives;
using operationalTracker.Entities.Models;

namespace operationalTracker.Repository
{
    public class HttpUnitOfWork : UnitOfWork
    {
        public HttpUnitOfWork(TEST_DBContext context, IHttpContextAccessor httpAccessor) : base(context)
        {
            //context.CurrentUserId = httpAccessor.HttpContext.User.FindFirst(OpenIdConnectConstants.Claims.Subject)?.Value?.Trim();
        }
    }
}
