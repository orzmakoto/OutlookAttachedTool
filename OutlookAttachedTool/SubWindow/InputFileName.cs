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
	public partial class InputFileName : Form
	{
		public InputFileName(string dataType)
		{
			InitializeComponent();
			this.DataType = dataType;
			this.extension = FileIo.GetDataTypeExtension(dataType);
			pict_extension.Image = FileIo.GetDataTypeImage(dataType);
			la_extension.Text = string.Format(".{0}", this.extension);
		}

		private string extension;
		public string FileName { get; private set; }
		public string DataType { get; private set; }

		private void bt_OK_Click(object sender, EventArgs e)
		{
			this.FileName = string.Format("{0}.{1}", tb_FileName.Text, extension);
			base.DialogResult = System.Windows.Forms.DialogResult.OK;

			this.Close();
		}

		private void bt_Cancel_Click(object sender, EventArgs e)
		{
			base.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			
			this.Close();
		}

		private void tb_FileName_TextChanged(object sender, EventArgs e)
		{
			if (tb_FileName.Text.Length == 0)
			{
				bt_OK.Enabled = false;
			}
			else
			{
				bt_OK.Enabled = true;
			}
		}

		private void tb_FileName_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				bt_OK_Click(sender, e);
			}
		}
	}
}
