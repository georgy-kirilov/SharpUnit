namespace SharpUnit
{
    using System;

    [AttributeUsage(AttributeTargets.Parameter)]
    public class TestValuesAttribute : Attribute
    {
        public TestValuesAttribute(params object[] values)
        {
            Values = values;
        }

        public object[] Values { get; set; }
    }
}
