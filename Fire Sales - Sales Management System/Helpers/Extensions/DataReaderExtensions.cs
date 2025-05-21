using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Reflection;

namespace Fire_Sales___Sales_Management_System.Helpers.Extensions
{
    public static class DataReaderExtensions
    {
        public static List<T> MapToList<T>(this IDataReader reader) where T : new()
        {
            var result = new List<T>();
            var props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            var columnNames = new HashSet<string>();
            for (int i = 0; i < reader.FieldCount; i++)
                columnNames.Add(reader.GetName(i));

            while (reader.Read())
            {
                var obj = new T();
                foreach (var prop in props)
                {
                    if (!prop.CanWrite || !columnNames.Contains(prop.Name)) continue;

                    var val = reader[prop.Name];
                    if (val == DBNull.Value) continue;

                    prop.SetValue(obj, Convert.ChangeType(val, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType));
                }
                result.Add(obj);
            }

            return result;
        }
    }
}
