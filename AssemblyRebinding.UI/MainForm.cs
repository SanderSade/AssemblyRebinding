using System;
using System.Linq;
using System.Windows.Forms;

namespace Sander.AssemblyRebinding.UI
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private bool _hasFatal;

		private void BtProcess_Click(object sender, System.EventArgs e)
		{
			textLog.Clear();
			textOutput.Clear();
			_hasFatal = false;

			var inputText = textInput.Lines.Where(x => !string.IsNullOrWhiteSpace(x)).ToList();
			if (inputText.Count == 0)
			{
				Log(LogLevel.Fatal, "No valid lines in input!");
				return;
			}


			var result = Rebinder.Run(inputText, Log);

			textOutput.Lines = result.ToArray();
			if (!_hasFatal)
				MainTabs.SelectedTab = tabOutput;
		}


		private void Log(LogLevel logLevel, string message)
		{
			textLog.AppendText($"[{DateTimeOffset.Now}] [{logLevel}] {message}{Environment.NewLine}");

			if (logLevel == LogLevel.Fatal)
			{
				MainTabs.SelectedTab = tabLog;
				_hasFatal = true;
			}
		}

		private void btClear_Click(object sender, EventArgs e)
		{
			textLog.Clear();
			textOutput.Clear();
			textInput.Clear();
		}
	}
}
