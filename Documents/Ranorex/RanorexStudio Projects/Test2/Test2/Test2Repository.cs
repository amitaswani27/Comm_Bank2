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

namespace Test2
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the Test2Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
    [RepositoryFolder("a537d69f-875e-4d1d-8ff6-c9a70d2e4645")]
    public partial class Test2Repository : RepoGenBaseFolder
    {
        static Test2Repository instance = new Test2Repository();

        /// <summary>
        /// Gets the singleton class instance representing the Test2Repository element repository.
        /// </summary>
        [RepositoryFolder("a537d69f-875e-4d1d-8ff6-c9a70d2e4645")]
        public static Test2Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public Test2Repository() 
            : base("Test2Repository", "/", null, 0, false, "a537d69f-875e-4d1d-8ff6-c9a70d2e4645", ".\\RepositoryImages\\Test2Repositorya537d69f.rximgres")
        {
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("a537d69f-875e-4d1d-8ff6-c9a70d2e4645")]
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
    public partial class Test2RepositoryFolders
    {
    }
#pragma warning restore 0436
}