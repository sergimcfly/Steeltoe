﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.

using Microsoft.Extensions.Configuration;
using Steeltoe.Management.Endpoint.Security;
using System;

namespace Steeltoe.Management.Endpoint.Env
{
    [Obsolete("Use EnvEndpointOptions instead.")]
    public class EnvOptions : AbstractOptions, IEnvOptions
    {
        private const string MANAGEMENT_INFO_PREFIX = "management:endpoints:env";

        public EnvOptions()
            : base()
        {
            Id = "env";
            RequiredPermissions = Permissions.RESTRICTED;
        }

        public EnvOptions(IConfiguration config)
            : base(MANAGEMENT_INFO_PREFIX, config)
        {
            if (string.IsNullOrEmpty(Id))
            {
                Id = "env";
            }

            if (RequiredPermissions == Permissions.UNDEFINED)
            {
                RequiredPermissions = Permissions.RESTRICTED;
            }
        }

        public string[] KeysToSanitize => throw new NotImplementedException();
    }
}