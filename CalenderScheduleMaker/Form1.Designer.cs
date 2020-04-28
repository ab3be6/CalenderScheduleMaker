namespace CalenderScheduleMaker
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dtp_StartDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_StopDate = new System.Windows.Forms.DateTimePicker();
            this.cb_TextFormat = new System.Windows.Forms.ComboBox();
            this.dgv_EventsList = new System.Windows.Forms.DataGridView();
            this.btn_SaveSettings = new System.Windows.Forms.Button();
            this.sfd_SaveSettings = new System.Windows.Forms.SaveFileDialog();
            this.btn_ImportSettings = new System.Windows.Forms.Button();
            this.ofd_ImportSettings = new System.Windows.Forms.OpenFileDialog();
            this.btn_AddColumn = new System.Windows.Forms.Button();
            this.btn_DelColumn = new System.Windows.Forms.Button();
            this.btn_ExportFile = new System.Windows.Forms.Button();
            this.sfd_SaveFile = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Message = new System.Windows.Forms.TextBox();
            this.chkb_AlarmEnable = new System.Windows.Forms.CheckBox();
            this.cb_AlarmBefore = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EventsList)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_StartDate
            // 
            this.dtp_StartDate.Location = new System.Drawing.Point(250, 24);
            this.dtp_StartDate.Name = "dtp_StartDate";
            this.dtp_StartDate.Size = new System.Drawing.Size(124, 19);
            this.dtp_StartDate.TabIndex = 0;
            this.dtp_StartDate.ValueChanged += new System.EventHandler(this.dtp_StartDate_ValueChanged);
            // 
            // dtp_StopDate
            // 
            this.dtp_StopDate.Location = new System.Drawing.Point(380, 24);
            this.dtp_StopDate.Name = "dtp_StopDate";
            this.dtp_StopDate.Size = new System.Drawing.Size(124, 19);
            this.dtp_StopDate.TabIndex = 1;
            this.dtp_StopDate.ValueChanged += new System.EventHandler(this.dtp_StopDate_ValueChanged);
            // 
            // cb_TextFormat
            // 
            this.cb_TextFormat.FormattingEnabled = true;
            this.cb_TextFormat.Location = new System.Drawing.Point(510, 24);
            this.cb_TextFormat.Name = "cb_TextFormat";
            this.cb_TextFormat.Size = new System.Drawing.Size(140, 20);
            this.cb_TextFormat.TabIndex = 3;
            this.cb_TextFormat.TextChanged += new System.EventHandler(this.cb_TextFormat_TextChanged);
            // 
            // dgv_EventsList
            // 
            this.dgv_EventsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_EventsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_EventsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_EventsList.Location = new System.Drawing.Point(12, 78);
            this.dgv_EventsList.MultiSelect = false;
            this.dgv_EventsList.Name = "dgv_EventsList";
            this.dgv_EventsList.RowTemplate.Height = 21;
            this.dgv_EventsList.Size = new System.Drawing.Size(837, 172);
            this.dgv_EventsList.TabIndex = 4;
            this.dgv_EventsList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_EventsList_CellValueChanged);
            this.dgv_EventsList.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgv_EventsList_CurrentCellDirtyStateChanged);
            // 
            // btn_SaveSettings
            // 
            this.btn_SaveSettings.Location = new System.Drawing.Point(130, 9);
            this.btn_SaveSettings.Name = "btn_SaveSettings";
            this.btn_SaveSettings.Size = new System.Drawing.Size(112, 35);
            this.btn_SaveSettings.TabIndex = 5;
            this.btn_SaveSettings.Text = "Save Settings";
            this.btn_SaveSettings.UseVisualStyleBackColor = true;
            this.btn_SaveSettings.Click += new System.EventHandler(this.btn_SaveSettings_Click);
            // 
            // sfd_SaveSettings
            // 
            this.sfd_SaveSettings.DefaultExt = "xml";
            this.sfd_SaveSettings.Filter = "User Setting File|*.xml";
            this.sfd_SaveSettings.Title = "Import User Setting File";
            // 
            // btn_ImportSettings
            // 
            this.btn_ImportSettings.Location = new System.Drawing.Point(12, 9);
            this.btn_ImportSettings.Name = "btn_ImportSettings";
            this.btn_ImportSettings.Size = new System.Drawing.Size(112, 35);
            this.btn_ImportSettings.TabIndex = 6;
            this.btn_ImportSettings.Text = "Import Settings";
            this.btn_ImportSettings.UseVisualStyleBackColor = true;
            this.btn_ImportSettings.Click += new System.EventHandler(this.btn_ImportSettings_Click);
            // 
            // ofd_ImportSettings
            // 
            this.ofd_ImportSettings.DefaultExt = "xml";
            this.ofd_ImportSettings.Filter = "User Setting File|*.xml";
            this.ofd_ImportSettings.Title = "Import User Setting File";
            // 
            // btn_AddColumn
            // 
            this.btn_AddColumn.Location = new System.Drawing.Point(12, 50);
            this.btn_AddColumn.Name = "btn_AddColumn";
            this.btn_AddColumn.Size = new System.Drawing.Size(112, 22);
            this.btn_AddColumn.TabIndex = 7;
            this.btn_AddColumn.Text = "Add Column";
            this.btn_AddColumn.UseVisualStyleBackColor = true;
            this.btn_AddColumn.Click += new System.EventHandler(this.btn_AddColumn_Click);
            // 
            // btn_DelColumn
            // 
            this.btn_DelColumn.Location = new System.Drawing.Point(130, 50);
            this.btn_DelColumn.Name = "btn_DelColumn";
            this.btn_DelColumn.Size = new System.Drawing.Size(112, 22);
            this.btn_DelColumn.TabIndex = 8;
            this.btn_DelColumn.Text = "Delete Column";
            this.btn_DelColumn.UseVisualStyleBackColor = true;
            this.btn_DelColumn.Click += new System.EventHandler(this.btn_DelColumn_Click);
            // 
            // btn_ExportFile
            // 
            this.btn_ExportFile.Location = new System.Drawing.Point(250, 49);
            this.btn_ExportFile.Name = "btn_ExportFile";
            this.btn_ExportFile.Size = new System.Drawing.Size(124, 23);
            this.btn_ExportFile.TabIndex = 9;
            this.btn_ExportFile.Text = "Export Calender File";
            this.btn_ExportFile.UseVisualStyleBackColor = true;
            this.btn_ExportFile.Click += new System.EventHandler(this.btn_ExportFile_Click);
            // 
            // sfd_SaveFile
            // 
            this.sfd_SaveFile.DefaultExt = "ics";
            this.sfd_SaveFile.Filter = "iCALファイル|*.ics";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "Stop Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "Text Encode";
            // 
            // tb_Message
            // 
            this.tb_Message.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Message.Cursor = System.Windows.Forms.Cursors.Default;
            this.tb_Message.Location = new System.Drawing.Point(656, 9);
            this.tb_Message.Multiline = true;
            this.tb_Message.Name = "tb_Message";
            this.tb_Message.ReadOnly = true;
            this.tb_Message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Message.Size = new System.Drawing.Size(193, 63);
            this.tb_Message.TabIndex = 13;
            // 
            // chkb_AlarmEnable
            // 
            this.chkb_AlarmEnable.AutoSize = true;
            this.chkb_AlarmEnable.Location = new System.Drawing.Point(380, 53);
            this.chkb_AlarmEnable.Name = "chkb_AlarmEnable";
            this.chkb_AlarmEnable.Size = new System.Drawing.Size(92, 16);
            this.chkb_AlarmEnable.TabIndex = 14;
            this.chkb_AlarmEnable.Text = "Alarm Enable";
            this.chkb_AlarmEnable.UseVisualStyleBackColor = true;
            this.chkb_AlarmEnable.CheckedChanged += new System.EventHandler(this.chkb_AlarmEnable_CheckedChanged);
            // 
            // cb_AlarmBefore
            // 
            this.cb_AlarmBefore.FormattingEnabled = true;
            this.cb_AlarmBefore.Location = new System.Drawing.Point(583, 49);
            this.cb_AlarmBefore.Name = "cb_AlarmBefore";
            this.cb_AlarmBefore.Size = new System.Drawing.Size(67, 20);
            this.cb_AlarmBefore.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(508, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "Alarm Before";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 262);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_AlarmBefore);
            this.Controls.Add(this.chkb_AlarmEnable);
            this.Controls.Add(this.tb_Message);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ExportFile);
            this.Controls.Add(this.btn_DelColumn);
            this.Controls.Add(this.btn_AddColumn);
            this.Controls.Add(this.btn_ImportSettings);
            this.Controls.Add(this.btn_SaveSettings);
            this.Controls.Add(this.dgv_EventsList);
            this.Controls.Add(this.cb_TextFormat);
            this.Controls.Add(this.dtp_StopDate);
            this.Controls.Add(this.dtp_StartDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(875, 300);
            this.Name = "MainForm";
            this.Text = "Calender Schedule Maker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EventsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_StartDate;
        private System.Windows.Forms.DateTimePicker dtp_StopDate;
        private System.Windows.Forms.ComboBox cb_TextFormat;
        private System.Windows.Forms.Button btn_SaveSettings;
        private System.Windows.Forms.SaveFileDialog sfd_SaveSettings;
        private System.Windows.Forms.Button btn_ImportSettings;
        private System.Windows.Forms.OpenFileDialog ofd_ImportSettings;
        private System.Windows.Forms.Button btn_AddColumn;
        private System.Windows.Forms.Button btn_DelColumn;
        private System.Windows.Forms.Button btn_ExportFile;
        private System.Windows.Forms.SaveFileDialog sfd_SaveFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_EventsList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Message;
        private System.Windows.Forms.CheckBox chkb_AlarmEnable;
        private System.Windows.Forms.ComboBox cb_AlarmBefore;
        private System.Windows.Forms.Label label4;
    }
}

