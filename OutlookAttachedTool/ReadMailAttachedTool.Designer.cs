namespace OutlookAttachedTool
{
	partial class ReadMailAttachedTool : Microsoft.Office.Tools.Ribbon.RibbonBase
	{
		/// <summary>
		/// デザイナー変数が必要です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		public ReadMailAttachedTool()
			: base(Globals.Factory.GetRibbonFactory())
		{
			InitializeComponent();
		}

		/// <summary> 
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region コンポーネント デザイナーで生成されたコード

		/// <summary>
		/// デザイナーのサポートに必要なメソッドです。
		/// このメソッドの内容をコード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
            this.tab1111 = this.Factory.CreateRibbonTab();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.splitButton1 = this.Factory.CreateRibbonSplitButton();
            this.bt_Clip2Attached2 = this.Factory.CreateRibbonButton();
            this.separator2 = this.Factory.CreateRibbonSeparator();
            this.bt_Clip2CompressAttached = this.Factory.CreateRibbonSplitButton();
            this.bt_Clip2CompressAttached2 = this.Factory.CreateRibbonButton();
            this.group3 = this.Factory.CreateRibbonGroup();
            this.bt_Attached2Compress = this.Factory.CreateRibbonSplitButton();
            this.bt_Attached2CompressSetting = this.Factory.CreateRibbonButton();
            this.bt_NewPassMail = this.Factory.CreateRibbonButton();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.btn_saveTemp = this.Factory.CreateRibbonButton();
            this.group4 = this.Factory.CreateRibbonGroup();
            this.t_sp_urlDecode = this.Factory.CreateRibbonButton();
            this.bt_opneTemp = this.Factory.CreateRibbonButton();
            this.tab1111.SuspendLayout();
            this.group2.SuspendLayout();
            this.group3.SuspendLayout();
            this.group1.SuspendLayout();
            this.group4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1111
            // 
            this.tab1111.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1111.Groups.Add(this.group2);
            this.tab1111.Groups.Add(this.group3);
            this.tab1111.Groups.Add(this.group1);
            this.tab1111.Groups.Add(this.group4);
            this.tab1111.Label = "添付ツール";
            this.tab1111.Name = "tab1111";
            // 
            // group2
            // 
            this.group2.Items.Add(this.splitButton1);
            this.group2.Items.Add(this.separator2);
            this.group2.Items.Add(this.bt_Clip2CompressAttached);
            this.group2.Label = "クリップボード";
            this.group2.Name = "group2";
            // 
            // splitButton1
            // 
            this.splitButton1.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.splitButton1.Enabled = false;
            this.splitButton1.Image = global::OutlookAttachedTool.Properties.Resources.addAttached;
            this.splitButton1.Items.Add(this.bt_Clip2Attached2);
            this.splitButton1.Label = "追加    ";
            this.splitButton1.Name = "splitButton1";
            // 
            // bt_Clip2Attached2
            // 
            this.bt_Clip2Attached2.Image = global::OutlookAttachedTool.Properties.Resources.Plus;
            this.bt_Clip2Attached2.Label = "名前を付けて追加";
            this.bt_Clip2Attached2.Name = "bt_Clip2Attached2";
            this.bt_Clip2Attached2.ShowImage = true;
            // 
            // separator2
            // 
            this.separator2.Name = "separator2";
            // 
            // bt_Clip2CompressAttached
            // 
            this.bt_Clip2CompressAttached.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.bt_Clip2CompressAttached.Enabled = false;
            this.bt_Clip2CompressAttached.Image = global::OutlookAttachedTool.Properties.Resources.addAttachedCompress;
            this.bt_Clip2CompressAttached.Items.Add(this.bt_Clip2CompressAttached2);
            this.bt_Clip2CompressAttached.Label = "圧縮して追加";
            this.bt_Clip2CompressAttached.Name = "bt_Clip2CompressAttached";
            // 
            // bt_Clip2CompressAttached2
            // 
            this.bt_Clip2CompressAttached2.Image = global::OutlookAttachedTool.Properties.Resources.Plus;
            this.bt_Clip2CompressAttached2.Label = "名前を付けて追加";
            this.bt_Clip2CompressAttached2.Name = "bt_Clip2CompressAttached2";
            this.bt_Clip2CompressAttached2.ShowImage = true;
            // 
            // group3
            // 
            this.group3.Items.Add(this.bt_Attached2Compress);
            this.group3.Items.Add(this.bt_NewPassMail);
            this.group3.Label = "圧縮";
            this.group3.Name = "group3";
            // 
            // bt_Attached2Compress
            // 
            this.bt_Attached2Compress.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.bt_Attached2Compress.Enabled = false;
            this.bt_Attached2Compress.Image = global::OutlookAttachedTool.Properties.Resources.AttachedToCompress;
            this.bt_Attached2Compress.Items.Add(this.bt_Attached2CompressSetting);
            this.bt_Attached2Compress.Label = "添付を圧縮";
            this.bt_Attached2Compress.Name = "bt_Attached2Compress";
            // 
            // bt_Attached2CompressSetting
            // 
            this.bt_Attached2CompressSetting.Image = global::OutlookAttachedTool.Properties.Resources.PanelSettings;
            this.bt_Attached2CompressSetting.Label = "詳細設定";
            this.bt_Attached2CompressSetting.Name = "bt_Attached2CompressSetting";
            this.bt_Attached2CompressSetting.ShowImage = true;
            // 
            // bt_NewPassMail
            // 
            this.bt_NewPassMail.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.bt_NewPassMail.Enabled = false;
            this.bt_NewPassMail.Image = global::OutlookAttachedTool.Properties.Resources.addAttachedName;
            this.bt_NewPassMail.Label = "パスワードメール作成";
            this.bt_NewPassMail.Name = "bt_NewPassMail";
            this.bt_NewPassMail.ShowImage = true;
            // 
            // group1
            // 
            this.group1.Items.Add(this.btn_saveTemp);
            this.group1.Label = "保存";
            this.group1.Name = "group1";
            // 
            // btn_saveTemp
            // 
            this.btn_saveTemp.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btn_saveTemp.Image = global::OutlookAttachedTool.Properties.Resources._3floppy_mount;
            this.btn_saveTemp.Label = "一時　保存";
            this.btn_saveTemp.Name = "btn_saveTemp";
            this.btn_saveTemp.ShowImage = true;
            this.btn_saveTemp.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_saveTemp_Click);
            // 
            // group4
            // 
            this.group4.Items.Add(this.t_sp_urlDecode);
            this.group4.Items.Add(this.bt_opneTemp);
            this.group4.Label = "その他";
            this.group4.Name = "group4";
            // 
            // t_sp_urlDecode
            // 
            this.t_sp_urlDecode.Enabled = false;
            this.t_sp_urlDecode.Image = global::OutlookAttachedTool.Properties.Resources.Organize;
            this.t_sp_urlDecode.Label = "URLデコード";
            this.t_sp_urlDecode.Name = "t_sp_urlDecode";
            this.t_sp_urlDecode.ShowImage = true;
            // 
            // bt_opneTemp
            // 
            this.bt_opneTemp.Enabled = false;
            this.bt_opneTemp.Image = global::OutlookAttachedTool.Properties.Resources.Folder;
            this.bt_opneTemp.Label = "作業フォルダを開く";
            this.bt_opneTemp.Name = "bt_opneTemp";
            this.bt_opneTemp.ShowImage = true;
            this.bt_opneTemp.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.bt_opneTemp_Click);
            // 
            // ReadMailAttachedTool
            // 
            this.Name = "ReadMailAttachedTool";
            this.RibbonType = "Microsoft.Outlook.Mail.Read";
            this.Tabs.Add(this.tab1111);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.ReadMailAttachedTool_Load);
            this.tab1111.ResumeLayout(false);
            this.tab1111.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.group3.ResumeLayout(false);
            this.group3.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group4.ResumeLayout(false);
            this.group4.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1111;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_saveTemp;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
		internal Microsoft.Office.Tools.Ribbon.RibbonSplitButton splitButton1;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton bt_Clip2Attached2;
		internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator2;
		internal Microsoft.Office.Tools.Ribbon.RibbonSplitButton bt_Clip2CompressAttached;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton bt_Clip2CompressAttached2;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup group3;
		internal Microsoft.Office.Tools.Ribbon.RibbonSplitButton bt_Attached2Compress;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton bt_Attached2CompressSetting;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton bt_NewPassMail;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup group4;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton t_sp_urlDecode;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton bt_opneTemp;
	}

	partial class ThisRibbonCollection
	{
		internal ReadMailAttachedTool ReadMailAttachedTool
		{
			get { return this.GetRibbon<ReadMailAttachedTool>(); }
		}
	}
}
