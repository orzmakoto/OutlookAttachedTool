using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Tools.Ribbon;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Core;
using System.IO;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using Ionic.Zip;
using Ionic.Zlib;
using Microsoft.Office.Interop.Outlook;

namespace OutlookAttachedTool
{
	public partial class ReadMailAttachedTool
	{
		Outlook.MailItem mailItem = null;

		#region FileIo

		FileIo _fileIo = null;
		private FileIo FileIo
		{
			get
			{
				if(_fileIo == null)
				{
					_fileIo = new FileIo();
				}
				return _fileIo;
			}
		}

		#endregion //FileIo
		private void ReadMailAttachedTool_Load(object sender, RibbonUIEventArgs e)
		{
			if(mailItem == null)
			{
				var inspector = base.Context as Microsoft.Office.Interop.Outlook.Inspector;
				mailItem = inspector.CurrentItem as Outlook.MailItem;

				if(mailItem.Attachments.Count == 0)
				{
					btn_saveTemp.Enabled = false;
				}
			}
		}

		private void bt_opneTemp_Click(object sender, RibbonControlEventArgs e)
		{
			Process.Start(FileIo.TempFilePath);
		}

		private void btn_saveTemp_Click(object sender, RibbonControlEventArgs e)
		{
			foreach(var attItem in mailItem.Attachments.Cast<Attachment>())
			{
				//var fileName = Path.GetFileName(attItem.PathName);
				attItem.SaveAsFile(Path.Combine(FileIo.TempFilePath, attItem.FileName));
			}
			Process.Start(FileIo.TempFilePath);
		}
	}
}
