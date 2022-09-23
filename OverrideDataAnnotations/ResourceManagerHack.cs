using System.Reflection;
using System.Resources;
using OverrideDataAnnotations.Resources;

namespace OverrideDataAnnotations;

public static class ResourceManagerHack
{
    public static void OverrideComponentModelAnnotationsResourceManager()
    {
        EnsureAssemblyIsLoaded();

        var resourceManagerFieldInfo = GetResourceManagerFieldInfo();
        var resourceManager = GetNewResourceManager();

        resourceManagerFieldInfo.SetValue(null, resourceManager);
    }

    private static FieldInfo GetResourceManagerFieldInfo()
    {
        var assemblies = AppDomain.CurrentDomain.GetAssemblies();
        var assembly = assemblies.First(assembly => assembly!.FullName!.StartsWith("System.ComponentModel.Annotations,"));
        var result = assembly.GetType("System.SR")!.GetField("s_resourceManager", BindingFlags.Static | BindingFlags.NonPublic);

        return result!;
    }
    internal static ResourceManager GetNewResourceManager()
    {
        return new ResourceManager(typeof(DataAnnotationsResources).FullName!, typeof(DataAnnotationsResources).Assembly);
    }
    private static void EnsureAssemblyIsLoaded()
    {
        var _ = typeof(System.ComponentModel.DataAnnotations.RequiredAttribute);
    }
}
