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
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace KeePass
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The AddEntry recording.
    /// </summary>
    [TestModule("1e711bca-7c6e-4e4a-88a5-00e660575c57", ModuleType.Recording, 1)]
    public partial class AddEntry : ITestModule
    {
        /// <summary>
        /// Holds an instance of the KeePassRepository repository.
        /// </summary>
        public static KeePassRepository repo = KeePassRepository.Instance;

        static AddEntry instance = new AddEntry();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddEntry()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddEntry Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainForm.AddEntry' at 10;11.", repo.MainForm.AddEntryInfo, new RecordItemIndex(0));
            repo.MainForm.AddEntry.Click("10;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PwEntryForm.MTabEntry.Text' at 68;9.", repo.PwEntryForm.MTabEntry.TextInfo, new RecordItemIndex(1));
            repo.PwEntryForm.MTabEntry.Text.Click("68;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'New Title' with focus on 'PwEntryForm.MTabEntry.Text'.", repo.PwEntryForm.MTabEntry.TextInfo, new RecordItemIndex(2));
            repo.PwEntryForm.MTabEntry.Text.PressKeys("New Title");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PwEntryForm.MTabEntry.MBtnIcon' at 14;9.", repo.PwEntryForm.MTabEntry.MBtnIconInfo, new RecordItemIndex(3));
            repo.PwEntryForm.MTabEntry.MBtnIcon.Click("14;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'IconPickerForm.ListItem33' at 27;12.", repo.IconPickerForm.ListItem33Info, new RecordItemIndex(4));
            repo.IconPickerForm.ListItem33.DoubleClick("27;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PwEntryForm.MTabEntry.UserName' at 88;7.", repo.PwEntryForm.MTabEntry.UserNameInfo, new RecordItemIndex(5));
            repo.PwEntryForm.MTabEntry.UserName.Click("88;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Amit.Aswani' with focus on 'PwEntryForm.MTabEntry.UserName'.", repo.PwEntryForm.MTabEntry.UserNameInfo, new RecordItemIndex(6));
            repo.PwEntryForm.MTabEntry.UserName.PressKeys("Amit.Aswani");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PwEntryForm.MTabEntry.Password' at 163;9.", repo.PwEntryForm.MTabEntry.PasswordInfo, new RecordItemIndex(7));
            repo.PwEntryForm.MTabEntry.Password.Click("163;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}' with focus on 'PwEntryForm.MTabEntry.Password'.", repo.PwEntryForm.MTabEntry.PasswordInfo, new RecordItemIndex(8));
            repo.PwEntryForm.MTabEntry.Password.PressKeys("{LControlKey down}{Akey}{LControlKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Amit' with focus on 'PwEntryForm.MTabEntry.Password'.", repo.PwEntryForm.MTabEntry.PasswordInfo, new RecordItemIndex(9));
            repo.PwEntryForm.MTabEntry.Password.PressKeys("Amit");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PwEntryForm.MTabEntry.Repeat' at 157;8.", repo.PwEntryForm.MTabEntry.RepeatInfo, new RecordItemIndex(10));
            repo.PwEntryForm.MTabEntry.Repeat.Click("157;8");
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}' with focus on 'PwEntryForm.MTabEntry.Repeat'.", repo.PwEntryForm.MTabEntry.RepeatInfo, new RecordItemIndex(11));
            //repo.PwEntryForm.MTabEntry.Repeat.PressKeys("{LControlKey down}{Akey}{LControlKey up}");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '' on item 'PwEntryForm.MTabEntry.Repeat'.", repo.PwEntryForm.MTabEntry.RepeatInfo, new RecordItemIndex(12));
            repo.PwEntryForm.MTabEntry.Repeat.Element.SetAttributeValue("Text", "");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Amit' with focus on 'PwEntryForm.MTabEntry.Repeat'.", repo.PwEntryForm.MTabEntry.RepeatInfo, new RecordItemIndex(13));
            repo.PwEntryForm.MTabEntry.Repeat.PressKeys("Amit");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PwEntryForm.MTabEntry.URL' at 147;7.", repo.PwEntryForm.MTabEntry.URLInfo, new RecordItemIndex(14));
            repo.PwEntryForm.MTabEntry.URL.Click("147;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'www.KeePass.Com' with focus on 'PwEntryForm.MTabEntry.URL'.", repo.PwEntryForm.MTabEntry.URLInfo, new RecordItemIndex(15));
            repo.PwEntryForm.MTabEntry.URL.PressKeys("www.KeePass.Com");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PwEntryForm.MTabEntry.Notes' at 28;22.", repo.PwEntryForm.MTabEntry.NotesInfo, new RecordItemIndex(16));
            repo.PwEntryForm.MTabEntry.Notes.Click("28;22");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'This is for Testing Purpose.' with focus on 'PwEntryForm.MTabEntry.Notes'.", repo.PwEntryForm.MTabEntry.NotesInfo, new RecordItemIndex(17));
            repo.PwEntryForm.MTabEntry.Notes.PressKeys("This is for Testing Purpose.");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PwEntryForm.MBtnOK' at 37;10.", repo.PwEntryForm.MBtnOKInfo, new RecordItemIndex(18));
            repo.PwEntryForm.MBtnOK.Click("37;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainForm.Save' at 13;10.", repo.MainForm.SaveInfo, new RecordItemIndex(19));
            repo.MainForm.Save.Click("13;10");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}