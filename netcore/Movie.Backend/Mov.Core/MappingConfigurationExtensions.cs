using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Loader;
using System.Text;

namespace Mov.Core
{
    public static class MappingConfigurationExtensions
    {
        public static IServiceCollection AddMapping(this IServiceCollection services, string libraryPattern)
        {
            IList<Assembly> profileAssemblies = new List<Assembly>();
            foreach (string libraryFile in Directory.GetFiles(AppContext.BaseDirectory, libraryPattern))
            {
                profileAssemblies.Add(AssemblyLoadContext.Default.LoadFromAssemblyPath(libraryFile));
            }
            
            return services.AddAutoMapper(profileAssemblies).AddTransient<IMapper, Mapper>();
        }
    }
}
