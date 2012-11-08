using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GlueCompiler.Builders
{
    public class BuildMessage
    {
        public BuildMessageType Type { get; set; }
        public string File { get; set; }
        public int LineNumber { get; set; }
        public int ColumnNumber { get; set; }
        public string Project { get; set; }
        public string Message { get; set; }
    }
}
