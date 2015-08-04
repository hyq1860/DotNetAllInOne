using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using RazorEngine.Templating;

namespace RazorEngineDemo
{
    /// <summary>
    /// 
    /// </summary>
    public class RazorTemplateManager : ITemplateManager
    {
        public ITemplateSource Resolve(ITemplateKey key)
        {
            // Resolve your template here (ie read from disk)
            // if the same templates are often read from disk you propably want to do some caching here.
            //此处获取模板地址
            string template = "Hello @Model.Name, welcome to RazorEngine!";
            // Provide a non-null file to improve debugging
            return new LoadedTemplateSource(template, null);
        }

        public ITemplateKey GetKey(string name, ResolveType resolveType, ITemplateKey context)
        {
            // If you can have different templates with the same name depending on the 
            // context or the resolveType you need your own implementation here!
            // Otherwise you can just use NameOnlyTemplateKey.
            return new NameOnlyTemplateKey(name, resolveType, context);
            // template is specified by full path
            //return new FullPathTemplateKey(name, fullPath, resolveType, context);
        }

        public void AddDynamic(ITemplateKey key, ITemplateSource source)
        {
            // You can disable dynamic templates completely. 
            // This just means all convenience methods (Compile and RunCompile) with
            // a TemplateSource will no longer work (they are not really needed anyway).
            //throw new NotImplementedException("dynamic templates are not supported!");
        }
    }

    ///// <summary>
    ///// 
    ///// </summary>
    //public class DefaultCachingProvider : ICachingProvider
    //{
    //    private readonly ConcurrentDictionary<string, ConcurrentDictionary<Type, ICompiledTemplate>> _cache =
    //    new ConcurrentDictionary<string, ConcurrentDictionary<Type, ICompiledTemplate>>();

    //    private readonly TypeLoader _loader;
    //    private readonly ConcurrentBag<Assembly> _assemblies = new ConcurrentBag<Assembly>();

    //    /// <summary>
    //    /// Initializes a new instance of the <see cref="DefaultCachingProvider"/> class.
    //    /// </summary>
    //    public DefaultCachingProvider()
    //    {
    //        _loader = new TypeLoader(AppDomain.CurrentDomain, _assemblies);
    //    }

    //    /// <summary>
    //    /// The manages <see cref="TypeLoader"/>. See <see cref="ICachingProvider.TypeLoader"/>
    //    /// </summary>
    //    public TypeLoader TypeLoader
    //    {
    //        get
    //        {
    //            return _loader;
    //        }
    //    }

    //    /// <summary>
    //    /// Get the key used within a dictionary for a modelType.
    //    /// </summary>
    //    public static Type GetModelTypeKey(Type modelType)
    //    {
    //        if (modelType == null ||
    //            typeof(System.Dynamic.IDynamicMetaObjectProvider).IsAssignableFrom(modelType))
    //        {
    //            return typeof(System.Dynamic.DynamicObject);
    //        }
    //        return modelType;
    //    }

    //    private void CacheTemplateHelper(ICompiledTemplate template, ITemplateKey templateKey, Type modelTypeKey)
    //    {
    //        var uniqueKey = templateKey.GetUniqueKeyString();
    //        _cache.AddOrUpdate(uniqueKey, key =>
    //        {
    //            // new item added
    //            _assemblies.Add(template.TemplateAssembly);
    //            var dict = new ConcurrentDictionary<Type, ICompiledTemplate>();
    //            dict.AddOrUpdate(modelTypeKey, template, (t, old) => template);
    //            return dict;
    //        }, (key, dict) =>
    //        {
    //            dict.AddOrUpdate(modelTypeKey, t =>
    //            {
    //                // new item added (template was not compiled with the given type).
    //                _assemblies.Add(template.TemplateAssembly);
    //                return template;
    //            }, (t, old) =>
    //            {
    //                // item was already added before
    //                return template;
    //            });
    //            return dict;
    //        });
    //    }

    //    /// <summary>
    //    /// Caches a template. See <see cref="ICachingProvider.CacheTemplate"/>.
    //    /// </summary>
    //    /// <param name="template"></param>
    //    /// <param name="templateKey"></param>
    //    public void CacheTemplate(ICompiledTemplate template, ITemplateKey templateKey)
    //    {
    //        var modelTypeKey = GetModelTypeKey(template.ModelType);
    //        CacheTemplateHelper(template, templateKey, modelTypeKey);
    //        var typeArgs = template.TemplateType.BaseType.GetGenericArguments();
    //        if (typeArgs.Length > 0)
    //        {
    //            var alternativeKey = GetModelTypeKey(typeArgs[0]);
    //            if (alternativeKey != modelTypeKey)
    //            {
    //                // could be a template with an @model directive.
    //                CacheTemplateHelper(template, templateKey, typeArgs[0]);
    //            }
    //        }
    //    }

    //    /// <summary>
    //    /// Try to retrieve a template from the cache. See <see cref="ICachingProvider.TryRetrieveTemplate"/>.
    //    /// </summary>
    //    /// <param name="templateKey"></param>
    //    /// <param name="modelType"></param>
    //    /// <param name="compiledTemplate"></param>
    //    /// <returns></returns>
    //    public bool TryRetrieveTemplate(ITemplateKey templateKey, Type modelType, out ICompiledTemplate compiledTemplate)
    //    {
    //        compiledTemplate = null;
    //        var uniqueKey = templateKey.GetUniqueKeyString();
    //        var modelTypeKey = GetModelTypeKey(modelType);
    //        ConcurrentDictionary<Type, ICompiledTemplate> dict;
    //        if (!_cache.TryGetValue(uniqueKey, out dict))
    //        {
    //            return false;
    //        }
    //        return dict.TryGetValue(modelTypeKey, out compiledTemplate);
    //    }

    //    /// <summary>
    //    /// Dispose the instance.
    //    /// </summary>
    //    public void Dispose()
    //    {
    //        _loader.Dispose();
    //    }
    //}
}
