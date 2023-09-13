using System;

using R5T.T0131;
using R5T.T0213;
using R5T.T0213.Extensions;


namespace R5T.T0226.L000
{
    [ValuesMarker]
    public partial interface IAssemblyNames : IValuesMarker
    {
        public IAssemblyName ExampleTypesAssemblyName => this.R5T_T0225_T000;


        public IAssemblyName R5T_T0225_T000 => "R5T.T0225.T000".ToAssemblyName();
        public IAssemblyName R5T_T0226 => "R5T.T0226".ToAssemblyName();
    }
}
