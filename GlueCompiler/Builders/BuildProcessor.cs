using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Build.Evaluation;
using Microsoft.Build.Execution;
using Microsoft.Build.Framework;
using System.Threading.Tasks;

namespace GlueCompiler.Builders
{
    public class BuildProcessor
    {
        private BuildLogger _logger;
        private CompileCompletedDelegate _compileCompletedHandler;

        public BuildProcessor(CompileCompletedDelegate compileCompletedHandler)
        {
            _compileCompletedHandler = compileCompletedHandler;
        }

        public void StartCompile(string solutionPath, string buildType)
        {
            // Create the task to run the compile in the background
            var task = new Task(() =>
            {
                // Build the solution
                var properties = new Dictionary<string, string>();
                properties["Configuration"] = buildType;

                _logger = new BuildLogger();
                var parameters = new BuildParameters();
                parameters.Loggers = new ILogger[] { _logger };

                var request = new BuildRequestData(solutionPath, properties, null, new string[] { "Build" }, null);
                var result = BuildManager.DefaultBuildManager.Build(parameters, request);

                if (_compileCompletedHandler != null)
                    _compileCompletedHandler(_logger.BuildMessages);
            });

            task.Start();
        }
    }
}
