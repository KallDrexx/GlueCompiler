using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using FlatRedBall.Glue;
using FlatRedBall.Glue.Plugins.ExportedInterfaces;
using FlatRedBall.Glue.Plugins.Interfaces;
using FlatRedBall.Glue.SaveClasses;
using FlatRedBall.Glue.Plugins;
using System.Windows.Forms;
using GlueCompiler.Controls;
using FlatRedBall.Glue.Controls;

namespace GlueCompiler
{
    [Export(typeof(PluginBase))]
    public class Plugin : PluginBase
    {
        private PluginTab _tab;
        private TabControl _container;
        private BuildUi _mainUi;

        [Import("GlueProjectSave")]
        public GlueProjectSave GlueProjectSave { get; set; }

        [Import("GlueCommands")]
        public IGlueCommands GlueCommands { get; set; }
		
		[Import("GlueState")]
		public IGlueState GlueState { get; set; }

        public override string FriendlyName { get { return "Glue Compiler"; } }
        public override Version Version { get { return new Version(1, 0); } }

        public override bool ShutDown(PluginShutDownReason reason)
        {
            // Do anything your plugin needs to do to shut down
            // or don't shut down and return false

            return true;
        }

        public override void StartUp()
        {
            InitializeBottomTabHandler = InitializeTab;
            ReactToLoadedGlux = GluxLoaded;
        }

        private void InitializeTab(TabControl tabControl)
        {
            _container = tabControl;
        }

        private void GluxLoaded()
        {
            if (_tab != null)
            {
                _container.Controls.Remove(_tab);
                _tab = null;
                _mainUi = null;
            }

            _mainUi = new BuildUi();
            _tab = new PluginTab();
            _tab.Text = "  " + FriendlyName + "  ";
            _tab.Controls.Add(_mainUi);
            _container.Controls.Add(_tab);
        }
    }
}