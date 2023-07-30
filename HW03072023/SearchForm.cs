using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW03072023
{
	public partial class SearchForm : Form
	{
		public SearchForm() {
			InitializeComponent();
		}

		private static string WildCardToRegular(string value) {
			return "^" + Regex.Escape(value).Replace("\\*", ".*") + "$";
		}

		private void Search(string path, string request) {
			listBox.Items.Clear();
			if (!Directory.Exists(path))
				return;

			if (request.Length == 0)
				request = "*";
			path = path.Replace('/', '\\');

			string filename;
			foreach (string file in Directory.GetFiles(path)) {
				filename = file.Split('\\').Last();
				if (Regex.IsMatch(filename, WildCardToRegular(request)))
					listBox.Items.Add(filename);
			}
		}

		private void buttonBrowse_Click(object sender, EventArgs e) {
			FolderBrowserDialog browserDialog = new FolderBrowserDialog();
			DialogResult res = browserDialog.ShowDialog();

			if (res == DialogResult.OK) {
				textBoxPath.Text = browserDialog.SelectedPath;
			}
		}

		private void textBoxPath_TextChanged(object sender, EventArgs e) {
			Search(textBoxPath.Text, textBoxRequest.Text);
		}

		private void textBoxRequest_TextChanged(object sender, EventArgs e) {
			Search(textBoxPath.Text, textBoxRequest.Text);
		}

		private void listBox_DoubleClick(object sender, EventArgs e) {
			using Process fileopener = new Process();

			fileopener.StartInfo.FileName = "explorer";
			fileopener.StartInfo.Arguments = "\"" + Path.Combine(textBoxPath.Text, listBox.SelectedItem.ToString()) + "\"";
			fileopener.Start();
		}
	}
}
