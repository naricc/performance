using System;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Toolchains;
using BenchmarkDotNet.Toolchains.Results;
using BenchmarkDotNet.Running;


namespace BenchmarkDotNet.Extensions.AotLLVM
{
    public class AotLLVMBuilder : IBuilder
    {
        private readonly IBuilder firstPassBuilder;

        public AotLLVMBuilder(IBuilder firstBuilder)
        {
            firstPassBuilder = firstBuilder;
        }

        public BuildResult Build(GenerateResult generateResult, BuildPartition buildPartition, ILogger logger)
        {
            BuildResult buildResult = firstPassBuilder.Build(generateResult, buildPartition, logger);

            if (buildResult.IsBuildSuccess)
            {
                PreCompile(buildPartition.ProgramName, generateResult.ArtifactsPaths.BuildArtifactsDirectoryPath);
            }

            return buildResult;
        }

	    public void PreCompile(string programName, string projectRoot)
	    {
		    Console.WriteLine("Got to here.\n");
	    } 

        
    }
}
