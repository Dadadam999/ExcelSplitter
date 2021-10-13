using System;
using System.Windows.Forms;

namespace ExcelSplitter
{
    public partial class SelectFiles : UserControl
    {
        private Main _main = Main.Self;
        public SelectFiles() => InitializeComponent();
        
        private void AddFilesBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                listFiles.Items.AddRange(openFileDialog1.FileNames);

            if (listFiles.Items.Count > 0)
                continueBtn.Enabled = true;
        }

        private void DeleteFilesBtn_Click(object sender, EventArgs e)
        {
            if (listFiles.SelectedIndex >= 0)
                listFiles.Items.Remove(listFiles.SelectedItem);

            if (listFiles.Items.Count < 0)
                continueBtn.Enabled = false;
        }

        private void ContinueBtn_Click(object sender, EventArgs e)
        {
            foreach (string path in listFiles.Items)
                _main.FilesPath.Add(path);

            _main.SettingRange.Enabled = true;
            _main.ManangerControl.ShowControl("SettingsRange");
        }
    }
}