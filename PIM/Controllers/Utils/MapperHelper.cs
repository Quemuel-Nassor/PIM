using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace PIM.Controllers.Utils
{
    public static class MapperHelper
    {
        public static T MapFromDb<T>(this MySqlDataReader result) where T : new()
        {
            T data = new T();

            try
            {
                if (result.HasRows)
                {
                    foreach (var item in typeof(T).GetProperties())
                    {
                        var value = result[item.Name];
                        if (value != null) item.SetValue(data, value);
                    }
                }
                else
                {
                    data = default;
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine($"MapperHelper | MapFromDb | error: {e.Message}");
            }

            return data;
        }

        public static string MapToInsertDb<T>(this T input)
        {
            List<string> columns = new List<string>();
            List<string> values = new List<string>();

            try
            {
                foreach (PropertyInfo item in typeof(T).GetProperties())
                {
                    var value = item.GetValue(input);
                    var type = value.GetType();

                    string stringValue = value.ToString();

                    if (value != null && stringValue != "0" && stringValue != DateTime.MinValue.ToString())
                    {
                        columns.Add(item.Name);

                        if (type == typeof(string) || type == typeof(DateTime))
                        {
                            values.Add($"'{value}'");
                        }
                        else if (type == typeof(Byte) || type == typeof(SByte) || type == typeof(UInt16) || type == typeof(UInt32) || type == typeof(UInt64) || type == typeof(Int16) || type == typeof(Int32) || type == typeof(Int64) || type == typeof(Decimal) || type == typeof(Double) || type == typeof(Single))
                        {
                            values.Add(value.ToString());
                        }
                        else
                        {
                            values.Add(Convert.ToInt32(value).ToString());
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine($"MapperHelper | MapToDb | error: {e.Message}");
            }

            return $"({string.Join(",", columns)}) VALUES ({string.Join(",", values)})";
        }

        public static string MapToUpdateDb<T>(this T input)
        {
            string sqlStatement = string.Empty;

            try
            {
                foreach (PropertyInfo item in typeof(T).GetProperties())
                {
                    var value = item.GetValue(input);
                    var type = value.GetType();

                    string stringValue = value.ToString();

                    if (value != null && stringValue != "0" && stringValue != DateTime.MinValue.ToString())
                    {
                        if (type == typeof(string) || type == typeof(DateTime))
                        {
                            sqlStatement = $"{item.Name}='{value}'";
                        }
                        else if (type == typeof(Byte) || type == typeof(SByte) || type == typeof(UInt16) || type == typeof(UInt32) || type == typeof(UInt64) || type == typeof(Int16) || type == typeof(Int32) || type == typeof(Int64) || type == typeof(Decimal) || type == typeof(Double) || type == typeof(Single))
                        {
                            sqlStatement = $"{item.Name}={value}";
                        }
                        else
                        {
                            sqlStatement = $"{item.Name}={Convert.ToInt32(value)}";

                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine($"MapperHelper | MapToDb | error: {e.Message}");
            }

            return sqlStatement;
        }
    }
}
