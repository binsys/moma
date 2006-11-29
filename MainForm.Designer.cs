namespace MoMA
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
		protected override void Dispose (bool disposing)
		{
			if (disposing && (components != null)) {
				components.Dispose ();
			}
			base.Dispose (disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager (typeof (MainForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox ();
			this.NextButton = new System.Windows.Forms.Button ();
			this.BackButton = new System.Windows.Forms.Button ();
			this.label1 = new System.Windows.Forms.Label ();
			this.StepLabel = new System.Windows.Forms.Label ();
			this.IntroductionLabel = new System.Windows.Forms.Label ();
			this.AssemblyLabel = new System.Windows.Forms.Label ();
			this.AssemblyAddButton = new System.Windows.Forms.Button ();
			this.AssemblyRemoveButton = new System.Windows.Forms.Button ();
			this.AssemblyListView = new System.Windows.Forms.ListView ();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader ();
			this.MonoTodoResultsImage = new System.Windows.Forms.PictureBox ();
			this.MonoTodoResultsLabel = new System.Windows.Forms.Label ();
			this.AnalysisResultsLabel = new System.Windows.Forms.Label ();
			this.NotImplementedResultsLabel = new System.Windows.Forms.Label ();
			this.NotImplementedResultsImage = new System.Windows.Forms.PictureBox ();
			this.PInvokesResultsLabel = new System.Windows.Forms.Label ();
			this.PInvokesResultsImage = new System.Windows.Forms.PictureBox ();
			this.AssemblyInstructions = new System.Windows.Forms.Label ();
			this.MissingResultsLabel = new System.Windows.Forms.Label ();
			this.MissingResultsImage = new System.Windows.Forms.PictureBox ();
			this.ResultsText = new System.Windows.Forms.Label ();
			this.ResultsDetailLink = new System.Windows.Forms.LinkLabel ();
			this.ProjectLink = new System.Windows.Forms.LinkLabel ();
			this.SubmitLabel = new System.Windows.Forms.Label ();
			this.SubmitInstructions = new System.Windows.Forms.Label ();
			this.ViewReportButton = new System.Windows.Forms.Button ();
			this.SubmitReportButton = new System.Windows.Forms.Button ();
			this.label2 = new System.Windows.Forms.Label ();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit ();
			((System.ComponentModel.ISupportInitialize)(this.MonoTodoResultsImage)).BeginInit ();
			((System.ComponentModel.ISupportInitialize)(this.NotImplementedResultsImage)).BeginInit ();
			((System.ComponentModel.ISupportInitialize)(this.PInvokesResultsImage)).BeginInit ();
			((System.ComponentModel.ISupportInitialize)(this.MissingResultsImage)).BeginInit ();
			this.SuspendLayout ();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = global::MoMA.Properties.Resources.monkey;
			this.pictureBox1.Location = new System.Drawing.Point (12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size (100, 119);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// NextButton
			// 
			this.NextButton.Location = new System.Drawing.Point (621, 429);
			this.NextButton.Name = "NextButton";
			this.NextButton.Size = new System.Drawing.Size (86, 30);
			this.NextButton.TabIndex = 1;
			this.NextButton.Text = "Next";
			this.NextButton.UseVisualStyleBackColor = true;
			this.NextButton.Click += new System.EventHandler (this.NextButton_Click);
			// 
			// BackButton
			// 
			this.BackButton.Enabled = false;
			this.BackButton.Location = new System.Drawing.Point (529, 429);
			this.BackButton.Name = "BackButton";
			this.BackButton.Size = new System.Drawing.Size (86, 30);
			this.BackButton.TabIndex = 2;
			this.BackButton.Text = "Back";
			this.BackButton.UseVisualStyleBackColor = true;
			this.BackButton.Click += new System.EventHandler (this.BackButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font ("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point (135, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size (340, 32);
			this.label1.TabIndex = 3;
			this.label1.Text = "Mono Migration Analyzer";
			// 
			// StepLabel
			// 
			this.StepLabel.AutoSize = true;
			this.StepLabel.Font = new System.Drawing.Font ("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StepLabel.Location = new System.Drawing.Point (12, 414);
			this.StepLabel.Name = "StepLabel";
			this.StepLabel.Size = new System.Drawing.Size (60, 14);
			this.StepLabel.TabIndex = 4;
			this.StepLabel.Text = "Step 1 of 4";
			// 
			// IntroductionLabel
			// 
			this.IntroductionLabel.Font = new System.Drawing.Font ("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.IntroductionLabel.Location = new System.Drawing.Point (138, 130);
			this.IntroductionLabel.Name = "IntroductionLabel";
			this.IntroductionLabel.Size = new System.Drawing.Size (530, 202);
			this.IntroductionLabel.TabIndex = 5;
			this.IntroductionLabel.Text = resources.GetString ("IntroductionLabel.Text");
			// 
			// AssemblyLabel
			// 
			this.AssemblyLabel.Font = new System.Drawing.Font ("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AssemblyLabel.Location = new System.Drawing.Point (170, 100);
			this.AssemblyLabel.Name = "AssemblyLabel";
			this.AssemblyLabel.Size = new System.Drawing.Size (416, 20);
			this.AssemblyLabel.TabIndex = 6;
			this.AssemblyLabel.Text = "Choose the assemblies to analyze:";
			// 
			// AssemblyAddButton
			// 
			this.AssemblyAddButton.Image = global::MoMA.Properties.Resources.list_add;
			this.AssemblyAddButton.Location = new System.Drawing.Point (592, 123);
			this.AssemblyAddButton.Name = "AssemblyAddButton";
			this.AssemblyAddButton.Size = new System.Drawing.Size (30, 30);
			this.AssemblyAddButton.TabIndex = 8;
			this.AssemblyAddButton.UseVisualStyleBackColor = true;
			this.AssemblyAddButton.Click += new System.EventHandler (this.AssemblyAddButton_Click);
			// 
			// AssemblyRemoveButton
			// 
			this.AssemblyRemoveButton.Image = global::MoMA.Properties.Resources.list_remove;
			this.AssemblyRemoveButton.Location = new System.Drawing.Point (592, 159);
			this.AssemblyRemoveButton.Name = "AssemblyRemoveButton";
			this.AssemblyRemoveButton.Size = new System.Drawing.Size (30, 30);
			this.AssemblyRemoveButton.TabIndex = 9;
			this.AssemblyRemoveButton.UseVisualStyleBackColor = true;
			this.AssemblyRemoveButton.Click += new System.EventHandler (this.AssemblyRemoveButton_Click);
			// 
			// AssemblyListView
			// 
			this.AssemblyListView.Columns.AddRange (new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
			this.AssemblyListView.FullRowSelect = true;
			this.AssemblyListView.Location = new System.Drawing.Point (173, 123);
			this.AssemblyListView.MultiSelect = false;
			this.AssemblyListView.Name = "AssemblyListView";
			this.AssemblyListView.Size = new System.Drawing.Size (413, 145);
			this.AssemblyListView.TabIndex = 10;
			this.AssemblyListView.UseCompatibleStateImageBehavior = false;
			this.AssemblyListView.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Assembly";
			this.columnHeader1.Width = 409;
			// 
			// MonoTodoResultsImage
			// 
			this.MonoTodoResultsImage.Image = global::MoMA.Properties.Resources.button_ok;
			this.MonoTodoResultsImage.Location = new System.Drawing.Point (193, 214);
			this.MonoTodoResultsImage.Name = "MonoTodoResultsImage";
			this.MonoTodoResultsImage.Size = new System.Drawing.Size (22, 22);
			this.MonoTodoResultsImage.TabIndex = 11;
			this.MonoTodoResultsImage.TabStop = false;
			// 
			// MonoTodoResultsLabel
			// 
			this.MonoTodoResultsLabel.Font = new System.Drawing.Font ("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MonoTodoResultsLabel.Location = new System.Drawing.Point (220, 216);
			this.MonoTodoResultsLabel.Name = "MonoTodoResultsLabel";
			this.MonoTodoResultsLabel.Size = new System.Drawing.Size (310, 20);
			this.MonoTodoResultsLabel.TabIndex = 12;
			this.MonoTodoResultsLabel.Text = "Methods marked with [MonoTodo] called: 0";
			// 
			// AnalysisResultsLabel
			// 
			this.AnalysisResultsLabel.Font = new System.Drawing.Font ("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AnalysisResultsLabel.Location = new System.Drawing.Point (169, 100);
			this.AnalysisResultsLabel.Name = "AnalysisResultsLabel";
			this.AnalysisResultsLabel.Size = new System.Drawing.Size (416, 20);
			this.AnalysisResultsLabel.TabIndex = 14;
			this.AnalysisResultsLabel.Text = "Analysis Summary:";
			// 
			// NotImplementedResultsLabel
			// 
			this.NotImplementedResultsLabel.Font = new System.Drawing.Font ("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NotImplementedResultsLabel.Location = new System.Drawing.Point (220, 188);
			this.NotImplementedResultsLabel.Name = "NotImplementedResultsLabel";
			this.NotImplementedResultsLabel.Size = new System.Drawing.Size (395, 20);
			this.NotImplementedResultsLabel.TabIndex = 16;
			this.NotImplementedResultsLabel.Text = "Methods called that throw NotImplementedException: 0";
			// 
			// NotImplementedResultsImage
			// 
			this.NotImplementedResultsImage.Image = global::MoMA.Properties.Resources.button_ok;
			this.NotImplementedResultsImage.Location = new System.Drawing.Point (193, 186);
			this.NotImplementedResultsImage.Name = "NotImplementedResultsImage";
			this.NotImplementedResultsImage.Size = new System.Drawing.Size (22, 22);
			this.NotImplementedResultsImage.TabIndex = 15;
			this.NotImplementedResultsImage.TabStop = false;
			// 
			// PInvokesResultsLabel
			// 
			this.PInvokesResultsLabel.Font = new System.Drawing.Font ("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PInvokesResultsLabel.Location = new System.Drawing.Point (220, 160);
			this.PInvokesResultsLabel.Name = "PInvokesResultsLabel";
			this.PInvokesResultsLabel.Size = new System.Drawing.Size (310, 20);
			this.PInvokesResultsLabel.TabIndex = 19;
			this.PInvokesResultsLabel.Text = "P/Invokes called: 0";
			// 
			// PInvokesResultsImage
			// 
			this.PInvokesResultsImage.Image = global::MoMA.Properties.Resources.button_ok;
			this.PInvokesResultsImage.Location = new System.Drawing.Point (193, 158);
			this.PInvokesResultsImage.Name = "PInvokesResultsImage";
			this.PInvokesResultsImage.Size = new System.Drawing.Size (22, 22);
			this.PInvokesResultsImage.TabIndex = 18;
			this.PInvokesResultsImage.TabStop = false;
			// 
			// AssemblyInstructions
			// 
			this.AssemblyInstructions.Font = new System.Drawing.Font ("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AssemblyInstructions.Location = new System.Drawing.Point (173, 278);
			this.AssemblyInstructions.Name = "AssemblyInstructions";
			this.AssemblyInstructions.Size = new System.Drawing.Size (413, 54);
			this.AssemblyInstructions.TabIndex = 21;
			this.AssemblyInstructions.Text = "Select the main assembly (.exe or .dll) as well as any referenced user libraries " +
			    "(.dll).  (Do not select assemblies that ship with .Net, like System.Xml or Syste" +
			    "m.Windows.Forms.)";
			// 
			// MissingResultsLabel
			// 
			this.MissingResultsLabel.Font = new System.Drawing.Font ("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MissingResultsLabel.Location = new System.Drawing.Point (220, 132);
			this.MissingResultsLabel.Name = "MissingResultsLabel";
			this.MissingResultsLabel.Size = new System.Drawing.Size (310, 20);
			this.MissingResultsLabel.TabIndex = 23;
			this.MissingResultsLabel.Text = "Methods that still missing in Mono: 0";
			// 
			// MissingResultsImage
			// 
			this.MissingResultsImage.Image = global::MoMA.Properties.Resources.button_ok;
			this.MissingResultsImage.Location = new System.Drawing.Point (193, 130);
			this.MissingResultsImage.Name = "MissingResultsImage";
			this.MissingResultsImage.Size = new System.Drawing.Size (22, 22);
			this.MissingResultsImage.TabIndex = 22;
			this.MissingResultsImage.TabStop = false;
			// 
			// ResultsText
			// 
			this.ResultsText.Font = new System.Drawing.Font ("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ResultsText.Location = new System.Drawing.Point (170, 278);
			this.ResultsText.Name = "ResultsText";
			this.ResultsText.Size = new System.Drawing.Size (416, 54);
			this.ResultsText.TabIndex = 24;
			this.ResultsText.Text = "Congratulations!  No potential issues were detected in your assemblies.  The only" +
			    " thing left to do is to try running them on Mono and see what happens.";
			// 
			// ResultsDetailLink
			// 
			this.ResultsDetailLink.AutoSize = true;
			this.ResultsDetailLink.Font = new System.Drawing.Font ("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ResultsDetailLink.Location = new System.Drawing.Point (471, 332);
			this.ResultsDetailLink.Name = "ResultsDetailLink";
			this.ResultsDetailLink.Size = new System.Drawing.Size (115, 16);
			this.ResultsDetailLink.TabIndex = 25;
			this.ResultsDetailLink.TabStop = true;
			this.ResultsDetailLink.Text = "View Detail Report";
			this.ResultsDetailLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler (this.ResultsDetailLink_LinkClicked);
			// 
			// ProjectLink
			// 
			this.ProjectLink.Font = new System.Drawing.Font ("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProjectLink.Location = new System.Drawing.Point (210, 438);
			this.ProjectLink.Name = "ProjectLink";
			this.ProjectLink.Size = new System.Drawing.Size (172, 14);
			this.ProjectLink.TabIndex = 26;
			this.ProjectLink.TabStop = true;
			this.ProjectLink.Text = "http://www.mono-project.com";
			this.ProjectLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler (this.ProjectLink_LinkClicked);
			// 
			// SubmitLabel
			// 
			this.SubmitLabel.Font = new System.Drawing.Font ("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SubmitLabel.Location = new System.Drawing.Point (173, 98);
			this.SubmitLabel.Name = "SubmitLabel";
			this.SubmitLabel.Size = new System.Drawing.Size (416, 20);
			this.SubmitLabel.TabIndex = 27;
			this.SubmitLabel.Text = "Submit Results:";
			// 
			// SubmitInstructions
			// 
			this.SubmitInstructions.Font = new System.Drawing.Font ("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SubmitInstructions.Location = new System.Drawing.Point (173, 123);
			this.SubmitInstructions.Name = "SubmitInstructions";
			this.SubmitInstructions.Size = new System.Drawing.Size (416, 183);
			this.SubmitInstructions.TabIndex = 28;
			this.SubmitInstructions.Text = resources.GetString ("SubmitInstructions.Text");
			// 
			// ViewReportButton
			// 
			this.ViewReportButton.Location = new System.Drawing.Point (411, 325);
			this.ViewReportButton.Name = "ViewReportButton";
			this.ViewReportButton.Size = new System.Drawing.Size (86, 30);
			this.ViewReportButton.TabIndex = 29;
			this.ViewReportButton.Text = "View Report";
			this.ViewReportButton.UseVisualStyleBackColor = true;
			this.ViewReportButton.Click += new System.EventHandler (this.ViewReportButton_Click);
			// 
			// SubmitReportButton
			// 
			this.SubmitReportButton.Enabled = false;
			this.SubmitReportButton.Location = new System.Drawing.Point (503, 325);
			this.SubmitReportButton.Name = "SubmitReportButton";
			this.SubmitReportButton.Size = new System.Drawing.Size (86, 30);
			this.SubmitReportButton.TabIndex = 30;
			this.SubmitReportButton.Text = "Submit Report";
			this.SubmitReportButton.UseVisualStyleBackColor = true;
			this.SubmitReportButton.Click += new System.EventHandler (this.SubmitReportButton_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font ("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point (12, 438);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size (63, 14);
			this.label2.TabIndex = 32;
			this.label2.Text = "Version 1.0";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject ("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size (719, 471);
			this.Controls.Add (this.label2);
			this.Controls.Add (this.SubmitReportButton);
			this.Controls.Add (this.ViewReportButton);
			this.Controls.Add (this.SubmitInstructions);
			this.Controls.Add (this.SubmitLabel);
			this.Controls.Add (this.ProjectLink);
			this.Controls.Add (this.ResultsDetailLink);
			this.Controls.Add (this.ResultsText);
			this.Controls.Add (this.MissingResultsLabel);
			this.Controls.Add (this.MissingResultsImage);
			this.Controls.Add (this.label1);
			this.Controls.Add (this.PInvokesResultsLabel);
			this.Controls.Add (this.PInvokesResultsImage);
			this.Controls.Add (this.NotImplementedResultsLabel);
			this.Controls.Add (this.NotImplementedResultsImage);
			this.Controls.Add (this.AnalysisResultsLabel);
			this.Controls.Add (this.MonoTodoResultsLabel);
			this.Controls.Add (this.MonoTodoResultsImage);
			this.Controls.Add (this.AssemblyListView);
			this.Controls.Add (this.AssemblyRemoveButton);
			this.Controls.Add (this.AssemblyAddButton);
			this.Controls.Add (this.AssemblyLabel);
			this.Controls.Add (this.IntroductionLabel);
			this.Controls.Add (this.StepLabel);
			this.Controls.Add (this.BackButton);
			this.Controls.Add (this.NextButton);
			this.Controls.Add (this.pictureBox1);
			this.Controls.Add (this.AssemblyInstructions);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "MainForm";
			this.Text = "MoMA: Mono Migration Analyzer";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit ();
			((System.ComponentModel.ISupportInitialize)(this.MonoTodoResultsImage)).EndInit ();
			((System.ComponentModel.ISupportInitialize)(this.NotImplementedResultsImage)).EndInit ();
			((System.ComponentModel.ISupportInitialize)(this.PInvokesResultsImage)).EndInit ();
			((System.ComponentModel.ISupportInitialize)(this.MissingResultsImage)).EndInit ();
			this.ResumeLayout (false);
			this.PerformLayout ();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button NextButton;
		private System.Windows.Forms.Button BackButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label StepLabel;
		private System.Windows.Forms.Label IntroductionLabel;
		private System.Windows.Forms.Label AssemblyLabel;
		private System.Windows.Forms.Button AssemblyAddButton;
		private System.Windows.Forms.Button AssemblyRemoveButton;
		private System.Windows.Forms.ListView AssemblyListView;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.PictureBox MonoTodoResultsImage;
		private System.Windows.Forms.Label MonoTodoResultsLabel;
		private System.Windows.Forms.Label AnalysisResultsLabel;
		private System.Windows.Forms.Label NotImplementedResultsLabel;
		private System.Windows.Forms.PictureBox NotImplementedResultsImage;
		private System.Windows.Forms.Label PInvokesResultsLabel;
		private System.Windows.Forms.PictureBox PInvokesResultsImage;
		private System.Windows.Forms.Label AssemblyInstructions;
		private System.Windows.Forms.Label MissingResultsLabel;
		private System.Windows.Forms.PictureBox MissingResultsImage;
		private System.Windows.Forms.Label ResultsText;
		private System.Windows.Forms.LinkLabel ResultsDetailLink;
		private System.Windows.Forms.LinkLabel ProjectLink;
		private System.Windows.Forms.Label SubmitLabel;
		private System.Windows.Forms.Label SubmitInstructions;
		private System.Windows.Forms.Button ViewReportButton;
		private System.Windows.Forms.Button SubmitReportButton;
		private System.Windows.Forms.Label label2;
	}
}