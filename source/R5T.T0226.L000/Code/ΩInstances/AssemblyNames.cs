using System;


namespace R5T.T0226.L000
{
    public class AssemblyNames : IAssemblyNames
    {
        #region Infrastructure

        public static IAssemblyNames Instance { get; } = new AssemblyNames();


        private AssemblyNames()
        {
        }

        #endregion
    }
}
