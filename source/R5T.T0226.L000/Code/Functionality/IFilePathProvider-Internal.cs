using System;

using R5T.T0132;
using R5T.T0172;
using R5T.T0172.Extensions;
using R5T.T0213;

namespace R5T.T0226.L000.Internal
{
    [FunctionalityMarker]
    public partial interface IFilePathProvider : IFunctionalityMarker
    {
        public IAssemblyFilePath Get_R5T_T0225_T000_AssemblyFilePath_InExecutableDirectory()
        {
            var output = this.Get_AssemblyFilePath_InExecutableDirectory(
                Instances.AssemblyNames.R5T_T0225_T000);

            return output;
        }

        /// <summary>
        /// Get the path of the R5T.T0226 (example types) assembly file,
        /// assuming the R5T.T0226 assembly is in the executable directory path.
        /// The R5T.T0226 assembly will be in the output directory of the currently executing executable if the R5T.T0226 project is referenced.
        /// </summary>
        public IAssemblyFilePath Get_R5T_T0226_AssemblyFilePath_InExecutableDirectory()
        {
            var output = this.Get_AssemblyFilePath_InExecutableDirectory(
                Instances.AssemblyNames.R5T_T0226);

            return output;
        }

        public IAssemblyFilePath Get_AssemblyFilePath_InExecutableDirectory(
            IAssemblyName assemblyName)
        {
            var assemblyFileName = Instances.AssemblyFileNameOperator.Get_AssemblyFileName(
                assemblyName);

            // Get the executable directory path.
            var output = Instances.ExecutablePathOperator._Platform.Get_Path_ExecutableDirectoryRelative(
                assemblyFileName.Value)
                .ToAssemblyFilePath();

            return output;
        }
    }
}
