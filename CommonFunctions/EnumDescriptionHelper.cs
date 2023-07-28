using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace WebAPI_Wa.CommonFunctions
{
    public static class EnumDescriptionHelper
    {
        public static List<string> GetEnumDescriptions(Type enumType)
        {
            if (!enumType.IsEnum)
                throw new ArgumentException("The provided type is not an enum.");

            var enumDescriptions = new List<string>();

            foreach (var enumValue in Enum.GetValues(enumType))
            {
                string description = GetEnumDescription((Enum)enumValue);
                enumDescriptions.Add(description);
            }

            return enumDescriptions;
        }
        private static string GetEnumDescription(Enum enumValue)
        {
            FieldInfo fieldInfo = enumValue.GetType().GetField(enumValue.ToString());
            DescriptionAttribute[] attributes = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            return attributes?.FirstOrDefault()?.Description ?? enumValue.ToString();
        }
    }
}
