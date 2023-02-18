using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LBD.Utils.Extensions
{
    public static class ExtensionMethods
    {
        

        public static string GetDescription<T>(this T enumValue) where T : struct, System.Enum
        {
            Type objType = typeof(T);
            if (!objType.IsEnum)
                throw new ArgumentException("Argument must be of enum type", "enumValue");
            MemberInfo[] memberInfo = objType.GetMember(enumValue.ToString());
            if (memberInfo is not null && memberInfo.Length > 0)
            {
                var attrs = (DescriptionAttribute[])memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (attrs is not null && attrs.Length > 0)
                    return attrs[0].Description;
            }
            return enumValue.ToString();
        }

        public static T GetEnumByDescription<T>(this string value) where T : struct, Enum
        {
            Type objType = typeof(T);
            if (!objType.IsEnum)
                throw new ArgumentException("Argument must be of enum type", "enumValue");
            foreach (T enumValue in Enum.GetValues<T>())
            {
                if (enumValue.GetDescription().Equals(value))
                    return enumValue;
            }
            return default;
        }


        public static T To<T>(this object obj) where T : struct
        {
            T finalObj = new();
            try
            {
                finalObj = (T)obj;
            }
            catch (Exception e)
            {
                finalObj = (T)typeof(T).GetMethod("Parse", new[] { typeof(string) }).Invoke(null, new[] { obj });
            }
            return finalObj;
        }

    }
}
