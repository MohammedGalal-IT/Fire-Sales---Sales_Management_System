using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Reflection;

namespace Fire_Sales___Sales_Management_System.Helpers.Extensions
{
    public static class DataReaderExtensions
    {
        public static List<T> MapToList<T>(this IDataReader reader) where T : new()
        {
            var result = new List<T>();
            var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(p => p.CanWrite)
                .ToArray();

            var readerColumns = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            for (int i = 0; i < reader.FieldCount; i++)
            {
                readerColumns.Add(reader.GetName(i));
            }

            var relevantProps = properties.Where(p => readerColumns.Contains(p.Name)).ToArray();

            while (reader.Read())
            {
                var obj = new T();
                foreach (var prop in relevantProps)
                {
                    try
                    {
                        object value = reader[prop.Name];
                        if (value == DBNull.Value) continue;

                        // معالجة خاصة للأنواع المخصصة (Enums أو أنواع أخرى)
                        if (prop.PropertyType.IsEnum)
                        {
                            prop.SetValue(obj, Enum.Parse(prop.PropertyType, value.ToString()));
                        }
                        else if (prop.PropertyType == typeof(Guid))
                        {
                            prop.SetValue(obj, Guid.Parse(value.ToString()));
                        }
                        else
                        {
                            var targetType = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
                            prop.SetValue(obj, Convert.ChangeType(value, targetType));
                        }
                    }
                    catch (Exception ex)
                    {
                        // يمكنك تسجيل الخطأ هنا إذا لزم الأمر
                        throw new InvalidOperationException($"Error mapping column {prop.Name} to property {prop.Name} of type {prop.PropertyType}", ex);
                    }
                }
                result.Add(obj);
            }

            return result;
        }
    }

}
