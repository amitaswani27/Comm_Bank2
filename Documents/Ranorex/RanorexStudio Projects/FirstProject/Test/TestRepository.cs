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

namespace Test
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the TestRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
    [RepositoryFolder("df4db0a7-1ad2-411a-b586-754ec03627f1")]
    public partial class TestRepository : RepoGenBaseFolder
    {
        static TestRepository instance = new TestRepository();

        /// <summary>
        /// Gets the singleton class instance representing the TestRepository element repository.
        /// </summary>
        [RepositoryFolder("df4db0a7-1ad2-411a-b586-754ec03627f1")]
        public static TestRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public TestRepository() 
            : base("TestRepository", "/", null, 0, false, "df4db0a7-1ad2-411a-b586-754ec03627f1", ".\\RepositoryImages\\TestRepositorydf4db0a7.rximgres")
        {
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("df4db0a7-1ad2-411a-b586-754ec03627f1")]
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
    public partial class TestRepositoryFolders
    {
    }
#pragma warning restore 0436
}