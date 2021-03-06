﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.

namespace Steeltoe.Messaging.Rabbit.Config
{
    public static class ExchangeType
    {
        public const string DIRECT = "direct";
        public const string TOPIC = "topic";
        public const string FANOUT = "fanout";
        public const string HEADERS = "headers";
        public const string SYSTEM = "system";
    }
}
