﻿using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using adbGUI.Methods;

namespace adbGUI.Forms
{
	public partial class LogcatAdvanced : ExtForm
	{
		public LogcatAdvanced()
		{
			InitializeComponent();
		}

		private void Btn_LogcatAdvancedStart_Click(object sender, EventArgs e)
		{
			var alternativeBuffers = GetAlternativeBufferString();
			var regEx = GetRegularExpressionString();
			var quitAfterNumberOfLines = GetQuitAfterNumberOfLines();
			var bypassRegEx = GetBypassRegEx();
			var pidFilter = GetPidFilter();
			var recentNumberOfLines = GetRecentNumberOfLines();
			var specifiedTime = GetSpecifiedTime();
			var outputFormat = GetOutputFormat();
			var outputFilter = GetOutputFilter();



			HelperClass.Execute(
				"adb logcat" + outputFilter + alternativeBuffers + outputFormat + quitAfterNumberOfLines +
				recentNumberOfLines + specifiedTime + regEx + bypassRegEx + pidFilter);

		}

		private void Btn_LogcatAdvancedClearBuffers_Click(object sender, EventArgs e)
		{
			var alternativeBuffers = GetAlternativeBufferString();

			if (!string.IsNullOrEmpty(alternativeBuffers))
				HelperClass.Execute("adb logcat" + alternativeBuffers + " -c");
		}

		private void Btn_LogcatAdvancedStop_Click(object sender, EventArgs e)
		{
			CLI.KillChildProcessesAsync();
		}

		private void Btn_LogcatAdvancedNewBufferSize_Click(object sender, EventArgs e)
		{
			HelperClass.Execute("adb logcat -g");
		}

		private void Btn_LogcatAdvancedSetBufferSize_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txt_LogcatAdvancedBufferSize.Text))
				HelperClass.Execute("adb logcat -G " + txt_LogcatAdvancedBufferSize.Text.Trim());
		}

		private void Txt_LogcatAdvancedRecentNumberOfLines_KeyDown(object sender, KeyEventArgs e)
		{
			txt_LogcatAdvancedQuitAfterNumberLines.Clear();
		}

		private void Txt_LogcatAdvancedQuitAfterNumberLines_KeyDown(object sender, KeyEventArgs e)
		{
			txt_LogcatAdvancedRecentNumberOfLines.Clear();
		}

		private void Cbo_LogcatAdvancedAlternativeBuffersAll_CheckedChanged(object sender, EventArgs e)
		{
			if (cbo_LogcatAdvancedAlternativeBuffersAll.Checked)
			{
				cbo_LogcatAdvancedAlternativeBuffersDefault.Checked = false;
				cbo_LogcatAdvancedAlternativeBuffersMain.Checked = false;
				cbo_LogcatAdvancedAlternativeBuffersRadio.Checked = false;
				cbo_LogcatAdvancedAlternativeBuffersEvents.Checked = false;
				cbo_LogcatAdvancedAlternativeBuffersSystem.Checked = false;
				cbo_LogcatAdvancedAlternativeBuffersCrash.Checked = false;

				cbo_LogcatAdvancedAlternativeBuffersDefault.Enabled = false;
				cbo_LogcatAdvancedAlternativeBuffersMain.Enabled = false;
				cbo_LogcatAdvancedAlternativeBuffersRadio.Enabled = false;
				cbo_LogcatAdvancedAlternativeBuffersEvents.Enabled = false;
				cbo_LogcatAdvancedAlternativeBuffersSystem.Enabled = false;
				cbo_LogcatAdvancedAlternativeBuffersCrash.Enabled = false;
			}
			else
			{
				cbo_LogcatAdvancedAlternativeBuffersDefault.Enabled = true;
				cbo_LogcatAdvancedAlternativeBuffersMain.Enabled = true;
				cbo_LogcatAdvancedAlternativeBuffersRadio.Enabled = true;
				cbo_LogcatAdvancedAlternativeBuffersEvents.Enabled = true;
				cbo_LogcatAdvancedAlternativeBuffersSystem.Enabled = true;
				cbo_LogcatAdvancedAlternativeBuffersCrash.Enabled = true;
			}
		}

		private void Cbo_LogcatAdvancedAlternativeBuffersDefault_CheckedChanged(object sender, EventArgs e)
		{
			if (cbo_LogcatAdvancedAlternativeBuffersDefault.Checked)
			{
				cbo_LogcatAdvancedAlternativeBuffersMain.Checked = false;
				cbo_LogcatAdvancedAlternativeBuffersSystem.Checked = false;
				cbo_LogcatAdvancedAlternativeBuffersCrash.Checked = false;

				cbo_LogcatAdvancedAlternativeBuffersMain.Enabled = false;
				cbo_LogcatAdvancedAlternativeBuffersSystem.Enabled = false;
				cbo_LogcatAdvancedAlternativeBuffersCrash.Enabled = false;
			}
			else
			{
				cbo_LogcatAdvancedAlternativeBuffersMain.Enabled = true;
				cbo_LogcatAdvancedAlternativeBuffersSystem.Enabled = true;
				cbo_LogcatAdvancedAlternativeBuffersCrash.Enabled = true;
			}
		}

		private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(linkLabel1.Text);
		}

		private string GetAlternativeBufferString()
		{
			var alternativeBuffers = "";

			if (cbo_LogcatAdvancedAlternativeBuffersAll.Checked) alternativeBuffers += " -b all";
			if (cbo_LogcatAdvancedAlternativeBuffersDefault.Checked) alternativeBuffers += " -b default";
			if (cbo_LogcatAdvancedAlternativeBuffersMain.Checked) alternativeBuffers += " -b main";
			if (cbo_LogcatAdvancedAlternativeBuffersSystem.Checked) alternativeBuffers += " -b system";
			if (cbo_LogcatAdvancedAlternativeBuffersCrash.Checked) alternativeBuffers += " -b crash";
			if (cbo_LogcatAdvancedAlternativeBuffersRadio.Checked) alternativeBuffers += " -b radio";
			if (cbo_LogcatAdvancedAlternativeBuffersEvents.Checked) alternativeBuffers += " -b events";

			return alternativeBuffers;
		}

		private string GetRegularExpressionString()
		{
			var regEx = "";

			if (string.IsNullOrEmpty(txt_LogcatAdvancedRegularExpressions.Text.Trim())) return regEx;
			if (txt_LogcatAdvancedRegularExpressions.Text.Contains("|"))
				regEx = " -e \"" + txt_LogcatAdvancedRegularExpressions.Text.Trim() + "\"";
			else
				regEx = " -e " + txt_LogcatAdvancedRegularExpressions.Text.Trim();

			return regEx;
		}

		private string GetQuitAfterNumberOfLines()
		{
			var countNumber = "";

			if (!string.IsNullOrEmpty(txt_LogcatAdvancedQuitAfterNumberLines.Text.Trim()))
				countNumber = " -m " + txt_LogcatAdvancedQuitAfterNumberLines.Text.Trim();

			return countNumber;
		}

		private string GetBypassRegEx()
		{
			var bypassRegEx = "";

			if (cbo_LogcatAdvancedBypassRegEx.Checked &&
				!string.IsNullOrEmpty(txt_LogcatAdvancedRegularExpressions.Text.Trim())) bypassRegEx = " --print";

			return bypassRegEx;
		}

		private string GetPidFilter()
		{
			var pidFilter = "";

			if (!string.IsNullOrEmpty(txt_LogcatAdvancedPidFilter.Text.Trim()))
				pidFilter = " --pid=" + txt_LogcatAdvancedPidFilter.Text.Trim();

			return pidFilter;
		}

		private string GetRecentNumberOfLines()
		{
			var recentNumberOfLines = "";

			if (!string.IsNullOrEmpty(txt_LogcatAdvancedRecentNumberOfLines.Text.Trim()))
				recentNumberOfLines = " -t " + txt_LogcatAdvancedRecentNumberOfLines.Text.Trim();

			return recentNumberOfLines;
		}

		private string GetSpecifiedTime()
		{
			var specifiedTime = "";

			if (!string.IsNullOrEmpty(txt_LogcatAdvancedSpecifiedTime.Text.Trim()))
				specifiedTime = " -T \"" + txt_LogcatAdvancedSpecifiedTime.Text.Trim() + "\"";

			return specifiedTime;
		}

		private string GetOutputFilter()
		{
			var outputFilter = "";

			if (!string.IsNullOrEmpty(txt_LogcatAdvancedFilter.Text.Trim()))
				outputFilter = " " + txt_LogcatAdvancedFilter.Text.Trim();

			if (opt_LogcatAdvancedFilterVerbose.Checked)
				outputFilter += " *:V";

			else if (opt_LogcatAdvancedFilterDebug.Checked)
				outputFilter += " *:D";

			else if (opt_LogcatAdvancedFilterInfo.Checked)
				outputFilter += " *:I";

			else if (opt_LogcatAdvancedFilterWarning.Checked)
				outputFilter += " *:W";

			else if (opt_LogcatAdvancedFilterError.Checked)
				outputFilter += " *:E";

			else if (opt_LogcatAdvancedFilterFatal.Checked)
				outputFilter += " *:F";

			else if (opt_LogcatAdvancedFilterSilent.Checked) outputFilter += " *:S";

			return outputFilter;
		}

		private string GetOutputFormat()
		{
			if (opt_LogcatAdvancedOutputFormatThreadTime.Checked)
				return " -v threadtime";

			if (opt_LogcatAdvancedOutputFormatLong.Checked)
				return " -v long";

			if (opt_LogcatAdvancedOutputFormatTime.Checked)
				return " -v time";

			if (opt_LogcatAdvancedOutputFormatRaw.Checked)
				return " -v raw";

			if (opt_LogcatAdvancedOutputFormatTag.Checked)
				return " -v tag";

			if (opt_LogcatAdvancedOutputFormatProcess.Checked)
				return " -v process";

			return opt_LogcatAdvancedOutputFormatBrief.Checked ? " -v brief" : "";
		}

		private void Btn_LogcatAdvancedStatistics_Click(object sender, EventArgs e)
		{
			HelperClass.Execute("adb logcat -S");
		}
	}
}