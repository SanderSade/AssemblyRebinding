## AssemblyRebinding

If you are have been programming .NET for a while, chances are that these are very familiar messages:

```
1>  Consider app.config remapping of assembly "System.Runtime.Serialization.Primitives, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" from Version "4.0.10.0" [C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.2\Facades\System.Runtime.Serialization.Primitives.dll] to Version "4.2.0.0" [C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\MSBuild\Microsoft\Microsoft.NET.Build.Extensions\net461\lib\System.Runtime.Serialization.Primitives.dll] to solve conflict and get rid of warning.
1>  Consider app.config remapping of assembly "System.Runtime.Serialization.Xml, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" from Version "4.0.10.0" [C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.2\Facades\System.Runtime.Serialization.Xml.dll] to Version "4.1.3.0" [C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\MSBuild\Microsoft\Microsoft.NET.Build.Extensions\net461\lib\System.Runtime.Serialization.Xml.dll] to solve conflict and get rid of warning.
1>  Consider app.config remapping of assembly "System.Security.Cryptography.Algorithms, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" from Version "0.0.0.0" [] to Version "4.3.0.0" [C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\MSBuild\Microsoft\Microsoft.NET.Build.Extensions\net461\lib\System.Security.Cryptography.Algorithms.dll] to solve conflict and get rid of warning.
```

These messages during build are especially common after changing the target .NET framework. Visual Studio is supposed to fix these by itself if `<AutoGenerateBindingRedirects>true</AutoGenerateBindingRedirects>` is true, but unfortunately this isn't the case.

Current AsssemblyRebinding tool processes these messages and puts out binding redirect entries suitable for App.config or Web.config:

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

If the "from" version is 0.0.0.0, AssemblyRebinding sets maximum "oldVersion" value to 255.255.255.255, e.g. `oldVersion="0.0.0.0-255.255.255.255"`

#### Version info
* 2019-01-20 Initial version
