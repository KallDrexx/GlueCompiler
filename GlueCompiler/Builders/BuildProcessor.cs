using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Build.Evaluation;
using Microsoft.Build.Execution;
using Microsoft.Build.Framework;

namespace GlueCompiler.Builders
{
    public class BuildProcessor
    {
        private BuildLogger _logger;

        public IEnumerable<BuildMessage> Run(string solutionPath, string buildType)
        {
            // Build the solution
            var properties = new Dictionary<string, string>();
            properties["Configuration"] = buildType;

            _logger = new BuildLogger();
            var parameters = new BuildParameters();
            parameters.Loggers = new ILogger[] { _logger };

            var request = new BuildRequestData(solutionPath, properties, null, new string[] { "Build" }, null);
            var result = BuildManager.DefaultBuildManager.Build(parameters, request);

            return _logger.BuildMessages;
        }
    }
}
