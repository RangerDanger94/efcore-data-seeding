using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SeedData.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace Microsoft.EntityFrameworkCore
{
    public static class EntityTypeBuilderExtensions
    {
        public static DataBuilder<T> HasEnumData<T>(this EntityTypeBuilder<T> builder, Type enumType)
            where T : class, IEntityWithId, ILookupEntity, new()
        {
            var result = new List<T>();
            foreach(var @enum in Enum.GetValues(enumType))
            {
                var code = @enum.ToString();
                var descr = @enum.ToString();

                var descrAttr = @enum.GetType()
                    .GetField(@enum.ToString())
                    .GetCustomAttribute<DescriptionAttribute>();

                if (descrAttr != null)
                {
                    descr = descrAttr.Description;
                }

                result.Add(new T { Id = (int)@enum, Code = code, Description = descr });
            }

            return builder.HasData(result.ToArray());
        }
    }
}
