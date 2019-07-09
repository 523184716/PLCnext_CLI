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
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using NSubstitute;
using PlcNext.Common.Tools;
using Test.PlcNext.SystemTests.Tools;

namespace Test.PlcNext.Tools.Abstractions.Mocked
{
    internal class MockedEnvironmentServiceAbstraction : IEnvironmentServiceAbstraction
    {
        private readonly IEnvironmentService environmentService = Substitute.For<IEnvironmentService>();

        public MockedEnvironmentServiceAbstraction()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            string codeBase = assembly.CodeBase;
            UriBuilder uri = new UriBuilder(codeBase);
            string path = Uri.UnescapeDataString(uri.Path);
            environmentService.AssemblyVersion.Returns(new Version(2,0,0));
            environmentService.AssemblyDirectory.Returns(Path.GetDirectoryName(path));
            environmentService.PlatformName.Returns("linux");
            environmentService.Architecture.Returns("x64");
            environmentService.Platform.Returns(OSPlatform.Linux);
            IEnvironmentPathNames pathNames = Substitute.For<IEnvironmentPathNames>();
            pathNames.ContainsKey("ApplicationData").Returns(true);
            pathNames["ApplicationData"].Returns(Path.GetDirectoryName(path));
            pathNames.ContainsKey("ApplicationName").Returns(true);
            pathNames["ApplicationName"].Returns(assembly.GetName().Name);
            environmentService.PathNames.Returns(pathNames);
        }

        public void Initialize(InstancesRegistrationSource exportProvider)
        {
            exportProvider.AddInstance(environmentService);
        }

        public void Dispose()
        {

        }
    }
}
