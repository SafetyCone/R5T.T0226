using System;


namespace R5T.T0226
{
    public static class Instances
    {
        public static L0053.IEventInfoOperator EventInfoOperator => L0053.EventInfoOperator.Instance;
        public static IExampleMembers ExampleMembers => T0226.ExampleMembers.Instance;
        public static IExampleMemberSets ExampleMemberSets => T0226.ExampleMemberSets.Instance;
        public static L0053.IFieldInfoOperator FieldInfoOperator => L0053.FieldInfoOperator.Instance;
        public static L0053.IMethodInfoOperator MethodInfoOperator => L0053.MethodInfoOperator.Instance;
        public static L0053.IPropertyInfoOperator PropertyInfoOperator => L0053.PropertyInfoOperator.Instance;
        public static L0053.ITypeOperator TypeOperator => L0053.TypeOperator.Instance;
    }
}