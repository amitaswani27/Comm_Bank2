﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace Project1
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the Project1Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
    [RepositoryFolder("6dd8b858-1fb1-4238-bffa-b4a544c1a2e2")]
    public partial class Project1Repository : RepoGenBaseFolder
    {
        static Project1Repository instance = new Project1Repository();

        /// <summary>
        /// Gets the singleton class instance representing the Project1Repository element repository.
        /// </summary>
        [RepositoryFolder("6dd8b858-1fb1-4238-bffa-b4a544c1a2e2")]
        public static Project1Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public Project1Repository() 
            : base("Project1Repository", "/", null, 0, false, "6dd8b858-1fb1-4238-bffa-b4a544c1a2e2", ".\\RepositoryImages\\Project1Repository6dd8b858.rximgres")
        {
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("6dd8b858-1fb1-4238-bffa-b4a544c1a2e2")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
    public partial class Project1RepositoryFolders
    {
    }
#pragma warning restore 0436
}