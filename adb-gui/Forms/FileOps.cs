﻿using System;
using System.Windows.Forms;
using adbGUI.Methods;

namespace adbGUI.Forms
{
	public partial class FileOps : ExtForm
	{
		public FileOps()
		{
			InitializeComponent();
		}

		private void Btn_FileOpsPushBrowse_Click(object sender, EventArgs e)
		{
			openFileDialog.FileName = " "; //This is not a normal whitespace. ALT + 255
			openFileDialog.CheckFileExists = false;
			openFileDialog.CheckPathExists = true;
			openFileDialog.ValidateNames = false;
			openFileDialog.Filter = @"All Files (*.*)|*.*";

			if (openFileDialog.ShowDialog() != DialogResult.OK) return;
			if (openFileDialog.SafeFileName == " ") //This is not a normal whitespace. ALT + 255
				txt_FileOpsPushTo.Text =
					openFileDialog.FileName.Remove(openFileDialog.FileName.Length - 2, 2);
			else
				txt_FileOpsPushFrom.Text = openFileDialog.FileName;
		}

		private void Btn_FileOpsPushPush_Click(object sender, EventArgs e)
		{
			if (txt_FileOpsPushTo.Text == "" || txt_FileOpsPushFrom.Text == "")
			{
				MessageBox.Show(@"Please select a file and chose destination!", @"Error", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
			else
			{
				var s = "adb push \"" + txt_FileOpsPushFrom.Text + "\"" + " \"" + txt_FileOpsPushTo.Text + "\" && echo finished";
				HelperClass.Execute(s);
			}
		}

		private void Btn_FileOpsPushList_Click(object sender, EventArgs e)
		{
			var path = txt_FileOpsPushTo.Text;
			HelperClass.Execute("adb shell ls -la \"" + path + "\" -F");
		}

		private void Btn_FileOpsPullBrowse_Click(object sender, EventArgs e)
		{
			folderBrowserDialog.Description = @"Where should the file be saved?";

			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
				txt_FileOpsPullTo.Text = folderBrowserDialog.SelectedPath;
		}

		private void Btn_FileOpsPullPull_Click(object sender, EventArgs e)
		{
			if (txt_FileOpsPullTo.Text == "" || txt_FileOpsPullFrom.Text == "")
			{
				MessageBox.Show(@"Please select a file and chose destination!", @"Error", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
			else
			{
				var s = "adb pull \"" + txt_FileOpsPullFrom.Text + "\"" + " \"" + txt_FileOpsPullTo.Text + "\" && echo finished";
				HelperClass.Execute(s);
			}
		}

		private void Btn_FileOpsPullList_Click(object sender, EventArgs e)
		{
			var path = txt_FileOpsPullFrom.Text;
			HelperClass.Execute("adb shell ls -la \"" + path + "\" -F");
		}
	}
}