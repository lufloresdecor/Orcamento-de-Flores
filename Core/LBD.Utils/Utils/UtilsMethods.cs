using LBD.Utils.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBD.Utils.Utils
{
    public static class UtilsMethods
    {
        public static List<string> GetDescriptions<T>() where T : struct, System.Enum
        { 
            Type objType = typeof(T);
            List<string> descriptions = new List<string>();
            if (!objType.IsEnum)
                throw new TypeAccessException("Type must be a enum.");
            foreach (T enumValue in Enum.GetValues(objType))
            {
                descriptions.Add(enumValue.GetDescription());
            }
            return descriptions;
        }
    }
}
