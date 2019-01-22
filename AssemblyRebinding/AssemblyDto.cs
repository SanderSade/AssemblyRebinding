namespace Sander.AssemblyRebinding
{
	internal sealed class AssemblyDto
	{
		internal string Name { get; set; }
		internal string Culture { get; set; }
		internal string PublicKeyToken { get; set; }
		internal string FromVersion { get; set; }
		internal string ToVersion { get; set; }

		internal bool IsValid() => !string.IsNullOrWhiteSpace(Name) && !string.IsNullOrWhiteSpace(ToVersion);


		public override string ToString()
		{
			return
$@"<dependentAssembly>
	<assemblyIdentity name=""{Name}"" publicKeyToken=""{PublicKeyToken}"" culture=""{Culture}"" />
	<bindingRedirect oldVersion=""0.0.0.0-{FromVersion}"" newVersion=""{ToVersion}""/>
</dependentAssembly>";
		}
	}
}
