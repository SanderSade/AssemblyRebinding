using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("AssemblyRebindingTests")]
namespace Sander.AssemblyRebinding
{
	public static class Rebinder
	{
		public static List<string> Run(ICollection<string> strings, Action<LogLevel, string> loggerAction = null)
		{
			if (strings == null || strings.Count == 0)
			{
				loggerAction?.Invoke(LogLevel.Fatal, "Input is null or doesn't contain any strings!");
				return null;
			}

			loggerAction?.Invoke(LogLevel.Information, $"Input is {strings.Count} strings");

			var result = new List<string>(strings.Count);
			result.AddRange(strings.Select(line => ProcessLine(line, loggerAction)));

			result = result.Where(x => !string.IsNullOrWhiteSpace(x)).ToList();

			loggerAction?.Invoke(LogLevel.Information, $"Output is {result.Count} assemblies");
			return result;
		}

		//1>  Consider app.config remapping of assembly "System.Xml.XmlSerializer, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" from Version "4.0.10.0"
		//[C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.2\Facades\System.Xml.XmlSerializer.dll] to Version "4.0.11.0"
		//[C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\MSBuild\Microsoft\Microsoft.NET.Build.Extensions\net461\lib\System.Xml.XmlSerializer.dll] to solve conflict and get rid of warning.
		private static string ProcessLine(string line, Action<LogLevel, string> loggerAction)
		{
			if (string.IsNullOrWhiteSpace(line))
			{
				loggerAction?.Invoke(LogLevel.Warning, "Line is null or whitespace");
				return null;
			}

			try
			{
				var assembly = new AssemblyDto();

				assembly.Name = GetBetween(line, "assembly \"", ",");
				assembly.Culture = GetBetween(line, "Culture=", ",");
				assembly.PublicKeyToken = GetBetween(line, "PublicKeyToken=", "\"");
				assembly.FromVersion = GetBetween(line, " from Version \"", "\"");
				assembly.ToVersion = GetBetween(line, " to Version \"", "\"");

				if (!assembly.IsValid())
				{
					loggerAction.Invoke(LogLevel.Error, $"Failed to get valid information from line: {line}");
					return null;
				}

				if (string.Compare(assembly.FromVersion, "0.0.0.0", StringComparison.OrdinalIgnoreCase) == 0)
					assembly.FromVersion = "255.255.255.255";

				return assembly.ToString();
			}
			catch (Exception ex)
			{
				loggerAction?.Invoke(LogLevel.Error, $@"Error parsing line: {line}
Error: {ex.Message}
Exception: {ex}");
				return null;
			}
		}

		private static string GetBetween(string line, string startString, string endString)
		{
			var start = line.IndexOf(startString, StringComparison.Ordinal);

			if (start == -1)
				return null;

			start += startString.Length;
			var end = line.IndexOf(endString, start, StringComparison.Ordinal);

			if (end == -1)
				return null;

			return line.Substring(start, end - start).Trim();

		}
	}
}
