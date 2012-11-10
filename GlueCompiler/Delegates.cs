using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GlueCompiler.Builders;

namespace GlueCompiler
{
    public delegate void CompileCompletedDelegate(IEnumerable<BuildMessage> results);
}
