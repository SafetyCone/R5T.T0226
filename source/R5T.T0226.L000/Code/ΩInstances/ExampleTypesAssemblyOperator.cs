using System;


namespace R5T.T0226.L000
{
    public class ExampleTypesAssemblyOperator : IExampleTypesAssemblyOperator
    {
        #region Infrastructure

        public static IExampleTypesAssemblyOperator Instance { get; } = new ExampleTypesAssemblyOperator();


        private ExampleTypesAssemblyOperator()
        {
        }

        #endregion
    }
}
