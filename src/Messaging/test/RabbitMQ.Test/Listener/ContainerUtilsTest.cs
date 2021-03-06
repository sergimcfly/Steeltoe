﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.

using Steeltoe.Messaging.Rabbit.Exceptions;
using Steeltoe.Messaging.Rabbit.Listener.Exceptions;
using Steeltoe.Messaging.Rabbit.Listener.Support;
using Xunit;

namespace Steeltoe.Messaging.Rabbit.Listener
{
    public class ContainerUtilsTest
    {
        [Fact]
        public void TestMustRequeue()
        {
            Assert.True(ContainerUtils.ShouldRequeue(
                false,
                new ListenerExecutionFailedException(string.Empty, new ImmediateRequeueException("requeue"))));
        }

        [Fact]
        public void TestMustNotRequeue()
        {
            Assert.False(ContainerUtils.ShouldRequeue(
                true,
                new ListenerExecutionFailedException(string.Empty, new RabbitRejectAndDontRequeueException("no requeue"))));
        }
    }
}
