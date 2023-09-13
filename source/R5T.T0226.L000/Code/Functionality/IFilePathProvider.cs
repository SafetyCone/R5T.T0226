using System;

using R5T.T0132;
using R5T.T0172;


namespace R5T.T0226.L000
{
    [FunctionalityMarker]
    public partial interface IFilePathProvider : IFunctionalityMarker
    {
        private static Internal.IFilePathProvider Internal => L000.Internal.FilePathProvider.Instance;


        /// <summary>
        /// Chooses <see cref="Internal.IFilePathProvider.Get_R5T_T0225_T000_AssemblyFilePath_InExecutableDirectory"/> as the default.
        /// </summary>
        public IAssemblyFilePath Get_ExampleTypesAssemblyFilePath()
        {
            var output = Internal.Get_R5T_T0225_T000_AssemblyFilePath_InExecutableDirectory();
            return output;
        }
    }
}
