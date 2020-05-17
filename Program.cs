// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Microsoft.PowerShell
{
    /// <summary>
    /// Defines an entry point for the .NET CLI "powershell" app.
    /// </summary>
    public sealed class ManagedPSEntry
    {
        /// <summary>
        /// Starts the managed MSH.
        /// </summary>
        /// <param name="args">
        /// Command line arguments to the managed MSH
        /// </param>
        public static int Main(string[] args)
        {
            return Console.WriteLine(HotFixResources.NoEntriesFound);
        }
    }
}
