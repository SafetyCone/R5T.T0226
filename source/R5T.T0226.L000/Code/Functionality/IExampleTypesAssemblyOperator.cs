using System;
using System.Reflection;

using R5T.T0132;


namespace R5T.T0226.L000
{
    [FunctionalityMarker]
    public partial interface IExampleTypesAssemblyOperator : IFunctionalityMarker
    {
        public void In_AssemblyContext(
            Action<Assembly> action)
        {
            var assemblyFilePath = Instances.FilePaths.ExampleAssemblyFilePath;

            Instances.ReflectionOperator.In_AssemblyContext(
                assemblyFilePath.Value,
                action);
        }
    }
}
