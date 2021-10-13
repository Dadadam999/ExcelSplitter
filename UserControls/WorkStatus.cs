using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace ExcelSplitter
{
    public partial class WorkStatus : UserControl
    {
        private Main _main = Main.Self;
        private List<Rule> _rules = Main.Self.Rules;
        private List<string> _filesPath = Main.Self.FilesPath;
        private string _fileNameTemplate = Main.Self.FileNameTemplate;
        private string _directorySave = Main.Self.DirectorySave;
        private ExcelProvider _excelProvider = new ExcelProvider();

        public WorkStatus() => InitializeComponent();
        private void OpenFolderBtn_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start(_directorySave);

        private void WorkStatus_VisibleChanged(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy && Visible)
            {
                _fileNameTemplate = Main.Self.FileNameTemplate;
                _directorySave = Main.Self.DirectorySave;
                _main.SetWork(true);
                openFolderBtn.Enabled = false;
                animationLoading.Visible = true;
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int countFile = 0;

            _filesPath.ForEach(file =>
            {
                _excelProvider.OpenFile(file);
                Invoke((MethodInvoker)delegate { resultLog.Text += $"Открыт файл: {file}\n"; });
                countFile++;
                int countRule = 0;

                _rules.ForEach(rule =>
                {
                    countRule++;
                    Invoke((MethodInvoker)delegate { resultLog.Text += $"Полученны ячейки по правилу: {rule.Name}\n"; });
                    SavetoFile(
                        _excelProvider.GetRange(rule.StartRange, rule.EndRange),
                        PrepareFileName(_fileNameTemplate, _directorySave, file, rule.Name, countFile, countRule),
                        rule.SafeMethod,
                        rule.HasShowTitle
                        );
                    Invoke((MethodInvoker)delegate { resultLog.Text += $"Ячейки по правилу: {rule.Name} сохранены в {(rule.SafeMethod == 0 ? "файлы" : "файл")}\n"; });
                });

                _excelProvider.CloseFile();
                Invoke((MethodInvoker)delegate { resultLog.Text += $"Закрыт файл: {file}\n"; });
            });
        }

        private void SavetoFile(List<ExcelCell> cells, (string path, string fileName) pathFile, int safeMethod, bool hasShowTitle)
        {
            string value = "";
            int countFile = 1;

            cells.ForEach(cell =>
            {
                if (safeMethod == 0)
                {
                    value = hasShowTitle ? cell.Letter + cell.Number.ToString() + " - " + cell.Value : cell.Value;
                    File.WriteAllText($@"{pathFile.path}\{countFile++}_{pathFile.fileName}", value);
                }
                else
                {
                    value += hasShowTitle ? cell.Letter + cell.Number.ToString() + " - " + cell.Value : cell.Value;
                    value += Environment.NewLine;
                }
            });

            if (safeMethod != 0)
                File.WriteAllText($@"{pathFile.path}\{pathFile.fileName}", value);
        }

        private (string path, string fileName) PrepareFileName(string template, string sourcePath, string sourceFile, string ruleName, int number, int numberRule)
        {
            template = template.Replace("%file%", Path.GetFileNameWithoutExtension(sourceFile));
            template = template.Replace("%date%", DateTime.Now.ToString().Replace(":", "-").Replace(".", "-"));
            template = template.Replace("%rule%", ruleName.Replace(" ", ""));
            template = template.Replace("%number%", number.ToString());
            template = template.Replace("%number_rule%", numberRule.ToString());
            return (path: sourcePath, fileName: template);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            _excelProvider.CloseExcel();
            _main.SetWork(false);
            openFolderBtn.Enabled = true;
            animationLoading.Visible = false;

            MessageBox.Show("Работа завершена! Можете открыть папку с файлами.");
        }
    }
}