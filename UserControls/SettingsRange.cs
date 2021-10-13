using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ExcelSplitter
{
    public partial class SettingsRange : UserControl
    {
        private Main _main = Main.Self;
        private List<Rule> _rules = Main.Self.Rules;
        private ExcelLetter _excelLetter = new ExcelLetter();

        private void listRules_SelectedIndexChanged(object sender, EventArgs e) => RefrasFrontSettings();

        public SettingsRange()
        {
            InitializeComponent();
            AddRule();
        }

        private void RefrashList()
        {
            if (_rules.Count > 0)
            {
                listRules.Items.Clear();
                int index = listRules.SelectedIndex < 0 ? 0 : listRules.SelectedIndex;
                listRules.Items.AddRange(_rules.Select(x => x.Name).ToArray());
                listRules.SelectedIndex = index;
            }
        }

        private void RefrasFrontSettings()
        {
            if (_rules.Count > 0 && listRules.SelectedIndex >= 0)
            {
                Rule rule = _rules.Find(x => x.Name == listRules.Items[listRules.SelectedIndex].ToString());
                startLetter.SelectedIndex = _excelLetter.GetNumber(rule.StartRange.Letter) - 1;
                startNumber.Value = rule.StartRange.Number;
                endLetter.SelectedIndex = _excelLetter.GetNumber(rule.EndRange.Letter) - 1;
                endNumber.Value = rule.EndRange.Number;
                selectSafeMethod.SelectedIndex = rule.SafeMethod;
                selectShowTitle.Checked = rule.HasShowTitle;
            }
        }

        private void SafeSettings()
        {
            if (listRules.SelectedIndex >= 0 &&
                _rules.Count > 0 &&
                listRules.SelectedIndex >= 0 &&
                startLetter.SelectedItem != null &&
                endLetter.SelectedItem != null
            )
            {
                Rule rule = _rules.Find(x => x.Name == listRules.Items[listRules.SelectedIndex].ToString());
                rule.StartRange.Letter = startLetter.SelectedItem.ToString();
                rule.StartRange.Number = Convert.ToInt32(startNumber.Value);
                rule.EndRange.Letter = endLetter.SelectedItem.ToString();
                rule.EndRange.Number = Convert.ToInt32(endNumber.Value);
                rule.SafeMethod = selectSafeMethod.SelectedIndex;
                rule.HasShowTitle = selectShowTitle.Checked;
            }
        }

        private void AddRule()
        {
            Rule rule = new Rule();
            rule.id = _rules.Count > 0 ? _rules.Max(x => x.id) + 1 : 1;
            rule.Name = "Правило " + rule.id.ToString();
            rule.StartRange = new ExcelCell
            {
                Letter = "A",
                Number = 1
            };
            rule.EndRange = new ExcelCell
            {
                Letter = "B",
                Number = 2
            };

            _rules.Add(rule);
            RefrashList();
            RefrasFrontSettings();
        }

        private void DeleteRule()
        {
            if (_rules.Count > 0 && listRules.SelectedIndex >= 0)
                _rules.Remove(_rules.Find(x => x.Name == listRules.Items[listRules.SelectedIndex].ToString()));

            RefrashList();
            RefrasFrontSettings();
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            SafeSettings();

            _main.SafeFiles.Enabled = true;
            _main.ManangerControl.ShowControl("SaveFiles");
        }

        private void addRuleBtn_Click(object sender, EventArgs e)
        {
            AddRule();

            if (_rules.Count > 0)
                continueBtn.Enabled = true;
        }

        private void deleteRuleBtn_Click(object sender, EventArgs e)
        {
            DeleteRule();

            if (_rules.Count < 0)
                continueBtn.Enabled = false;
        }

        private void saveRuleBtn_Click(object sender, EventArgs e)
        {
            SafeSettings();
            MessageBox.Show("Правило сохранено!");
        }
    }
}