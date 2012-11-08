using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Build.Utilities;
using Microsoft.Build.Framework;

namespace GlueCompiler.Builders
{
    public class BuildLogger : Logger
    {
        public List<BuildMessage> BuildMessages { get; private set; }

        public override void Initialize(IEventSource eventSource)
        {
            BuildMessages = new List<BuildMessage>();

            // Hook up the events
            eventSource.ErrorRaised += ErrorRaisedHandler;
            eventSource.WarningRaised += WarningRaisedHandler;
        }

        private void ErrorRaisedHandler(object sender, BuildErrorEventArgs args)
        {
            BuildMessages.Add(new BuildMessage
            {
                Type = BuildMessageType.Error,
                LineNumber = args.LineNumber,
                ColumnNumber = args.ColumnNumber,
                File = args.File,
                Message = args.Message,
                Project = args.ProjectFile
            });
        }

        private void WarningRaisedHandler(object sender, BuildWarningEventArgs args)
        {
            BuildMessages.Add(new BuildMessage
            {
                Type = BuildMessageType.Warning,
                LineNumber = args.LineNumber,
                ColumnNumber = args.ColumnNumber,
                File = args.File,
                Message = args.Message,
                Project = args.ProjectFile
            });
        }
    }
}
