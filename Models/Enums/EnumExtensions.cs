using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System;
using System.Linq;
using System.Reflection;

namespace WebAPI_Wa.Models.Enums
{

        public static class EnumExtensions
        {
            public static string GetDisplayName(this Enum enumValue)
            {
                return enumValue.GetType()
                  .GetMember(enumValue.ToString())
                  .First()
                  .GetCustomAttribute<DisplayAttribute>()
                  ?.GetName();
            }

            public static string GetEnumDescription(this Enum enumValue)
            {
                var fieldInfo = enumValue.GetType().GetField(enumValue.ToString());

                var descriptionAttributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

                return descriptionAttributes.Length > 0 ? descriptionAttributes[0].Description : enumValue.ToString();
            }
        }    
}
