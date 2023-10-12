using System;
using System.Reflection;

using R5T.T0132;


namespace R5T.T0226
{
    [FunctionalityMarker]
    public partial interface IExampleMemberOperator : IFunctionalityMarker
    {
        public void Foreach_OfAll(Action<MemberInfo> action)
        {
            var memberInfos = Instances.ExampleMemberSets.All;
            foreach (var memberInfo in memberInfos)
            {
                action(memberInfo);
            }
        }
    }
}
