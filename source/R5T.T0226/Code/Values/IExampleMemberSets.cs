using System;
using System.Reflection;

using R5T.T0131;


namespace R5T.T0226
{
    [ValuesMarker]
    public partial interface IExampleMemberSets : IValuesMarker
    {
        public MemberInfo[] All => new[]
        {
            Instances.ExampleMembers.Class_001,
            Instances.ExampleMembers.Enumeration_000,
            Instances.ExampleMembers.GenericClass_001_Closed,
            Instances.ExampleMembers.GenericClass_001_Open,
            Instances.ExampleMembers.Interface_001,
            Instances.ExampleMembers.NestedClass_001,
            Instances.ExampleMembers.NestedClass_002_Closed,
            Instances.ExampleMembers.NestedClass_002_Open,
            Instances.ExampleMembers.NestedClass_003_Closed,
            Instances.ExampleMembers.NestedClass_003_Open,
            Instances.ExampleMembers.Structure_001,
        };
    }
}
