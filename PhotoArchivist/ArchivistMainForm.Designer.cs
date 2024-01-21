namespace PhotoArchivist
{
    partial class ArchivistMainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            SourceFolder = new TextBox();
            groupBox1 = new GroupBox();
            Ext_Label = new Label();
            Extensions = new TextBox();
            groupBox2 = new GroupBox();
            button2 = new Button();
            ArchiveFolder = new TextBox();
            SourceFolderDlg = new FolderBrowserDialog();
            ArchiveFolderDlg = new FolderBrowserDialog();
            CollectBtn = new Button();
            FileListBox = new ListBox();
            ShowDetails = new Button();
            Details = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(6, 22);
            button1.Name = "button1";
            button1.Size = new Size(107, 23);
            button1.TabIndex = 0;
            button1.Text = "Select Folder";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SourceFolder
            // 
            SourceFolder.Location = new Point(123, 23);
            SourceFolder.Name = "SourceFolder";
            SourceFolder.Size = new Size(319, 23);
            SourceFolder.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Ext_Label);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(Extensions);
            groupBox1.Controls.Add(SourceFolder);
            groupBox1.Location = new Point(12, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(448, 78);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Image Source";
            // 
            // Ext_Label
            // 
            Ext_Label.AutoSize = true;
            Ext_Label.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Ext_Label.Location = new Point(24, 54);
            Ext_Label.Name = "Ext_Label";
            Ext_Label.Size = new Size(85, 12);
            Ext_Label.TabIndex = 2;
            Ext_Label.Text = "Extensions";
            // 
            // Extensions
            // 
            Extensions.Font = new Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Extensions.Location = new Point(123, 49);
            Extensions.Name = "Extensions";
            Extensions.Size = new Size(319, 19);
            Extensions.TabIndex = 1;
            Extensions.Text = "*.jp*g";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(ArchiveFolder);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(448, 48);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Archive Home";
            // 
            // button2
            // 
            button2.Location = new Point(6, 19);
            button2.Name = "button2";
            button2.Size = new Size(107, 23);
            button2.TabIndex = 0;
            button2.Text = "Select Folder";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ArchiveFolder
            // 
            ArchiveFolder.Location = new Point(123, 20);
            ArchiveFolder.Name = "ArchiveFolder";
            ArchiveFolder.Size = new Size(319, 23);
            ArchiveFolder.TabIndex = 1;
            // 
            // CollectBtn
            // 
            CollectBtn.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            CollectBtn.Location = new Point(16, 151);
            CollectBtn.Name = "CollectBtn";
            CollectBtn.Size = new Size(224, 28);
            CollectBtn.TabIndex = 5;
            CollectBtn.Text = "Select files ...";
            CollectBtn.TextAlign = ContentAlignment.MiddleLeft;
            CollectBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            CollectBtn.UseVisualStyleBackColor = true;
            CollectBtn.Click += CollectBtn_Click;
            // 
            // FileListBox
            // 
            FileListBox.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FileListBox.FormattingEnabled = true;
            FileListBox.Location = new Point(18, 185);
            FileListBox.Name = "FileListBox";
            FileListBox.Size = new Size(222, 719);
            FileListBox.TabIndex = 6;
            // 
            // ShowDetails
            // 
            ShowDetails.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ShowDetails.Location = new Point(267, 151);
            ShowDetails.Name = "ShowDetails";
            ShowDetails.Size = new Size(224, 28);
            ShowDetails.TabIndex = 5;
            ShowDetails.Text = "Show Details";
            ShowDetails.TextAlign = ContentAlignment.MiddleLeft;
            ShowDetails.TextImageRelation = TextImageRelation.TextBeforeImage;
            ShowDetails.UseVisualStyleBackColor = true;
            ShowDetails.Click += ShowDetails_Click;
            // 
            // Details
            // 
            Details.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Details.FormattingEnabled = true;
            Details.Location = new Point(267, 185);
            Details.Name = "Details";
            Details.Size = new Size(912, 719);
            Details.TabIndex = 6;
            // 
            // ArchivistMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1672, 912);
            Controls.Add(Details);
            Controls.Add(FileListBox);
            Controls.Add(ShowDetails);
            Controls.Add(CollectBtn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ArchivistMainForm";
            Text = "Antares(c) Photo Archivist";
            Load += ArchivistMainForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private TextBox SourceFolder;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button2;
        private TextBox ArchiveFolder;
        private FolderBrowserDialog SourceFolderDlg;
        private FolderBrowserDialog ArchiveFolderDlg;
        private Label Ext_Label;
        private TextBox Extensions;
        private Button CollectBtn;
        private ListBox FileListBox;
        private Button ShowDetails;
        private ListBox Details;
    }
}
