﻿#region Copyright
///////////////////////////////////////////////////////////////////////////////
//
//  Copyright (c) Phoenix Contact GmbH & Co KG
//  This software is licensed under Apache-2.0
//
///////////////////////////////////////////////////////////////////////////////
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Autofac;
using CommandLine;
using PlcNext.Common.Commands;
using PlcNext.Common.Tools.UI;

namespace PlcNext.CommandLine
{
    public abstract class VerbBase
    {
        internal ICommandManager CommandManager { get; set; }
        internal IUserInterface UserInterface { get; set; }
        internal ILifetimeScope LifetimeScope { get; set; }

        [Option("verbose", HelpText = "Enables verbose output.")]
        public bool Verbose { get; set; }

        [Option("quiet", HelpText = "Suppresses all output.")]
        public bool Quiet { get; set; }

        //This flag will be evaluated by the main program.
        //This is necessary because otherwise the parser would say "unrecognized option"
        [Option("no-sdk-exploration", Hidden = true)]
        public bool NoSdkExploration { get; set; }

        public async Task<int> Execute()
        {
            if (CommandManager == null)
            {
                throw new InvalidOperationException("Command manager is not resolved.");
            }

            UserInterface?.SetVerbosity(Verbose);
            UserInterface?.SetQuiet(Quiet);

            checkForDeprecated();

            return await Execute(CommandManager);

            void checkForDeprecated()
            {
                System.Reflection.TypeInfo info = this.GetType().GetTypeInfo();
                IEnumerable<Attribute> attributes = info.GetCustomAttributes();
                if(attributes.Any(a => a is DeprecatedAttribute))
                {
                    UserInterface?.WriteWarning("This verb is deprecated.");
                }
            }
        }

        protected abstract Task<int> Execute(ICommandManager commandManager);
    }
}
