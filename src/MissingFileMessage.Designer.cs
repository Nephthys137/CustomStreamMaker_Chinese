namespace CustomStreamMaker
{
    partial class MissingFileMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MissingFileMessage));
            this.label1 = new System.Windows.Forms.Label();
            this.AddAddressable = new System.Windows.Forms.Button();
            this.AddAsAssetBundle = new System.Windows.Forms.Button();
            this.IgnoreAsset = new System.Windows.Forms.Button();
            this.CustomAsset_Group = new System.Windows.Forms.GroupBox();
            this.PastFilePath_Text = new System.Windows.Forms.TextBox();
            this.Asset_Name_Label = new System.Windows.Forms.Label();
            this.FilePath_Label = new System.Windows.Forms.Label();
            this.FileType_Label = new System.Windows.Forms.Label();
            this.AssetType_Label = new System.Windows.Forms.Label();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.NewFilePath_Text = new System.Windows.Forms.TextBox();
            this.IgnoreAllAsset = new System.Windows.Forms.Button();
            this.CustomAsset_Group.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.Location = new System.Drawing.Point(18, 208);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(622, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "找不到此自定义资产的文件. \r\n\r\n您可以将此资产连接到下面的新文件，也可以忽略此错误.";
            // 
            // AddAddressable
            // 
            this.AddAddressable.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AddAddressable.Location = new System.Drawing.Point(15, 385);
            this.AddAddressable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddAddressable.Name = "AddAddressable";
            this.AddAddressable.Size = new System.Drawing.Size(190, 43);
            this.AddAddressable.TabIndex = 2;
            this.AddAddressable.Text = "添加为Addressable";
            this.AddAddressable.UseVisualStyleBackColor = true;
            this.AddAddressable.Click += new System.EventHandler(this.AddAddressable_Click);
            // 
            // AddAsAssetBundle
            // 
            this.AddAsAssetBundle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AddAsAssetBundle.Location = new System.Drawing.Point(214, 385);
            this.AddAsAssetBundle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddAsAssetBundle.Name = "AddAsAssetBundle";
            this.AddAsAssetBundle.Size = new System.Drawing.Size(190, 43);
            this.AddAsAssetBundle.TabIndex = 3;
            this.AddAsAssetBundle.Text = "添加为Asset Bundle";
            this.AddAsAssetBundle.UseVisualStyleBackColor = true;
            this.AddAsAssetBundle.Click += new System.EventHandler(this.AddAsAssetBundle_Click);
            // 
            // IgnoreAsset
            // 
            this.IgnoreAsset.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.IgnoreAsset.Location = new System.Drawing.Point(519, 385);
            this.IgnoreAsset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IgnoreAsset.Name = "IgnoreAsset";
            this.IgnoreAsset.Size = new System.Drawing.Size(116, 43);
            this.IgnoreAsset.TabIndex = 4;
            this.IgnoreAsset.Text = "忽略";
            this.IgnoreAsset.UseVisualStyleBackColor = true;
            this.IgnoreAsset.Click += new System.EventHandler(this.DeleteAsset_Click);
            // 
            // CustomAsset_Group
            // 
            this.CustomAsset_Group.Controls.Add(this.PastFilePath_Text);
            this.CustomAsset_Group.Controls.Add(this.Asset_Name_Label);
            this.CustomAsset_Group.Controls.Add(this.FilePath_Label);
            this.CustomAsset_Group.Controls.Add(this.FileType_Label);
            this.CustomAsset_Group.Controls.Add(this.AssetType_Label);
            this.CustomAsset_Group.Location = new System.Drawing.Point(22, 18);
            this.CustomAsset_Group.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomAsset_Group.Name = "CustomAsset_Group";
            this.CustomAsset_Group.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomAsset_Group.Size = new System.Drawing.Size(736, 165);
            this.CustomAsset_Group.TabIndex = 2;
            this.CustomAsset_Group.TabStop = false;
            this.CustomAsset_Group.Text = "自定义资产";
            // 
            // PastFilePath_Text
            // 
            this.PastFilePath_Text.BackColor = System.Drawing.SystemColors.Control;
            this.PastFilePath_Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PastFilePath_Text.Location = new System.Drawing.Point(108, 114);
            this.PastFilePath_Text.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PastFilePath_Text.Multiline = true;
            this.PastFilePath_Text.Name = "PastFilePath_Text";
            this.PastFilePath_Text.Size = new System.Drawing.Size(620, 32);
            this.PastFilePath_Text.TabIndex = 2;
            this.PastFilePath_Text.TabStop = false;
            this.PastFilePath_Text.Text = "OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO\r\n";
            // 
            // Asset_Name_Label
            // 
            this.Asset_Name_Label.AutoSize = true;
            this.Asset_Name_Label.Location = new System.Drawing.Point(10, 55);
            this.Asset_Name_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Asset_Name_Label.Name = "Asset_Name_Label";
            this.Asset_Name_Label.Size = new System.Drawing.Size(107, 18);
            this.Asset_Name_Label.TabIndex = 1;
            this.Asset_Name_Label.Text = "资产名:";
            // 
            // FilePath_Label
            // 
            this.FilePath_Label.AutoSize = true;
            this.FilePath_Label.Location = new System.Drawing.Point(9, 114);
            this.FilePath_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FilePath_Label.Name = "FilePath_Label";
            this.FilePath_Label.Size = new System.Drawing.Size(98, 18);
            this.FilePath_Label.TabIndex = 1;
            this.FilePath_Label.Text = "文件路径:";
            // 
            // FileType_Label
            // 
            this.FileType_Label.AutoSize = true;
            this.FileType_Label.Location = new System.Drawing.Point(10, 83);
            this.FileType_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FileType_Label.Name = "FileType_Label";
            this.FileType_Label.Size = new System.Drawing.Size(98, 18);
            this.FileType_Label.TabIndex = 1;
            this.FileType_Label.Text = "文件类型:";
            // 
            // AssetType_Label
            // 
            this.AssetType_Label.AutoSize = true;
            this.AssetType_Label.Location = new System.Drawing.Point(10, 28);
            this.AssetType_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AssetType_Label.Name = "AssetType_Label";
            this.AssetType_Label.Size = new System.Drawing.Size(107, 18);
            this.AssetType_Label.TabIndex = 0;
            this.AssetType_Label.Text = "资产类型:";
            // 
            // BrowseButton
            // 
            this.BrowseButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BrowseButton.Location = new System.Drawing.Point(22, 289);
            this.BrowseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(102, 33);
            this.BrowseButton.TabIndex = 0;
            this.BrowseButton.Text = "浏览";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // NewFilePath_Text
            // 
            this.NewFilePath_Text.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NewFilePath_Text.Location = new System.Drawing.Point(135, 292);
            this.NewFilePath_Text.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewFilePath_Text.Name = "NewFilePath_Text";
            this.NewFilePath_Text.Size = new System.Drawing.Size(622, 28);
            this.NewFilePath_Text.TabIndex = 1;
            this.NewFilePath_Text.DoubleClick += new System.EventHandler(this.NewFilePath_Text_DoubleClick);
            // 
            // IgnoreAllAsset
            // 
            this.IgnoreAllAsset.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.IgnoreAllAsset.Location = new System.Drawing.Point(648, 385);
            this.IgnoreAllAsset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IgnoreAllAsset.Name = "IgnoreAllAsset";
            this.IgnoreAllAsset.Size = new System.Drawing.Size(116, 43);
            this.IgnoreAllAsset.TabIndex = 5;
            this.IgnoreAllAsset.Text = "忽略全部";
            this.IgnoreAllAsset.UseVisualStyleBackColor = true;
            this.IgnoreAllAsset.Click += new System.EventHandler(this.IgnoreAllAsset_Click);
            // 
            // MissingFileMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 447);
            this.ControlBox = false;
            this.Controls.Add(this.NewFilePath_Text);
            this.Controls.Add(this.CustomAsset_Group);
            this.Controls.Add(this.IgnoreAllAsset);
            this.Controls.Add(this.IgnoreAsset);
            this.Controls.Add(this.AddAsAssetBundle);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.AddAddressable);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MissingFileMessage";
            this.Text = "检测到丢失的文件";
            this.Load += new System.EventHandler(this.MissingFileMessage_Load);
            this.CustomAsset_Group.ResumeLayout(false);
            this.CustomAsset_Group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddAddressable;
        private System.Windows.Forms.Button AddAsAssetBundle;
        private System.Windows.Forms.Button IgnoreAsset;
        private System.Windows.Forms.GroupBox CustomAsset_Group;
        private System.Windows.Forms.Label Asset_Name_Label;
        private System.Windows.Forms.Label FileType_Label;
        private System.Windows.Forms.Label AssetType_Label;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.TextBox PastFilePath_Text;
        private System.Windows.Forms.Label FilePath_Label;
        private System.Windows.Forms.TextBox NewFilePath_Text;
        private System.Windows.Forms.Button IgnoreAllAsset;
    }
}