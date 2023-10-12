using System;


namespace R5T.T0226
{
    public class ExampleMembers : IExampleMembers
    {
        #region Infrastructure

        public static IExampleMembers Instance { get; } = new ExampleMembers();


        private ExampleMembers()
        {
        }

        #endregion
    }
}
