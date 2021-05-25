namespace SharpUnit
{
    using System;

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class TestParamsAttribute : Attribute
    {
        public TestParamsAttribute(params object[] parameters)
        {
            Parameters = parameters;
        }

        public object[] Parameters { get; }
    }
}
