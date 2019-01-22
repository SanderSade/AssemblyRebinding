namespace Sander.AssemblyRebinding.UI
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.HeaderPanel = new System.Windows.Forms.Panel();
			this.btClear = new System.Windows.Forms.Button();
			this.BtProcess = new System.Windows.Forms.Button();
			this.LbIntro = new System.Windows.Forms.Label();
			this.MainTabs = new System.Windows.Forms.TabControl();
			this.tabInput = new System.Windows.Forms.TabPage();
			this.textInput = new System.Windows.Forms.TextBox();
			this.tabOutput = new System.Windows.Forms.TabPage();
			this.textOutput = new System.Windows.Forms.TextBox();
			this.tabLog = new System.Windows.Forms.TabPage();
			this.textLog = new System.Windows.Forms.TextBox();
			this.HeaderPanel.SuspendLayout();
			this.MainTabs.SuspendLayout();
			this.tabInput.SuspendLayout();
			this.tabOutput.SuspendLayout();
			this.tabLog.SuspendLayout();
			this.SuspendLayout();
			// 
			// HeaderPanel
			// 
			this.HeaderPanel.Controls.Add(this.btClear);
			this.HeaderPanel.Controls.Add(this.BtProcess);
			this.HeaderPanel.Controls.Add(this.LbIntro);
			this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
			this.HeaderPanel.Name = "HeaderPanel";
			this.HeaderPanel.Size = new System.Drawing.Size(846, 72);
			this.HeaderPanel.TabIndex = 0;
			// 
			// btClear
			// 
			this.btClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btClear.Location = new System.Drawing.Point(738, 4);
			this.btClear.Name = "btClear";
			this.btClear.Size = new System.Drawing.Size(75, 23);
			this.btClear.TabIndex = 2;
			this.btClear.Text = "Clear";
			this.btClear.UseVisualStyleBackColor = true;
			this.btClear.Click += new System.EventHandler(this.btClear_Click);
			// 
			// BtProcess
			// 
			this.BtProcess.Dock = System.Windows.Forms.DockStyle.Left;
			this.BtProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtProcess.Location = new System.Drawing.Point(615, 0);
			this.BtProcess.Name = "BtProcess";
			this.BtProcess.Size = new System.Drawing.Size(116, 72);
			this.BtProcess.TabIndex = 1;
			this.BtProcess.Text = "Process";
			this.BtProcess.UseVisualStyleBackColor = true;
			this.BtProcess.Click += new System.EventHandler(this.BtProcess_Click);
			// 
			// LbIntro
			// 
			this.LbIntro.Dock = System.Windows.Forms.DockStyle.Left;
			this.LbIntro.Location = new System.Drawing.Point(0, 0);
			this.LbIntro.Name = "LbIntro";
			this.LbIntro.Padding = new System.Windows.Forms.Padding(4);
			this.LbIntro.Size = new System.Drawing.Size(615, 72);
			this.LbIntro.TabIndex = 0;
			this.LbIntro.Text = resources.GetString("LbIntro.Text");
			// 
			// MainTabs
			// 
			this.MainTabs.Controls.Add(this.tabInput);
			this.MainTabs.Controls.Add(this.tabOutput);
			this.MainTabs.Controls.Add(this.tabLog);
			this.MainTabs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainTabs.Location = new System.Drawing.Point(0, 72);
			this.MainTabs.Name = "MainTabs";
			this.MainTabs.SelectedIndex = 0;
			this.MainTabs.Size = new System.Drawing.Size(846, 380);
			this.MainTabs.TabIndex = 1;
			// 
			// tabInput
			// 
			this.tabInput.Controls.Add(this.textInput);
			this.tabInput.Location = new System.Drawing.Point(4, 22);
			this.tabInput.Name = "tabInput";
			this.tabInput.Padding = new System.Windows.Forms.Padding(3);
			this.tabInput.Size = new System.Drawing.Size(838, 354);
			this.tabInput.TabIndex = 0;
			this.tabInput.Text = "Input";
			this.tabInput.UseVisualStyleBackColor = true;
			// 
			// textInput
			// 
			this.textInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textInput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textInput.Location = new System.Drawing.Point(3, 3);
			this.textInput.Multiline = true;
			this.textInput.Name = "textInput";
			this.textInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textInput.Size = new System.Drawing.Size(832, 348);
			this.textInput.TabIndex = 1;
			// 
			// tabOutput
			// 
			this.tabOutput.Controls.Add(this.textOutput);
			this.tabOutput.Location = new System.Drawing.Point(4, 22);
			this.tabOutput.Name = "tabOutput";
			this.tabOutput.Padding = new System.Windows.Forms.Padding(3);
			this.tabOutput.Size = new System.Drawing.Size(838, 354);
			this.tabOutput.TabIndex = 1;
			this.tabOutput.Text = "Output";
			this.tabOutput.UseVisualStyleBackColor = true;
			// 
			// textOutput
			// 
			this.textOutput.BackColor = System.Drawing.Color.White;
			this.textOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textOutput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textOutput.Location = new System.Drawing.Point(3, 3);
			this.textOutput.Multiline = true;
			this.textOutput.Name = "textOutput";
			this.textOutput.ReadOnly = true;
			this.textOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textOutput.Size = new System.Drawing.Size(832, 348);
			this.textOutput.TabIndex = 1;
			// 
			// tabLog
			// 
			this.tabLog.Controls.Add(this.textLog);
			this.tabLog.Location = new System.Drawing.Point(4, 22);
			this.tabLog.Name = "tabLog";
			this.tabLog.Padding = new System.Windows.Forms.Padding(3);
			this.tabLog.Size = new System.Drawing.Size(838, 354);
			this.tabLog.TabIndex = 2;
			this.tabLog.Text = "Log";
			this.tabLog.UseVisualStyleBackColor = true;
			// 
			// textLog
			// 
			this.textLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textLog.Location = new System.Drawing.Point(3, 3);
			this.textLog.Multiline = true;
			this.textLog.Name = "textLog";
			this.textLog.ReadOnly = true;
			this.textLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textLog.Size = new System.Drawing.Size(832, 348);
			this.textLog.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(846, 452);
			this.Controls.Add(this.MainTabs);
			this.Controls.Add(this.HeaderPanel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "AssemblyRebinder";
			this.HeaderPanel.ResumeLayout(false);
			this.MainTabs.ResumeLayout(false);
			this.tabInput.ResumeLayout(false);
			this.tabInput.PerformLayout();
			this.tabOutput.ResumeLayout(false);
			this.tabOutput.PerformLayout();
			this.tabLog.ResumeLayout(false);
			this.tabLog.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel HeaderPanel;
		private System.Windows.Forms.Label LbIntro;
		private System.Windows.Forms.Button BtProcess;
		private System.Windows.Forms.TabControl MainTabs;
		private System.Windows.Forms.TabPage tabInput;
		private System.Windows.Forms.TabPage tabOutput;
		private System.Windows.Forms.TabPage tabLog;
		private System.Windows.Forms.TextBox textLog;
		private System.Windows.Forms.TextBox textInput;
		private System.Windows.Forms.TextBox textOutput;
		private System.Windows.Forms.Button btClear;
	}
}

