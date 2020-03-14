﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google.Solutions.CloudIap.IapDesktop.ProjectExplorer
{
    internal interface IProjectExplorer
    {
        Task RefreshProject(string projectId);
        Task RefreshAllProjects();
    }
}
