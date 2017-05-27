using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OutlookAttachedTool.SubWindow
{
	public partial class AttachedCompressSetting : Form
	{
		public AttachedCompressSetting(string[] files)
		{
			InitializeComponent();
			Files = files.ToList();
			Setting = new CompressSetting();
		}

		public List<string> Files { get; set; }
		//public List<string> CheckFiles { get; set; }
		//public string FileName { get; set; }

		public CompressSetting Setting { get; private set; }

		private void AttachedCompressSetting_Load(object sender, EventArgs e)
		{
			foreach (var file in Files)
			{
				var index = clist_files.Items.Add(file);
				clist_files.SetItemChecked(index, true);
			}
		}

		private void bt_OK_Click(object sender, EventArgs e)
		{
			if (clist_files.CheckedItems.Count == 0)
			{
				MessageBox.Show("圧縮するファイルを選択してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (cb_Pass.Checked == true && string.IsNullOrEmpty(tb_PassText.Text) == true)
			{
				MessageBox.Show("パスワードを設定してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			

			//CheckFiles = new List<string>();
			//FileName = tb_FileName.Text;
			Setting.FileName = tb_FileName.Text;
			foreach (var item in clist_files.CheckedItems)
			{
				//CheckFiles.Add(item.ToString());
				Setting.Files.Add(item.ToString());
			}
			if (cb_Pass.Checked == true)
			{
				Setting.HasPassword = true;
				Setting.PasswordText = tb_PassText.Text;
			}
			base.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.Close();
		}

		private void bt_Cancel_Click(object sender, EventArgs e)
		{
			base.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Close();
		}

		private void clist_files_SelectedIndexChanged(object sender, EventArgs e)
		{
			//if (clist_files.CheckedItems.Count != 0)
			//{
			//	bt_OK.Enabled = true;
			//}
			//else
			//{
			//	bt_OK.Enabled = false;
			//}
		}

		private void cb_Pass_CheckedChanged(object sender, EventArgs e)
		{
			tb_PassText.Enabled = cb_Pass.Checked;
		}
	}
}
namespace OutlookAttachedTool.SubWindow
{
	public class CompressSetting
	{
		public CompressSetting()
		{
			Files = new List<string>();
		}
		public string FileName { get; set; }
		public List<string> Files { get; set; }
		public bool HasPassword { get; set; }
		public string PasswordText { get; set; }

		public string CompressTargetPath { get; set; }
		public string CompressFilePath { get; set; }
	}
}
