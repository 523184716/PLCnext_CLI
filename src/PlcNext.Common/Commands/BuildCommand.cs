﻿#region Copyright
///////////////////////////////////////////////////////////////////////////////
//
//  Copyright PHOENIX CONTACT Software GmbH
//
///////////////////////////////////////////////////////////////////////////////
#endregion

using PlcNext.Common.Build;
using PlcNext.Common.Tools;
using PlcNext.Common.Tools.FileSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using PlcNext.Common.DataModel;
using PlcNext.Common.Tools.Events;
using PlcNext.Common.Tools.SDK;
using PlcNext.Common.Tools.UI;

namespace PlcNext.Common.Commands
{
    internal class BuildCommand : SyncCommand<BuildCommandArgs>
    {
        private readonly IBuilder builder;
        private readonly IEntityFactory entityFactory;

        public BuildCommand(ITransactionFactory transactionFactory, IExceptionHandler exceptionHandler, ExecutionContext executionContext, ICommandResultVisualizer commandResultVisualizer, IBuilder builder, IEntityFactory entityFactory) : base(transactionFactory, exceptionHandler, executionContext, commandResultVisualizer)
        {
            this.builder = builder;
            this.entityFactory = entityFactory;
        }

        protected override int Execute(BuildCommandArgs args, ChangeObservable observable)
        {
            string buildProperties = string.Join(" ", args.BuildProperties.Select(Unescape));

            Entity rootEntity = entityFactory.Create(Guid.NewGuid().ToByteString(), args).Root;

            BuildInformation buildInfo = new BuildInformation(rootEntity, args.BuildType, args.Configure, args.NoConfigure, buildProperties, args.Output);
            builder.Build(buildInfo, observable, args.Target);

            return 0;

            string Unescape(string arg)
            {
                return arg.Replace("%22","\"");
            }
        }
    }
}
