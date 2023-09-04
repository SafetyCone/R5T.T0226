using System;

using R5T.T0131;
using R5T.T0213;
using R5T.T0213.Extensions;


namespace R5T.T0226.L000
{
    [ValuesMarker]
    public partial interface IAssemblyNames : IValuesMarker
    {
        public IAssemblyName ExampleTypesAssemblyName => this.R5T_T0226;


        public IAssemblyName R5T_T0226 => "R5T.T0226".ToAssemblyName();
    }
}
