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
using OutlookAttachedTool.SubWindow;

namespace OutlookAttachedTool
{
	public partial class NewMailAttachedTool
	{
		Outlook.MailItem mailItem = null;
		List<CompressSetting> CompressSettings = new List<CompressSetting>();

		#region FileIo

		FileIo _fileIo = null;
		private FileIo FileIo
		{
			get
			{
				if (_fileIo == null)
				{
					_fileIo = new FileIo();
				}
				return _fileIo;
			}
		}

		#endregion //FileIo

		public void AttachedCompress(bool isManual)
		{
			try
			{
				CompressSetting setting;

				var indexList = new List<Attachment>();
				if (isManual == false)
				{
					setting = new CompressSetting();
					setting.CompressTargetPath = FileIo.CreateTempFolder(null);
					foreach (var attachment in mailItem.Attachments.Cast<Attachment>())
					{
						//System.Diagnostics.Debug.WriteLine(attachment.GetTemporaryFilePath().ToString());

						//添付されいてるファイルを圧縮用フォルダへコピー
						attachment.SaveAsFile(Path.Combine(setting.CompressTargetPath, attachment.FileName));
						//圧縮対象ファイルを添付リストから除外
						indexList.Add(attachment);
					}
				}
				else
				{
					var fileList = new List<string>();
					foreach (var attachment in mailItem.Attachments.Cast<Attachment>())
					{
						fileList.Add(attachment.FileName);
					}
					var settingForm = new AttachedCompressSetting(fileList.ToArray());
					settingForm.StartPosition = FormStartPosition.CenterParent;
					settingForm.ShowDialog();
					if (settingForm.DialogResult == DialogResult.OK)
					{
						setting = settingForm.Setting;
						setting.CompressTargetPath = FileIo.CreateTempFolder(setting.FileName);
						foreach (var attachment in mailItem.Attachments.Cast<Attachment>())
						{
							//var attachment = item as Attachment;
							if (setting.Files.Contains(attachment.FileName) == false)
							{
								continue;
							}
							//添付されいてるファイルを圧縮用フォルダへコピー
							attachment.SaveAsFile(Path.Combine(setting.CompressTargetPath, attachment.FileName));
							//圧縮対象ファイルを添付リストから除外
							indexList.Add(attachment);
						}
					}
					else
					{
						return;
					}
				}
				this.CompressSettings.Add(setting);
				var zipPath = FileIo.FolderCompress(setting);
				mailItem.Attachments.Add(zipPath);



				indexList.ForEach(i =>
				{
					i.Delete();
				});
			}
			catch (System.Exception ee)
			{
				MessageBox.Show(ee.ToString(), "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public void ClipToNewAttached(bool inpunFileName, bool multiFileToCompress, bool compress)
		{
			List<string> filePathList = new List<string>();
			try
			{
				var objTypeList = new List<string>()
				{
					DataFormats.Text, DataFormats.Bitmap
				};
				if (multiFileToCompress == true)
				{
					objTypeList.Add(DataFormats.FileDrop);
				}
				foreach (var type in objTypeList)
				{
					var data = Clipboard.GetData(type);
					if (data != null)
					{
						string fileName = null;
						if (inpunFileName == true)
						{
							var inputWindow = new SubWindow.InputFileName(type);
							inputWindow.StartPosition = FormStartPosition.CenterParent;
							inputWindow.ShowDialog();
							if (inputWindow.DialogResult == DialogResult.OK)
							{
								fileName = inputWindow.FileName;
							}
						}
						filePathList = FileIo.SaveObject(data, fileName);
						if (compress == true || (filePathList.Count != 1 && multiFileToCompress == true))
						{
							var comFilePath = FileIo.FilesCompress(fileName, filePathList.ToArray());
							filePathList.Clear();
							filePathList.Add(comFilePath);
						}

						break;
					}
				}
			}
			catch (System.Exception eee)
			{
				MessageBox.Show(eee.ToString(), "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			foreach (var filePath in filePathList)
			{
				mailItem.Attachments.Add(filePath);
			}
		}

		private void NewMailAttachedTool_Load(object sender, RibbonUIEventArgs e)
		{
			if (mailItem == null)
			{
				var inspector = base.Context as Microsoft.Office.Interop.Outlook.Inspector;
				mailItem = inspector.CurrentItem as Outlook.MailItem;
				mailItem.AttachmentAdd += (a) =>
					{
						bt_Attached2Compress.Enabled = true;
						if (CompressSettings.Count != 0)
						{
							bt_NewPassMail.Enabled = true;
						}
					};
				mailItem.AttachmentRemove += (a) =>
					{
						if (mailItem.Attachments.Count == 0)
						{
							bt_Attached2Compress.Enabled = false;
						}

						CompressSettings.RemoveAll(i => i.CompressFilePath == a.FileName);
						if (CompressSettings.Count == 0)
						{
							bt_NewPassMail.Enabled = false;
						}
					};
				//(mailItem as ItemEvents_10_Event).Send += OnSend;
			}
		}

		void OnSend(ref bool cancel)
		{

		}


		#region Clip2AttachedEvent

		private void Clip2Attached_Click(object sender, RibbonControlEventArgs e)
		{
			ClipToNewAttached(false, false, false);
		}

		private void bt_Clip2Attached2_Click(object sender, RibbonControlEventArgs e)
		{
			ClipToNewAttached(true, false, false);
		}

		#endregion //Clip2AttachedEvent

		#region Clip2CompressAttachedEvent

		private void bt_Clip2CompressAttached_Click(object sender, RibbonControlEventArgs e)
		{
			ClipToNewAttached(false, true, true);
		}

		private void bt_Clip2CompressAttached2_Click(object sender, RibbonControlEventArgs e)
		{
			ClipToNewAttached(true, true, true);
		}
		#endregion //Clip2CompressAttachedEvent

		private void bt_sp_urlDecode_Click(object sender, RibbonControlEventArgs e)
		{
			var urlEnc = Clipboard.GetText();
			if (string.IsNullOrEmpty(urlEnc) == false)
			{
				Clipboard.SetText(Uri.UnescapeDataString(urlEnc).Replace("?Web=1", ""));
			}
		}

		#region CompressEvent
		private void bt_Attached2Compress_Click(object sender, RibbonControlEventArgs e)
		{
			AttachedCompress(false);
		}

		private void bt_Attached2CompressSetting_Click(object sender, RibbonControlEventArgs e)
		{
			AttachedCompress(true);
		}
		#endregion //Compress

		private void bt_opneTemp_Click(object sender, RibbonControlEventArgs e)
		{
			Process.Start(FileIo.TempFilePath);
		}

		private void bt_NewPassMail_Click(object sender, RibbonControlEventArgs e)
		{
			if (this.CompressSettings.Count == 0)
			{
				return;
			}
			var listList = new List<string>();
			var settingsMap = this.CompressSettings.ToDictionary(i => Path.GetFileName(i.CompressFilePath));
			foreach (var attachment in mailItem.Attachments.Cast<Attachment>())
			{
				if (settingsMap.ContainsKey(attachment.FileName) == true && settingsMap[attachment.FileName].HasPassword == true)
				{
					var setting = settingsMap[attachment.FileName];
					var line = string.Format("ファイル名：{0}\r\nパスワード：{1}\r\n", attachment.FileName, setting.PasswordText);
					listList.Add(line);
				}
			}

			if (listList.Count != 0)
			{
				Outlook.MailItem mail = mailItem.Copy();
				//添付ファイル削除
				var indexList = new List<Attachment>();
				foreach (var attachment in mail.Attachments.Cast<Attachment>())
				{
					indexList.Add(attachment);
				}
				indexList.ForEach(i =>
				{
					i.Delete();
				});
				mail.BodyFormat = OlBodyFormat.olFormatPlain;

				mail.Body = string.Join("\r\n", listList) + "------------------------------------------\r\n" + mail.Body;
				mail.Display();
			}
		}
	}

}
