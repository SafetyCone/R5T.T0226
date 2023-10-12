using System;


namespace R5T.T0226
{
    public class ExampleMemberSets : IExampleMemberSets
    {
        #region Infrastructure

        public static IExampleMemberSets Instance { get; } = new ExampleMemberSets();


        private ExampleMemberSets()
        {
        }

        #endregion
    }
}
