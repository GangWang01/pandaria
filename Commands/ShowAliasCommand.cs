﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#nullable enable

using System.CommandLine;
using System.CommandLine.Invocation;
using Microsoft.TemplateEngine.Abstractions;

namespace Microsoft.TemplateEngine.Cli.Commands
{
    internal class ShowAliasCommand : BaseCommand<ShowAliasCommandArgs>
    {
        internal ShowAliasCommand(ITemplateEngineHost host, ITelemetryLogger logger, New3Callbacks callbacks) : base(host, logger, callbacks) { }

        protected override Command CreateCommandAbstract() => throw new NotImplementedException();

        protected override Task<int> ExecuteAsync(ShowAliasCommandArgs args, IEngineEnvironmentSettings environmentSettings, CancellationToken cancellationToken) => throw new NotImplementedException();

        protected override ShowAliasCommandArgs ParseContext(InvocationContext context) => throw new NotImplementedException();
    }

    internal class ShowAliasCommandArgs : GlobalArgs
    {
        public ShowAliasCommandArgs(InvocationContext invocationContext) : base(invocationContext)
        {
        }
    }
}
