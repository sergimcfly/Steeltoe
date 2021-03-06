﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.

using Newtonsoft.Json;

namespace Steeltoe.Security.DataProtection.CredHub
{
    public class SshCredential : KeyPairCredential
    {
        [JsonProperty("public_key_fingerprint")]
        public string PublicKeyFingerprint { get; set; }
    }
}
