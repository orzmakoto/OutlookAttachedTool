namespace OutlookAttachedTool.SubWindow
{
	partial class InputFileName
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputFileName));
			this.tb_FileName = new System.Windows.Forms.TextBox();
			this.la_extension = new System.Windows.Forms.Label();
			this.bt_Cancel = new System.Windows.Forms.Button();
			this.bt_OK = new System.Windows.Forms.Button();
			this.pict_extension = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pict_extension)).BeginInit();
			this.SuspendLayout();
			// 
			// tb_FileName
			// 
			this.tb_FileName.Location = new System.Drawing.Point(47, 12);
			this.tb_FileName.Name = "tb_FileName";
			this.tb_FileName.Size = new System.Drawing.Size(165, 19);
			this.tb_FileName.TabIndex = 0;
			this.tb_FileName.TextChanged += new System.EventHandler(this.tb_FileName_TextChanged);
			this.tb_FileName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_FileName_KeyDown);
			// 
			// la_extension
			// 
			this.la_extension.AutoSize = true;
			this.la_extension.Location = new System.Drawing.Point(214, 19);
			this.la_extension.Name = "la_extension";
			this.la_extension.Size = new System.Drawing.Size(25, 12);
			this.la_extension.TabIndex = 1;
			this.la_extension.Text = ".***";
			// 
			// bt_Cancel
			// 
			this.bt_Cancel.Location = new System.Drawing.Point(164, 37);
			this.bt_Cancel.Name = "bt_Cancel";
			this.bt_Cancel.Size = new System.Drawing.Size(75, 23);
			this.bt_Cancel.TabIndex = 2;
			this.bt_Cancel.Text = "キャンセル";
			this.bt_Cancel.UseVisualStyleBackColor = true;
			this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
			// 
			// bt_OK
			// 
			this.bt_OK.Enabled = false;
			this.bt_OK.Location = new System.Drawing.Point(83, 37);
			this.bt_OK.Name = "bt_OK";
			this.bt_OK.Size = new System.Drawing.Size(75, 23);
			this.bt_OK.TabIndex = 3;
			this.bt_OK.Text = "OK";
			this.bt_OK.UseVisualStyleBackColor = true;
			this.bt_OK.Click += new System.EventHandler(this.bt_OK_Click);
			// 
			// pict_extension
			// 
			this.pict_extension.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pict_extension.Location = new System.Drawing.Point(12, 6);
			this.pict_extension.Name = "pict_extension";
			this.pict_extension.Size = new System.Drawing.Size(29, 29);
			this.pict_extension.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pict_extension.TabIndex = 4;
			this.pict_extension.TabStop = false;
			// 
			// InputFileName
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(248, 65);
			this.Controls.Add(this.pict_extension);
			this.Controls.Add(this.bt_OK);
			this.Controls.Add(this.bt_Cancel);
			this.Controls.Add(this.la_extension);
			this.Controls.Add(this.tb_FileName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "InputFileName";
			this.Text = "新しい添付ファイル名";
			((System.ComponentModel.ISupportInitialize)(this.pict_extension)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tb_FileName;
		private System.Windows.Forms.Label la_extension;
		private System.Windows.Forms.Button bt_Cancel;
		private System.Windows.Forms.Button bt_OK;
		private System.Windows.Forms.PictureBox pict_extension;
	}
}