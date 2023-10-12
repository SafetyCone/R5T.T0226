using System;
using System.Reflection;

using R5T.T0131;
using R5T.T0225.T000;

using DummyType = System.Object;


namespace R5T.T0226
{
    [ValuesMarker]
    public partial interface IExampleMembers : IValuesMarker
    {
        public Type Class_001 => typeof(Class_001);
#pragma warning disable CS0612 // Type or member is obsolete
        public Type Class_005 => typeof(Class_005);
#pragma warning restore CS0612 // Type or member is obsolete
        public Type Enumeration_000 => typeof(Enumeration_000);
        public Type GenericClass_001_Closed => typeof(GenericClass_001<string>);
        public Type GenericClass_001_Open => typeof(GenericClass_001<>);
        public Type GenericClass_002_Open => typeof(GenericClass_002<>);
        public Type GenericClass_003_Open => typeof(GenericClass_003<>);
        public Type GenericClass_004_Open => typeof(GenericClass_004<>);
        public Type GenericClass_005_Open => typeof(GenericClass_005<,>);
        public Type Interface_001 => typeof(IInterface_001);
        public Type NestedClass_001 => typeof(NestedClass_001_Parent.NestedClass_001);
        public Type NestedClass_002_Closed => typeof(NestedClass_002_Parent<int, string>.NestedClass_002);
        public Type NestedClass_002_Open => typeof(NestedClass_002_Parent<,>.NestedClass_002);
        public Type NestedClass_003_Closed => typeof(NestedClass_003_Parent<int, string>.NestedClass_003<string>);
        public Type NestedClass_003_Open => typeof(NestedClass_003_Parent<,>.NestedClass_003<>);
        public Type Structure_001 => typeof(Structure_001);

        public MethodInfo Method_001 => Instances.MethodInfoOperator.Get_MethodOf<MethodsClass_001>(nameof(MethodsClass_001.Method_001));
        public MethodInfo Method_006_1 => Instances.MethodInfoOperator.Get_MethodOf<MethodsClass_001>(
            nameof(MethodsClass_001.Method_006),
            1);
        public MethodInfo Method_020 => Instances.MethodInfoOperator.Get_MethodOf<MethodsClass_003>(nameof(MethodsClass_003.Method_020));

        public EventInfo Event_001 => Instances.EventInfoOperator.Get_EventOf<EventsClass_001>(nameof(EventsClass_001.Event_001));
        public EventInfo Event_002 => Instances.EventInfoOperator.Get_EventOf(
            typeof(EventsClass_002<>),
            nameof(EventsClass_002<DummyType>.Event_002));
        public EventInfo Event_003 => Instances.EventInfoOperator.Get_EventOf<EventsClass_003>(nameof(EventsClass_003.Event_003));

        public FieldInfo Field_001 => Instances.FieldInfoOperator.Get_FieldOf<FieldClass_001>(nameof(FieldClass_001.Field_001));
        public FieldInfo Field_002 => Instances.FieldInfoOperator.Get_FieldOf(
            typeof(FieldClass_002<>),
            nameof(FieldClass_002<DummyType>.Field_002));
#pragma warning disable CS0612 // Type or member is obsolete
        public FieldInfo Field_003 => Instances.FieldInfoOperator.Get_FieldOf<FieldClass_003>(nameof(FieldClass_003.Field_001));
#pragma warning restore CS0612 // Type or member is obsolete

        public PropertyInfo Property_001 => Instances.PropertyInfoOperator.Get_PropertyOf<PropertiesClass_001>(nameof(PropertiesClass_001.Property_001));
        public PropertyInfo Property_002 => Instances.PropertyInfoOperator.Get_PropertyOf(
            typeof(PropertiesClass_002<>),
            nameof(PropertiesClass_002<DummyType>.Property_020));
#pragma warning disable CS0612 // Type or member is obsolete
        public PropertyInfo Property_003 => Instances.PropertyInfoOperator.Get_PropertyOf<PropertiesClass_003>(nameof(PropertiesClass_003.Property_100));
#pragma warning restore CS0612 // Type or member is obsolete
    }
}
