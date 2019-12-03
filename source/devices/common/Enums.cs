using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Devices.Common
{
    public enum DeviceType
    {
        [StringValue("Verifone Device")]
        Verifone = 1,
        [StringValue("IdTech Device")]
        IdTech = 2,
        [StringValue("Simulator Device")]
        Simulator = 3,
        [StringValue("Mock Device")]
        Mock = 4
    }

    public enum DeviceDiscovery
    {
        [StringValue("Unable to get a device")]
        NoDeviceAvailable = 1
    }

    [System.AttributeUsage(System.AttributeTargets.All, AllowMultiple = false, Inherited = true)]
    public class StringValueAttribute : Attribute
    {
        private string _value;
        public StringValueAttribute(string value)
        {
            _value = value;
        }

        public string Value
        {
            get { return _value; }
        }

        public static string GetStringValue(Enum value)
        {
            if (value == null)
                return string.Empty;

            Type type = value.GetType();
            FieldInfo fi = type.GetRuntimeField(value.ToString());
            return (fi.GetCustomAttributes(typeof(StringValueAttribute), false).FirstOrDefault() as StringValueAttribute).Value;
        }
    }
}
