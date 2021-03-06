﻿#region Copyright
///////////////////////////////////////////////////////////////////////////////
//
//  Copyright (c) Phoenix Contact GmbH & Co KG
//  This software is licensed under Apache-2.0
//
///////////////////////////////////////////////////////////////////////////////
#endregion

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using PlcNext;
using PlcNext.Common.Tools;
using PlcNext.Common.Tools.IO;
using PlcNext.NamedPipeServer;
using PlcNext.NamedPipeServer.Communication;
using Test.PlcNext.NamedPipe.Tools;
using Test.PlcNext.Tools.XUnit;
using Xunit;
using Xunit.Abstractions;

namespace Test.PlcNext.NamedPipe
{
    [Trait("Category", "Slow")]
    public class NamedPipeServerProtocolSplitMessagesTest : IDisposable
    {
        private readonly ICommunicationProtocol protocol;
        private readonly IClientSimulator simulator;
        private readonly ManualResetEvent serverMessageReceived = new ManualResetEvent(false);
        private readonly ManualResetEvent serverError = new ManualResetEvent(false);
        private readonly StreamFactory streamFactory;

        public NamedPipeServerProtocolSplitMessagesTest(ITestOutputHelper output)
        {
            NamedPipeServerFeature serverFeature = new NamedPipeServerFeature();
            if (!serverFeature.FeatureEnabled)
            {
                throw new SkipTestException("Disabled named pipe communication");
            }
            streamFactory = PageStreamFactory.CreateDefault(16);
            string serverName = RuntimeInformation.IsOSPlatform(OSPlatform.Windows)
                                    ? Guid.NewGuid().ToByteString()
                                    : $"/tmp/{Guid.NewGuid().ToByteString()}";
            Task<ICommunicationProtocol> creationTask = NamedPipeCommunicationProtocol.Connect(serverName, streamFactory, new LogTracer(output));
            simulator = NamedPipeCommunicationProtocolSimulator.Connect(serverName, streamFactory, new LogTracer(output));
            creationTask.Wait();
            protocol = creationTask.Result;
            protocol.MessageReceived += OnMessageReceived;
            protocol.CommunicationError += OnCommunicationError;
            protocol.Start();
        }

        [SkippableFact]
        public void SendSplitMessage()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => protocol.SendMessage(GenerateSplitLengthMessage()));
        }

        #region Helpers

        private Stream GenerateSplitLengthMessage()
        {
            long length = (long)int.MaxValue + 100;
            return streamFactory.GenerateRandomStream(length);
        }

        private void OnMessageReceived(object sender, MessageReceivedEventArgs e)
        {
            serverMessageReceived.Set();
        }

        private void OnCommunicationError(object sender, EventArgs e)
        {
            serverError.Set();
        }

        public void Dispose()
        {
            Extensions.ExecutesWithTimeout(() =>
            {
                protocol.MessageReceived -= OnMessageReceived;
                protocol.Dispose();
                simulator.Dispose();
            }, 2000);
        }

        #endregion
    }
}
