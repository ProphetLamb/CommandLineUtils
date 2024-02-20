// Copyright (c) Nate McMaster.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace McMaster.Extensions.CommandLineUtils
{
    internal class CommandLineValidationContextFactory
    {
        private readonly CommandLineApplication _app;

        public CommandLineValidationContextFactory(CommandLineApplication app)
        {
            _app = app ?? throw new ArgumentNullException(nameof(app));
        }

        [UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode", Justification = "Model type requires all members dynamically accessible.")]
        public ValidationContext Create(CommandLineApplication app) => new(app, _app, null);

        [UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode", Justification = "Model type requires all members dynamically accessible.")]
        public ValidationContext Create(CommandArgument argument) => new(argument, _app, null);

        [UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode", Justification = "Model type requires all members dynamically accessible.")]
        public ValidationContext Create(CommandOption option) => new(option, _app, null);
    }
}
