using ExifLibrary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PhotoArchivist
{
    public partial class ArchivistMainForm : Form
    {
        public ArchivistMainForm()
        {
            InitializeComponent();
        }

        private void ArchivistMainForm_Load(object sender, EventArgs e)
        {

        }

        // Select Source root folder
        private void button1_Click(object sender, EventArgs e)
        {
            var dlg = this.SourceFolderDlg;
            dlg.InitialDirectory = "Z:\\Users\\Shared\\";
            if (this.SourceFolderDlg.ShowDialog() == DialogResult.OK)
            {
                var sourceFolder = this.SourceFolderDlg.SelectedPath;
                this.SourceFolder.Text = sourceFolder;
            }
        }

        // Select Archive root folder
        private void button2_Click(object sender, EventArgs e)
        {
            var dlg = this.ArchiveFolderDlg;
            dlg.InitialDirectory = "Z:\\Users\\Shared\\";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var archiveFolder = dlg.SelectedPath;
                this.ArchiveFolder.Text = archiveFolder;
            }
        }

        private void CollectBtn_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(this.SourceFolder.Text))
            {
                //this.FileList.Clear();
                this.FileListBox.ClearSelected();
                this.FileListBox.Items.Clear();
                int maxRows = 40;
                var selected = Directory.GetFiles(this.SourceFolder.Text, this.Extensions.Text.Split(';')[0]);
                //string delimit = "";
                for (int i = 0; i < selected.Length && i < maxRows; i++)
                {
                    var imageName = Path.GetFileName(selected[i]);
                    //this.FileList.Text += $"{delimit}{imageName}";
                    //delimit = "\n";
                    this.FileListBox.Items.Add(imageName);
                }
                this.FileListBox.SelectedIndex = 0;
            }
        }

        private void ShowDetails_Click(object sender, EventArgs e)
        {
            this.Details.ClearSelected();
            this.Details.Items.Clear();
            string? target = this.FileListBox.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(target))
            {
                var targetPath = $"{SourceFolder.Text}\\{target}";
                var file = ImageFile.FromFile(targetPath);
                {
                    object ?imageTitle = file.Properties.Get(ExifTag.WindowsTitle);
                    if (imageTitle==null) //  || imageTitle.ToString() == "")
                    {
                        try
                        {
                            file.Properties.Add(ExifTag.WindowsTitle, target);
                            file.Save(targetPath);
                        }
                        catch { _ = "here"; }
                    }


                    var props = file.Properties;
                    foreach (var item in props)
                    {
                        if (!String.IsNullOrEmpty($"{item.Value}"))
                        {
                            string txt = $"ExifTag: {(int)(item.Tag - 100000),8} Name: {item.Name,-32} Value: {item.Value}";
                            this.Details.Items.Add(txt);
                        }
                    }
                }
            }
        }

    }
}
