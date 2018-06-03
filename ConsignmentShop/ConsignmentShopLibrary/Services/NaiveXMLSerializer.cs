using System;

namespace ConsignmentShopLibrary.Services
{
    public static class NaiveXMLSerializer
    {
        public static string Serialize(object target)
        {
            var result = string.Empty;

            result += "<?xml version=\"1.0\"?>";
            result += Environment.NewLine;

            var typeName = target.GetType().Name;
            var mainTagOpen =
                $"<{typeName} xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">";
            var mainTagClose = $"</{typeName}>";

            result += mainTagOpen;
            result += Environment.NewLine;

            result += SerializeNestedProperties(target);

            result += mainTagClose;

            return result;
        }

        private static string SerializeNestedProperties(object target)
        {
            var result = string.Empty;

            var props = target.GetType().GetProperties();

            foreach (var propertyInfo in props)
            {
                var isSystemType = propertyInfo.PropertyType.FullName.StartsWith("System");

                var name = propertyInfo.Name;
                var val = propertyInfo.GetValue(target, null);

                if (isSystemType)
                {
                    var valToString = val.ToString();

                    if (propertyInfo.PropertyType.FullName.StartsWith("System.Double") ||
                        propertyInfo.PropertyType.FullName.StartsWith("System.Float"))
                    {
                        valToString = valToString.Replace(",", ".");
                    }

                    if (propertyInfo.PropertyType.FullName.StartsWith("System.Boolean"))
                    {
                        valToString = valToString.ToLower();
                    }

                    result += $"   <{name}>{valToString}</{name}>";
                    result += Environment.NewLine;
                }
                else
                {
                    result += $"   <{name}>";
                    result += Environment.NewLine;

                    result += $"{SerializeNestedProperties(val)}";

                    result += $"   </{name}>";
                    result += Environment.NewLine;
                }
            }

            return result;
        }
    }
}
