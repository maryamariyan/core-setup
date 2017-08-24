﻿using System.Collections.Generic;

namespace Microsoft.DotNet.Cli.Build
{
    public class BuildVersion : Version
    {
        public string SimpleVersion => $"{Major}.{Minor}.{Patch}.{CommitCountString}";
        public string VersionSuffix => $"{ReleaseSuffix}-{CommitCountString}";
        public string NetCoreAppVersion => $"{ProductionVersion}" + (HostVersion.EnsureStableVersion ? "" : $"-{VersionSuffix}-00");
        public string ProductionVersion => $"{Major}.{Minor}.{Patch}";
    }
}
