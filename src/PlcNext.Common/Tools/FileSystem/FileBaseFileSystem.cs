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
using PlcNext.Common.Tools.UI;

namespace PlcNext.Common.Tools.FileSystem
{
    internal class FileBaseFileSystem : IFileSystem
    {
        private readonly ILog log;
        public VirtualDirectory CurrentDirectory { get; }

        public FileBaseFileSystem(ILog log)
        {
            this.log = log;
            DirectoryInfo currentDirectory = new DirectoryInfo(Directory.GetCurrentDirectory());
            CurrentDirectory = new VirtualDirectory(currentDirectory.Name, new DirectoryInfoContentResolver(currentDirectory, false, log));
        }

        public VirtualDirectory GetDirectory(string path, string basePath = "", bool createNew = true)
        {
            bool created = false;
            path = path.CleanPath();
            basePath = basePath.CleanPath();

            if (!string.IsNullOrEmpty(basePath) && !Path.IsPathRooted(path))
            {
                path = Path.Combine(basePath, path);
            }
            if (string.IsNullOrEmpty(path))
            {
                return CurrentDirectory;
            }
            if (!Directory.Exists(Path.GetFullPath(path)) && createNew)
            {
                created = true;
                Directory.CreateDirectory(Path.GetFullPath(path));
            }
            DirectoryInfo directory = new DirectoryInfo(Path.GetFullPath(path));
            VirtualDirectory result = new VirtualDirectory(directory.Name, new DirectoryInfoContentResolver(directory, created, log));
            string parentPath = Path.GetDirectoryName(path);
            if (!string.IsNullOrEmpty(parentPath) && parentPath != path)
            {
                VirtualDirectory parent = GetDirectory(parentPath, basePath, createNew);
                parent.AddEntry(result);
                result.SetParent(parent);
            }

            return result;
        }

        public VirtualDirectory GetTemporaryDirectory()
        {
            string path = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToByteString());
            if (DirectoryExists(path))
            {
                Directory.Delete(path, true);
            }
            
            return new VirtualDirectory(Path.GetDirectoryName(path), new DirectoryInfoContentResolver(Directory.CreateDirectory(path), true, log));
        }

        public bool DirectoryExists(string path, string basePath = "")
        {
            path = path.CleanPath();
            basePath = basePath.CleanPath();
            if (!string.IsNullOrEmpty(basePath) && !Path.IsPathRooted(path))
            {
                path = Path.Combine(basePath, path);
            }

            return Directory.Exists(Path.GetFullPath(string.IsNullOrEmpty(path) ? "." : path));
        }

        public VirtualFile GetFile(string path, string basePath = "")
        {
            path = path.CleanPath();
            basePath = basePath.CleanPath();
            VirtualDirectory directory = GetDirectory(Path.GetDirectoryName(path), basePath, false);
            FileInfo file = new FileInfo(Path.Combine(directory.FullName, Path.GetFileName(path) ?? ""));
            VirtualFile result = new VirtualFile(file.Name, new FileInfoContentResolver(file, !file.Exists, log));
            result.SetParent(directory);
            directory.AddEntry(result);
            return result;
        }

        public bool FileExists(string path, string basePath = "")
        {
            path = path.CleanPath();
            basePath = basePath.CleanPath();
            if (!string.IsNullOrEmpty(basePath) && !Path.IsPathRooted(path))
            {
                path = Path.Combine(basePath, path);
            }
            return File.Exists(path);
        }

        public string[] GetPath(string path)
        {
            path = path.CleanPath();
            return path.Split(new[] {Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar},
                              StringSplitOptions.RemoveEmptyEntries);
        }

        public bool IsRooted(string path)
        {
            path = path.CleanPath();
            return Path.IsPathRooted(path);
        }
    }
}
