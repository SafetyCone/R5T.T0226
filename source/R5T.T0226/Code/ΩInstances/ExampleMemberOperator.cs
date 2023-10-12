using System;


namespace R5T.T0226
{
    public class ExampleMemberOperator : IExampleMemberOperator
    {
        #region Infrastructure

        public static IExampleMemberOperator Instance { get; } = new ExampleMemberOperator();


        private ExampleMemberOperator()
        {
        }

        #endregion
    }
}
