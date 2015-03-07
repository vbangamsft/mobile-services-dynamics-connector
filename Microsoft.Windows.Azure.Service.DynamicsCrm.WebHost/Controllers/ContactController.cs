﻿using System;
using System.Linq;
using Microsoft.Windows.Azure.Service.DynamicsCrm.WebHost.Models;
using Microsoft.WindowsAzure.Mobile.Service.Security;
using Microsoft.Xrm.Client.Services;
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.OData.Query;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.WebServiceClient;
using Microsoft.Xrm.Client;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System.Net;

namespace Microsoft.Windows.Azure.Service.DynamicsCrm.WebHost.Controllers
{
    [AuthorizeLevel(AuthorizationLevel.User)]
    public class ContactController : BaseController<ContactDto, Contact>
    {
        [HttpGet]
        public async Task<IEnumerable<ContactDto>> Get(ODataQueryOptions<ContactDto> query)
        {
            return await QueryAsync(query);
        }
    }
}