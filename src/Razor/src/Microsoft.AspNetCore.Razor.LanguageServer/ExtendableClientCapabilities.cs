﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using OmniSharp.Extensions.LanguageServer.Protocol.Client.Capabilities;

namespace Microsoft.AspNetCore.Razor.LanguageServer
{
    internal class ExtendableClientCapabilities : ClientCapabilities
    {
        public bool SupportsCodeActionResolve { get; set; } = false;
    }
}
