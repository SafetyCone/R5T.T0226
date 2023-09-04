using System;

using R5T.T0141;


namespace R5T.T0226.Construction
{
    [DemonstrationsMarker]
    public partial interface IDemonstrations : IDemonstrationsMarker
    {
        public void Get_ExampleTypesAssemblyFilePath()
        {
            var exampleAssemblyFilePath = Instances.FilePathProvider.Get_ExampleTypesAssemblyFilePath();

            Console.WriteLine(exampleAssemblyFilePath);
        }
    }
}
