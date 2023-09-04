using System;


namespace R5T.T0226.L000
{
    public static class Instances
    {
        public static IAssemblyNames AssemblyNames => L000.AssemblyNames.Instance;
        public static L0057.IAssemblyFileNameOperator AssemblyFileNameOperator => L0057.AssemblyFileNameOperator.Instance;
        public static L0057.IExecutablePathOperator ExecutablePathOperator => L0057.ExecutablePathOperator.Instance;
    }
}