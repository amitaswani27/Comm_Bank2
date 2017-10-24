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

namespace ProjectRanorex
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the ProjectRanorexRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
    [RepositoryFolder("4ff7b6a5-8e78-4e2f-a6f8-dbc6bad7887e")]
    public partial class ProjectRanorexRepository : RepoGenBaseFolder
    {
        static ProjectRanorexRepository instance = new ProjectRanorexRepository();

        /// <summary>
        /// Gets the singleton class instance representing the ProjectRanorexRepository element repository.
        /// </summary>
        [RepositoryFolder("4ff7b6a5-8e78-4e2f-a6f8-dbc6bad7887e")]
        public static ProjectRanorexRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public ProjectRanorexRepository() 
            : base("ProjectRanorexRepository", "/", null, 0, false, "4ff7b6a5-8e78-4e2f-a6f8-dbc6bad7887e", ".\\RepositoryImages\\ProjectRanorexRepository4ff7b6a5.rximgres")
        {
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("4ff7b6a5-8e78-4e2f-a6f8-dbc6bad7887e")]
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
    public partial class ProjectRanorexRepositoryFolders
    {
    }
#pragma warning restore 0436
}