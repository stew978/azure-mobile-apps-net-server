﻿// ----------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// ----------------------------------------------------------------------------

using System.Web.Http;
using Microsoft.Azure.Mobile.Server.Config;

namespace Microsoft.Azure.Mobile.Server.Swagger.Test.TestControllers
{
    [MobileAppController]
    public class MixedAuthController : ApiController
    {
        public IHttpActionResult Get()
        {
            return this.Ok();
        }

        [Authorize]
        public IHttpActionResult Post()
        {
            return this.Ok();
        }
    }
}