using MySql.Data.MySqlClient;
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
                foreach (var item in typeof(T).GetProperties())
                {
                    var value = result[item.Name];
                    if (value != null) item.SetValue(data, value);
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine($"MapperHelper | MapFromDb | error: {e.Message}");
            }

            return data;
        }

        //public static T MapFromDb<T>(this DataRow row) where T : new()
        //{
        //    T data = new T();

        //    try
        //    {
        //        foreach (var item in typeof(T).GetProperties())
        //        {
        //            var value = row[item.Name];
        //            if (value != null) item.SetValue(data, value.ToString());
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.Error.WriteLine($"MapperHelper | MapFromDb | error: {e.Message}");
        //    }

        //    return data;
        //}

        public static string MapToInsertDb<T>(this T input)
        {
            List<string> columns = new List<string>();
            List<string> values = new List<string>();

            try
            {
                foreach (PropertyInfo item in typeof(T).GetProperties())
                {
                    var value = item.GetValue(input);

                    if (value != null)
                    {
                        columns.Add(item.Name);
                        values.Add(value.GetType() == typeof(string) ? $"'{item.GetValue(input)}'" : item.GetValue(input).ToString());
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

                    if (value != null)
                    {
                        sqlStatement = $"{item.Name}={(value.GetType() == typeof(string) ? $"'{item.GetValue(input)}'" : item.GetValue(input).ToString())}";
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
