using System;

namespace ADONET.Models
{
    public class Migrate
    {
        public static string GetColumnFromModel(Type type)
        {
            var properties = type.GetProperties();
            var query = $"CREATE TABLE {type.Name} (";

            foreach (var property in properties)
            {
                if (property.PropertyType.Name == "Int32")
                    query += $"{property.Name} int,";
                else if (property.PropertyType.Name == "String")
                {
                    query += $"{property.Name} nvarchar(100),";
                    Console.WriteLine(property.Name + " " + property.PropertyType.Name);
                }
            }
            query = query.Substring(0, query.Length - 1);

            query += ");";

            return query;
        }




    }
}
