using System;

using R5T.T0131;
using R5T.T0172;


namespace R5T.T0226.L000
{
    [ValuesMarker]
    public partial interface IFilePaths : IValuesMarker
    {
        public IAssemblyFilePath ExampleAssemblyFilePath => Instances.FilePathProvider.Get_ExampleTypesAssemblyFilePath();
    }
}
