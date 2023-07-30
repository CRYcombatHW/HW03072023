namespace HW03072023
{
	partial class SearchForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			buttonBrowse = new Button();
			textBoxPath = new TextBox();
			textBoxRequest = new TextBox();
			listBox = new ListBox();
			SuspendLayout();
			// 
			// buttonBrowse
			// 
			buttonBrowse.Location = new Point(503, 12);
			buttonBrowse.Name = "buttonBrowse";
			buttonBrowse.Size = new Size(71, 23);
			buttonBrowse.TabIndex = 0;
			buttonBrowse.Text = "Browse";
			buttonBrowse.UseVisualStyleBackColor = true;
			buttonBrowse.Click += buttonBrowse_Click;
			// 
			// textBoxPath
			// 
			textBoxPath.Location = new Point(12, 12);
			textBoxPath.Name = "textBoxPath";
			textBoxPath.PlaceholderText = "Directory Path";
			textBoxPath.Size = new Size(485, 23);
			textBoxPath.TabIndex = 1;
			textBoxPath.TextChanged += textBoxPath_TextChanged;
			// 
			// textBoxRequest
			// 
			textBoxRequest.Location = new Point(580, 12);
			textBoxRequest.Name = "textBoxRequest";
			textBoxRequest.PlaceholderText = "Search Request";
			textBoxRequest.Size = new Size(208, 23);
			textBoxRequest.TabIndex = 2;
			textBoxRequest.TextChanged += textBoxRequest_TextChanged;
			// 
			// listBox
			// 
			listBox.FormattingEnabled = true;
			listBox.ItemHeight = 15;
			listBox.Location = new Point(12, 41);
			listBox.Name = "listBox";
			listBox.Size = new Size(776, 394);
			listBox.TabIndex = 3;
			listBox.DoubleClick += listBox_DoubleClick;
			// 
			// SearchForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(listBox);
			Controls.Add(textBoxRequest);
			Controls.Add(textBoxPath);
			Controls.Add(buttonBrowse);
			Name = "SearchForm";
			Text = "SearchForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button buttonBrowse;
		private TextBox textBoxPath;
		private TextBox textBoxRequest;
		private ListBox listBox;
	}
}