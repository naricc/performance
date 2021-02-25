using BenchmarkDotNet.Toolchains;
using BenchmarkDotNet.Toolchains.DotNetCli;
using BenchmarkDotNet.Characteristics;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Portability;



namespace BenchmarkDotNet.Extensions.AotLLVM
{
    public class AotLLVMToolChain : Toolchain
    {

        public AotLLVMToolChain(string name, IGenerator generator, IBuilder builder, IExecutor executor)
            : base(name, generator, builder, executor)
        {

        }

    }
}
