using System.Reflection;
using JetBrains.ActionManagement;
#if !R9
using JetBrains.Application.PluginSupport;
#endif

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("ReReflection")]
[assembly: AssemblyDescription("A set of refactoring for Reflection API")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Yuriy Zanichkovskyy")]
[assembly: AssemblyProduct("ReReflection")]
[assembly: AssemblyCopyright("Copyright © Yuriy Zanichkovskyy, 2013")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

// The following information is displayed by ReSharper in the Plugins dialog
#if !R9
[assembly: PluginTitle("ReReflection")]
[assembly: PluginDescription("A set of refactoring for Reflection API")]
[assembly: PluginVendor("Yuriy Zanichkovskyy")]
#endif

[assembly: ActionsXml("ReSharper.Reflection.resources.actions.xml")]
