## AssemblyRebinding

[Get AssemblyRebinding from Releases](https://github.com/SanderSade/AssemblyRebinding/releases)

If you are have been programming .NET, chances are that these are very familiar messages:

```
1>  Consider app.config remapping of assembly "System.Runtime.Serialization.Primitives, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" from Version "4.0.10.0" [C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.2\Facades\System.Runtime.Serialization.Primitives.dll] to Version "4.2.0.0" [C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\MSBuild\Microsoft\Microsoft.NET.Build.Extensions\net461\lib\System.Runtime.Serialization.Primitives.dll] to solve conflict and get rid of warning.
1>  Consider app.config remapping of assembly "System.Runtime.Serialization.Xml, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" from Version "4.0.10.0" [C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.2\Facades\System.Runtime.Serialization.Xml.dll] to Version "4.1.3.0" [C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\MSBuild\Microsoft\Microsoft.NET.Build.Extensions\net461\lib\System.Runtime.Serialization.Xml.dll] to solve conflict and get rid of warning.
1>  Consider app.config remapping of assembly "System.Security.Cryptography.Algorithms, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" from Version "0.0.0.0" [] to Version "4.3.0.0" [C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\MSBuild\Microsoft\Microsoft.NET.Build.Extensions\net461\lib\System.Security.Cryptography.Algorithms.dll] to solve conflict and get rid of warning.
```
![VS warning](https://raw.githubusercontent.com/dotnet/docs/master/docs/framework/configure-apps/media/clr-assemblyrefwarning.png)

These messages during build are especially common after changing the target .NET framework. Visual Studio is supposed to fix these by itself when `<AutoGenerateBindingRedirects>true</AutoGenerateBindingRedirects>` in the .csproj is true, but unfortunately this isn't the case.

AsssemblyRebinding utility processes these messages and puts out the binding redirect (remapping) entries suitable for App.config or Web.config:

```
<dependentAssembly>
	<assemblyIdentity name="System.Runtime.Serialization.Primitives" publicKeyToken="b03f5f7f11d50a3a" culture="neutral" />
	<bindingRedirect oldVersion="0.0.0.0-4.0.10.0" newVersion="4.2.0.0"/>
</dependentAssembly>
<dependentAssembly>
	<assemblyIdentity name="System.Runtime.Serialization.Xml" publicKeyToken="b03f5f7f11d50a3a" culture="neutral" />
	<bindingRedirect oldVersion="0.0.0.0-4.0.10.0" newVersion="4.1.3.0"/>
</dependentAssembly>
<dependentAssembly>
	<assemblyIdentity name="System.Security.Cryptography.Algorithms" publicKeyToken="b03f5f7f11d50a3a" culture="neutral" />
	<bindingRedirect oldVersion="0.0.0.0-255.255.255.255" newVersion="4.3.0.0"/>
</dependentAssembly>
```

![AssemblyRebinding-screenshot](https://user-images.githubusercontent.com/18664267/51531845-3f98ca80-1e47-11e9-90c3-9e422902712f.png)


* If the "from" version is 0.0.0.0, AssemblyRebinding sets maximum "oldVersion" value to 255.255.255.255, e.g. `oldVersion="0.0.0.0-255.255.255.255"`
* I recommended to run in NuGet Package Manager Console the redirect updating command, `Add-BindingRedirect *` after adding binding redirects
* .NET 4.6.2 or newer required to run AssemblyRebinding
* Read more from https://docs.microsoft.com/en-us/dotnet/framework/configure-apps/redirect-assembly-versions 



#### Version info
* 2019-01-20 1.0.0 Initial version
