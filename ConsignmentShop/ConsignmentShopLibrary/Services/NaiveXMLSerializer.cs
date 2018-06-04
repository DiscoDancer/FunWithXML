using System;
using System.Collections;

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

        private static string SerializeNestedProperties(object target, string tabs = "\t")
        {
            var result = string.Empty;

            var props = target.GetType().GetProperties();

            foreach (var propertyInfo in props)
            {
                // bool, int, float, double, string
                var isSimpleSystemType = propertyInfo.PropertyType.FullName.StartsWith("System") 
                                         && !propertyInfo.PropertyType.FullName.Contains("Collections");

                // Array, List, ...
                // beware: string is collection too.
                var isCollection = typeof(IEnumerable).IsAssignableFrom(propertyInfo.PropertyType);

                var name = propertyInfo.Name;
                var val = propertyInfo.GetValue(target, null);

                if (isSimpleSystemType)
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

                    result += $"{tabs}<{name}>{valToString}</{name}>";
                    result += Environment.NewLine;
                }
                else if (isCollection)
                {
                    var valCollection = val as IEnumerable;

                    result += $"{tabs}<{name}>";
                    result += Environment.NewLine;

                    foreach (var child in valCollection)
                    {
                        var itemName = child.GetType().Name;

                        var isCustomItem = child is Item;
                        if (isCustomItem)
                        {
                            result += $"{tabs + "\t"}<Item xsi:type=\"{itemName}\">";
                            result += Environment.NewLine;

                            result += $"{SerializeNestedProperties(child, tabs + "\t" + "\t")}";

                            result += $"{tabs + "\t"}</Item>";
                            result += Environment.NewLine;
                        }
                        else
                        {
                            result += $"{tabs + "\t"}<{itemName}>";
                            result += Environment.NewLine;

                            result += $"{SerializeNestedProperties(child, tabs + "\t" + "\t")}";

                            result += $"{tabs + "\t"}</{itemName}>";
                            result += Environment.NewLine;
                        }
                    }

                    result += $"{tabs}</{name}>";
                    result += Environment.NewLine;
                }
                else
                {
                    result += $"{tabs}<{name}>";
                    result += Environment.NewLine;

                    result += $"{SerializeNestedProperties(val, tabs + "\t")}";

                    result += $"{tabs}</{name}>";
                    result += Environment.NewLine;
                }
            }

            return result;
        }
    }
}
