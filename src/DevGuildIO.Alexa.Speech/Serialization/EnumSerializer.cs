using System;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

namespace Amazon.Speech.Serialization
{
    public static class EnumSerializer
    {
        public static string ToEnumString<T>(T type)
        {
            var enumType = typeof(T);
            if (!enumType.GetTypeInfo().IsEnum)
                throw new ArgumentException($"Type of {enumType.FullName} is not an enum.");
            var name = Enum.GetName(enumType, type);
            var field = enumType.GetField(name);
            var attr = field.GetCustomAttributes<EnumMemberAttribute>().SingleOrDefault();
            return attr != null && attr.IsValueSetExplicitly ? attr.Value : name;
        }

        public static T ToEnum<T>(string str)
        {
            var enumType = typeof(T);
            if (!enumType.GetTypeInfo().IsEnum)
                throw new ArgumentException($"Type of {enumType.FullName} is not an enum.");
            foreach (var name in Enum.GetNames(enumType))
            {
                var field = enumType.GetField(name);
                var attr = field.GetCustomAttributes<EnumMemberAttribute>().SingleOrDefault();
                if (name == str || (attr != null && attr.IsValueSetExplicitly && attr.Value == str))
                {
                    return (T)Enum.Parse(enumType, name);
                }
            }
            throw new InvalidCastException($"{str} does not exist in enum {enumType.FullName}");
        }
    }
}
