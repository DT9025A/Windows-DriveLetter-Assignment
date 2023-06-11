namespace DriveLetter
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_DriveVolume = new System.Windows.Forms.ComboBox();
            this.button_Apply = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_VolumeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_FileSystem = new System.Windows.Forms.Label();
            this.label_SpaceInfo = new System.Windows.Forms.Label();
            this.comboBox_AvailableLetter = new System.Windows.Forms.ComboBox();
            this.checkBox_AssignNewVolumeLabel = new System.Windows.Forms.CheckBox();
            this.button_RefreshVolume = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择驱动器";
            // 
            // comboBox_DriveVolume
            // 
            this.comboBox_DriveVolume.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_DriveVolume.FormattingEnabled = true;
            this.comboBox_DriveVolume.Location = new System.Drawing.Point(116, 18);
            this.comboBox_DriveVolume.Name = "comboBox_DriveVolume";
            this.comboBox_DriveVolume.Size = new System.Drawing.Size(361, 26);
            this.comboBox_DriveVolume.TabIndex = 1;
            this.comboBox_DriveVolume.SelectedIndexChanged += new System.EventHandler(this.comboBox_DriveVolume_SelectedIndexChanged);
            // 
            // button_Apply
            // 
            this.button_Apply.Enabled = false;
            this.button_Apply.Location = new System.Drawing.Point(488, 125);
            this.button_Apply.Name = "button_Apply";
            this.button_Apply.Size = new System.Drawing.Size(93, 31);
            this.button_Apply.TabIndex = 2;
            this.button_Apply.Text = "应用";
            this.button_Apply.UseVisualStyleBackColor = true;
            this.button_Apply.Click += new System.EventHandler(this.button_Apply_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "驱动器卷标";
            // 
            // label_VolumeLabel
            // 
            this.label_VolumeLabel.AutoSize = true;
            this.label_VolumeLabel.Location = new System.Drawing.Point(116, 60);
            this.label_VolumeLabel.Name = "label_VolumeLabel";
            this.label_VolumeLabel.Size = new System.Drawing.Size(44, 18);
            this.label_VolumeLabel.TabIndex = 4;
            this.label_VolumeLabel.Text = "NULL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "文件系统";
            // 
            // label_FileSystem
            // 
            this.label_FileSystem.AutoSize = true;
            this.label_FileSystem.Location = new System.Drawing.Point(116, 94);
            this.label_FileSystem.Name = "label_FileSystem";
            this.label_FileSystem.Size = new System.Drawing.Size(44, 18);
            this.label_FileSystem.TabIndex = 6;
            this.label_FileSystem.Text = "NULL";
            // 
            // label_SpaceInfo
            // 
            this.label_SpaceInfo.AutoSize = true;
            this.label_SpaceInfo.Location = new System.Drawing.Point(196, 94);
            this.label_SpaceInfo.Name = "label_SpaceInfo";
            this.label_SpaceInfo.Size = new System.Drawing.Size(44, 18);
            this.label_SpaceInfo.TabIndex = 7;
            this.label_SpaceInfo.Text = "NULL";
            // 
            // comboBox_AvailableLetter
            // 
            this.comboBox_AvailableLetter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_AvailableLetter.Enabled = false;
            this.comboBox_AvailableLetter.FormattingEnabled = true;
            this.comboBox_AvailableLetter.Location = new System.Drawing.Point(199, 125);
            this.comboBox_AvailableLetter.Name = "comboBox_AvailableLetter";
            this.comboBox_AvailableLetter.Size = new System.Drawing.Size(85, 26);
            this.comboBox_AvailableLetter.TabIndex = 10;
            // 
            // checkBox_AssignNewVolumeLabel
            // 
            this.checkBox_AssignNewVolumeLabel.AutoSize = true;
            this.checkBox_AssignNewVolumeLabel.Location = new System.Drawing.Point(15, 127);
            this.checkBox_AssignNewVolumeLabel.Name = "checkBox_AssignNewVolumeLabel";
            this.checkBox_AssignNewVolumeLabel.Size = new System.Drawing.Size(178, 22);
            this.checkBox_AssignNewVolumeLabel.TabIndex = 11;
            this.checkBox_AssignNewVolumeLabel.Text = "指派新的驱动器号";
            this.checkBox_AssignNewVolumeLabel.UseVisualStyleBackColor = true;
            this.checkBox_AssignNewVolumeLabel.CheckedChanged += new System.EventHandler(this.checkBox_AssignNewVolumeLabel_CheckedChanged);
            // 
            // button_RefreshVolume
            // 
            this.button_RefreshVolume.Location = new System.Drawing.Point(488, 15);
            this.button_RefreshVolume.Name = "button_RefreshVolume";
            this.button_RefreshVolume.Size = new System.Drawing.Size(93, 31);
            this.button_RefreshVolume.TabIndex = 12;
            this.button_RefreshVolume.Text = "刷新";
            this.button_RefreshVolume.UseVisualStyleBackColor = true;
            this.button_RefreshVolume.Click += new System.EventHandler(this.button_RefreshVolume_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 168);
            this.Controls.Add(this.button_RefreshVolume);
            this.Controls.Add(this.checkBox_AssignNewVolumeLabel);
            this.Controls.Add(this.comboBox_AvailableLetter);
            this.Controls.Add(this.label_SpaceInfo);
            this.Controls.Add(this.label_FileSystem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_VolumeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Apply);
            this.Controls.Add(this.comboBox_DriveVolume);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.Text = "驱动器号分配";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_DriveVolume;
        private System.Windows.Forms.Button button_Apply;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_VolumeLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_FileSystem;
        private System.Windows.Forms.Label label_SpaceInfo;
        private System.Windows.Forms.ComboBox comboBox_AvailableLetter;
        private System.Windows.Forms.CheckBox checkBox_AssignNewVolumeLabel;
        private System.Windows.Forms.Button button_RefreshVolume;
    }
}

