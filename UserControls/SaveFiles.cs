using System;
using System.Windows.Forms;

namespace ExcelSplitter
{
    public partial class SaveFiles : UserControl
    {
        private Main _main = Main.Self;
        public SaveFiles() => InitializeComponent();

        private void SaveFiles_VisibleChanged(object sender, EventArgs e)
        {
            logFile.Text = "";
            logRule.Text = "";

            foreach (string path in _main.FilesPath)
                logFile.Text += path + Environment.NewLine;

            foreach (Rule rule in _main.Rules)
                logRule.Text += $"Диапазон от {rule.StartRange.Letter}{rule.StartRange.Number} до {rule.EndRange.Letter}{rule.EndRange.Number} сохранить ячйки { (rule.SafeMethod == 0 ? "в отдельный" : "целиком в") } файл { (rule.HasShowTitle ? "с заголовками" : "без заголовков") } \n";
        }

        private void selectDirectoryBtn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                directory.Text = folderBrowserDialog1.SelectedPath;
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            _main.FileNameTemplate = fileNameTemplate.Text;
            _main.DirectorySave = directory.Text;
            _main.ManangerControl.ShowControl("WorkStatus");
        }
    }
}