using System;

using R5T.T0132;
using R5T.T0172;
using R5T.T0172.Extensions;


namespace R5T.T0226.L000.Internal
{
    [FunctionalityMarker]
    public partial interface IFilePathProvider : IFunctionalityMarker
    {
        /// <summary>
        /// Get the path of the R5T.T0226 (example types) assembly file,
        /// assuming the R5T.T0226 assembly is in the executable directory path.
        /// The R5T.T0226 assembly will be in the output directory of the currently executing executable if the R5T.T0226 project is referenced.
        /// </summary>
        public IAssemblyFilePath Get_R5T_T0226_AssemblyFilePath_InExecutableDirectory()
        {
            var assemblyFileName = Instances.AssemblyFileNameOperator.Get_AssemblyFileName(
                Instances.AssemblyNames.R5T_T0226);

            // Get the executable directory path.
            var output = Instances.ExecutablePathOperator.Get_Path_ExecutableDirectoryRelative(
                assemblyFileName.Value)
                .ToAssemblyFilePath();

            return output;
        }
    }
}
