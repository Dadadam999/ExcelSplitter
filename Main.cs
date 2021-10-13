using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ExcelSplitter
{
    public partial class Main : Form
    {
        public static Main Self { get; set; }
        public ManangerControls ManangerControl { get; set; }
        public List<Rule> Rules { get; set; } = new List<Rule>();
        public List<string> FilesPath { get; set; } = new List<string>();
        public string FileNameTemplate { get; set; }
        public string DirectorySave { get; set; }
        public bool IsWork { get; set; } = false;

        private bool _resizerEnable = false;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void topBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public Main()
        {
            InitializeComponent();
            Self = this;

            ManangerControl = new ManangerControls(controlsContainer);
            ManangerControl.InitControl(new SelectFiles(), "SelectFiles");
            ManangerControl.InitControl(new SettingsRange(), "SettingsRange");
            ManangerControl.InitControl(new SaveFiles(), "SaveFiles");
            ManangerControl.InitControl(new WorkStatus(), "WorkStatus");
            ManangerControl.ShowControl("SelectFiles");
        }

        private void CloseApp_Click(object sender, EventArgs e) => Application.Exit();
        private void HideApp_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;
        private void ExpandApp_Click(object sender, EventArgs e) => WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Maximized : WindowState = FormWindowState.Normal;
        private void SelectingFiles_Click(object sender, EventArgs e) => ManangerControl.ShowControl("SelectFiles");
        private void SettingRange_Click(object sender, EventArgs e) => ManangerControl.ShowControl("SettingsRange");
        private void SafeFiles_Click(object sender, EventArgs e) => ManangerControl.ShowControl("SaveFiles");
        private void WorkingStatus_Click(object sender, EventArgs e) => ManangerControl.ShowControl("WorkStatus");

        private void Resizser_MouseDown(object sender, MouseEventArgs e)
        {
            _resizerEnable = true;
            Resizser_MouseMove(sender, e);
        }

        private void Resizser_MouseMove(object sender, MouseEventArgs e)
        {
            if (_resizerEnable)
            {
                Width = (MousePosition.X - Left) < 200 ? 200 : (MousePosition.X - Left);
                Height = MousePosition.Y - Top;
            }
        }

        private void Resizser_MouseUp(object sender, MouseEventArgs e) => _resizerEnable = false;

        public void SetWork(bool state)
        {
            IsWork = state;
            SelectingFiles.Enabled = !state;
            SettingRange.Enabled = !state;
            SafeFiles.Enabled = !state;
            WorkingStatus.Enabled = !state;
        }
    }
}