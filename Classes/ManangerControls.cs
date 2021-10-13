using System.Collections.Generic;
using System.Windows.Forms;

namespace ExcelSplitter
{
    public class ManangerControls
    {
        private Panel _panelOut;
        private List<UserControl> _controls = new List<UserControl>();

        public ManangerControls(Panel panelOut) => _panelOut = panelOut;
        public void ShowControl(string name) => _controls.ForEach(uc => { uc.Visible = uc.Name == name; });

        public void InitControl(UserControl control, string name)
        {
            control.Dock = DockStyle.Fill;
            control.Visible = false;
            control.Name = name;
            _controls.Add(control);
            _panelOut.Controls.Add(control);
        }
    }
}