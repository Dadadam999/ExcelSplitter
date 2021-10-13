
namespace ExcelSplitter
{
    partial class SettingsRange
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.topBar = new System.Windows.Forms.TableLayoutPanel();
            this.deleteRuleBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.addRuleBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.saveRuleBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.continueBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.listRules = new System.Windows.Forms.ListBox();
            this.body = new System.Windows.Forms.Panel();
            this.settingTable = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cellOne = new System.Windows.Forms.Panel();
            this.startNumber = new System.Windows.Forms.NumericUpDown();
            this.startLetter = new System.Windows.Forms.ComboBox();
            this.cellTwo = new System.Windows.Forms.Panel();
            this.endNumber = new System.Windows.Forms.NumericUpDown();
            this.endLetter = new System.Windows.Forms.ComboBox();
            this.selectShowTitle = new Bunifu.Framework.UI.BunifuCheckbox();
            this.selectSafeMethod = new System.Windows.Forms.ComboBox();
            this.topBar.SuspendLayout();
            this.body.SuspendLayout();
            this.settingTable.SuspendLayout();
            this.cellOne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startNumber)).BeginInit();
            this.cellTwo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // topBar
            // 
            this.topBar.ColumnCount = 4;
            this.topBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.topBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.topBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.topBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.topBar.Controls.Add(this.deleteRuleBtn, 0, 0);
            this.topBar.Controls.Add(this.addRuleBtn, 0, 0);
            this.topBar.Controls.Add(this.saveRuleBtn, 1, 0);
            this.topBar.Controls.Add(this.continueBtn, 3, 0);
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Margin = new System.Windows.Forms.Padding(0);
            this.topBar.Name = "topBar";
            this.topBar.RowCount = 1;
            this.topBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topBar.Size = new System.Drawing.Size(612, 30);
            this.topBar.TabIndex = 9;
            // 
            // deleteRuleBtn
            // 
            this.deleteRuleBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.deleteRuleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.deleteRuleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteRuleBtn.BorderRadius = 0;
            this.deleteRuleBtn.ButtonText = "Удалить правило";
            this.deleteRuleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteRuleBtn.DisabledColor = System.Drawing.Color.Gray;
            this.deleteRuleBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteRuleBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.deleteRuleBtn.Iconimage = null;
            this.deleteRuleBtn.Iconimage_right = null;
            this.deleteRuleBtn.Iconimage_right_Selected = null;
            this.deleteRuleBtn.Iconimage_Selected = null;
            this.deleteRuleBtn.IconMarginLeft = 0;
            this.deleteRuleBtn.IconMarginRight = 0;
            this.deleteRuleBtn.IconRightVisible = true;
            this.deleteRuleBtn.IconRightZoom = 0D;
            this.deleteRuleBtn.IconVisible = true;
            this.deleteRuleBtn.IconZoom = 90D;
            this.deleteRuleBtn.IsTab = false;
            this.deleteRuleBtn.Location = new System.Drawing.Point(156, 3);
            this.deleteRuleBtn.Name = "deleteRuleBtn";
            this.deleteRuleBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.deleteRuleBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.deleteRuleBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.deleteRuleBtn.selected = false;
            this.deleteRuleBtn.Size = new System.Drawing.Size(147, 24);
            this.deleteRuleBtn.TabIndex = 7;
            this.deleteRuleBtn.Text = "Удалить правило";
            this.deleteRuleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deleteRuleBtn.Textcolor = System.Drawing.Color.White;
            this.deleteRuleBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteRuleBtn.Click += new System.EventHandler(this.deleteRuleBtn_Click);
            // 
            // addRuleBtn
            // 
            this.addRuleBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.addRuleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.addRuleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addRuleBtn.BorderRadius = 0;
            this.addRuleBtn.ButtonText = "Добавить правило";
            this.addRuleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addRuleBtn.DisabledColor = System.Drawing.Color.Gray;
            this.addRuleBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addRuleBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.addRuleBtn.Iconimage = null;
            this.addRuleBtn.Iconimage_right = null;
            this.addRuleBtn.Iconimage_right_Selected = null;
            this.addRuleBtn.Iconimage_Selected = null;
            this.addRuleBtn.IconMarginLeft = 0;
            this.addRuleBtn.IconMarginRight = 0;
            this.addRuleBtn.IconRightVisible = true;
            this.addRuleBtn.IconRightZoom = 0D;
            this.addRuleBtn.IconVisible = true;
            this.addRuleBtn.IconZoom = 90D;
            this.addRuleBtn.IsTab = false;
            this.addRuleBtn.Location = new System.Drawing.Point(3, 3);
            this.addRuleBtn.Name = "addRuleBtn";
            this.addRuleBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.addRuleBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.addRuleBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.addRuleBtn.selected = false;
            this.addRuleBtn.Size = new System.Drawing.Size(147, 24);
            this.addRuleBtn.TabIndex = 4;
            this.addRuleBtn.Text = "Добавить правило";
            this.addRuleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addRuleBtn.Textcolor = System.Drawing.Color.White;
            this.addRuleBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRuleBtn.Click += new System.EventHandler(this.addRuleBtn_Click);
            // 
            // saveRuleBtn
            // 
            this.saveRuleBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.saveRuleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.saveRuleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveRuleBtn.BorderRadius = 0;
            this.saveRuleBtn.ButtonText = "Сохранить правило";
            this.saveRuleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveRuleBtn.DisabledColor = System.Drawing.Color.Gray;
            this.saveRuleBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveRuleBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.saveRuleBtn.Iconimage = null;
            this.saveRuleBtn.Iconimage_right = null;
            this.saveRuleBtn.Iconimage_right_Selected = null;
            this.saveRuleBtn.Iconimage_Selected = null;
            this.saveRuleBtn.IconMarginLeft = 0;
            this.saveRuleBtn.IconMarginRight = 0;
            this.saveRuleBtn.IconRightVisible = true;
            this.saveRuleBtn.IconRightZoom = 0D;
            this.saveRuleBtn.IconVisible = true;
            this.saveRuleBtn.IconZoom = 90D;
            this.saveRuleBtn.IsTab = false;
            this.saveRuleBtn.Location = new System.Drawing.Point(309, 3);
            this.saveRuleBtn.Name = "saveRuleBtn";
            this.saveRuleBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.saveRuleBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.saveRuleBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.saveRuleBtn.selected = false;
            this.saveRuleBtn.Size = new System.Drawing.Size(147, 24);
            this.saveRuleBtn.TabIndex = 5;
            this.saveRuleBtn.Text = "Сохранить правило";
            this.saveRuleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveRuleBtn.Textcolor = System.Drawing.Color.White;
            this.saveRuleBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveRuleBtn.Click += new System.EventHandler(this.saveRuleBtn_Click);
            // 
            // continueBtn
            // 
            this.continueBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.continueBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.continueBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.continueBtn.BorderRadius = 0;
            this.continueBtn.ButtonText = "Далее";
            this.continueBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.continueBtn.DisabledColor = System.Drawing.Color.Gray;
            this.continueBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.continueBtn.Iconimage = null;
            this.continueBtn.Iconimage_right = null;
            this.continueBtn.Iconimage_right_Selected = null;
            this.continueBtn.Iconimage_Selected = null;
            this.continueBtn.IconMarginLeft = 0;
            this.continueBtn.IconMarginRight = 0;
            this.continueBtn.IconRightVisible = true;
            this.continueBtn.IconRightZoom = 0D;
            this.continueBtn.IconVisible = true;
            this.continueBtn.IconZoom = 90D;
            this.continueBtn.IsTab = false;
            this.continueBtn.Location = new System.Drawing.Point(462, 3);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.continueBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.continueBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.continueBtn.selected = false;
            this.continueBtn.Size = new System.Drawing.Size(147, 24);
            this.continueBtn.TabIndex = 6;
            this.continueBtn.Text = "Далее";
            this.continueBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.continueBtn.Textcolor = System.Drawing.Color.White;
            this.continueBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueBtn.Click += new System.EventHandler(this.continueBtn_Click);
            // 
            // listRules
            // 
            this.listRules.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listRules.Dock = System.Windows.Forms.DockStyle.Left;
            this.listRules.FormattingEnabled = true;
            this.listRules.Location = new System.Drawing.Point(0, 0);
            this.listRules.Name = "listRules";
            this.listRules.Size = new System.Drawing.Size(82, 335);
            this.listRules.TabIndex = 10;
            this.listRules.SelectedIndexChanged += new System.EventHandler(this.listRules_SelectedIndexChanged);
            // 
            // body
            // 
            this.body.Controls.Add(this.settingTable);
            this.body.Controls.Add(this.listRules);
            this.body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body.Location = new System.Drawing.Point(0, 30);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(612, 335);
            this.body.TabIndex = 11;
            // 
            // settingTable
            // 
            this.settingTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.settingTable.ColumnCount = 2;
            this.settingTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.75803F));
            this.settingTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.24197F));
            this.settingTable.Controls.Add(this.label1, 0, 0);
            this.settingTable.Controls.Add(this.label2, 0, 1);
            this.settingTable.Controls.Add(this.label3, 0, 2);
            this.settingTable.Controls.Add(this.label4, 0, 3);
            this.settingTable.Controls.Add(this.cellOne, 1, 0);
            this.settingTable.Controls.Add(this.cellTwo, 1, 1);
            this.settingTable.Controls.Add(this.selectShowTitle, 1, 3);
            this.settingTable.Controls.Add(this.selectSafeMethod, 1, 2);
            this.settingTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingTable.Location = new System.Drawing.Point(82, 0);
            this.settingTable.Name = "settingTable";
            this.settingTable.RowCount = 5;
            this.settingTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.settingTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.settingTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.settingTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.settingTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.settingTable.Size = new System.Drawing.Size(530, 125);
            this.settingTable.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Начало диапазона";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(4, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Конец диапазона";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(4, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Способ сохранения";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(4, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Подписывать ячейки в файле";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cellOne
            // 
            this.cellOne.Controls.Add(this.startNumber);
            this.cellOne.Controls.Add(this.startLetter);
            this.cellOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cellOne.Location = new System.Drawing.Point(172, 4);
            this.cellOne.Name = "cellOne";
            this.cellOne.Size = new System.Drawing.Size(354, 24);
            this.cellOne.TabIndex = 4;
            // 
            // startNumber
            // 
            this.startNumber.BackColor = System.Drawing.Color.WhiteSmoke;
            this.startNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.startNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startNumber.Location = new System.Drawing.Point(74, 0);
            this.startNumber.Margin = new System.Windows.Forms.Padding(0);
            this.startNumber.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.startNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startNumber.Name = "startNumber";
            this.startNumber.Size = new System.Drawing.Size(280, 16);
            this.startNumber.TabIndex = 1;
            this.startNumber.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.startNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // startLetter
            // 
            this.startLetter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.startLetter.Dock = System.Windows.Forms.DockStyle.Left;
            this.startLetter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startLetter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startLetter.FormattingEnabled = true;
            this.startLetter.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.startLetter.Location = new System.Drawing.Point(0, 0);
            this.startLetter.Name = "startLetter";
            this.startLetter.Size = new System.Drawing.Size(74, 21);
            this.startLetter.TabIndex = 0;
            // 
            // cellTwo
            // 
            this.cellTwo.Controls.Add(this.endNumber);
            this.cellTwo.Controls.Add(this.endLetter);
            this.cellTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cellTwo.Location = new System.Drawing.Point(172, 35);
            this.cellTwo.Name = "cellTwo";
            this.cellTwo.Size = new System.Drawing.Size(354, 24);
            this.cellTwo.TabIndex = 5;
            // 
            // endNumber
            // 
            this.endNumber.BackColor = System.Drawing.Color.WhiteSmoke;
            this.endNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.endNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.endNumber.Location = new System.Drawing.Point(74, 0);
            this.endNumber.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.endNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.endNumber.Name = "endNumber";
            this.endNumber.Size = new System.Drawing.Size(280, 16);
            this.endNumber.TabIndex = 1;
            this.endNumber.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.endNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // endLetter
            // 
            this.endLetter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.endLetter.Dock = System.Windows.Forms.DockStyle.Left;
            this.endLetter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.endLetter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endLetter.FormattingEnabled = true;
            this.endLetter.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.endLetter.Location = new System.Drawing.Point(0, 0);
            this.endLetter.Name = "endLetter";
            this.endLetter.Size = new System.Drawing.Size(74, 21);
            this.endLetter.TabIndex = 0;
            // 
            // selectShowTitle
            // 
            this.selectShowTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.selectShowTitle.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.selectShowTitle.Checked = true;
            this.selectShowTitle.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.selectShowTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectShowTitle.ForeColor = System.Drawing.Color.White;
            this.selectShowTitle.Location = new System.Drawing.Point(172, 97);
            this.selectShowTitle.Name = "selectShowTitle";
            this.selectShowTitle.Size = new System.Drawing.Size(20, 20);
            this.selectShowTitle.TabIndex = 6;
            // 
            // selectSafeMethod
            // 
            this.selectSafeMethod.BackColor = System.Drawing.Color.WhiteSmoke;
            this.selectSafeMethod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectSafeMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectSafeMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectSafeMethod.FormattingEnabled = true;
            this.selectSafeMethod.Items.AddRange(new object[] {
            "Сохранить каждую ячейку диапазона в отдальный файл",
            "Сохранить весь диапазон в один файл"});
            this.selectSafeMethod.Location = new System.Drawing.Point(172, 66);
            this.selectSafeMethod.Name = "selectSafeMethod";
            this.selectSafeMethod.Size = new System.Drawing.Size(354, 21);
            this.selectSafeMethod.TabIndex = 7;
            // 
            // SettingsRange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.body);
            this.Controls.Add(this.topBar);
            this.Name = "SettingsRange";
            this.Size = new System.Drawing.Size(612, 365);
            this.topBar.ResumeLayout(false);
            this.body.ResumeLayout(false);
            this.settingTable.ResumeLayout(false);
            this.cellOne.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.startNumber)).EndInit();
            this.cellTwo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.endNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel topBar;
        private Bunifu.Framework.UI.BunifuFlatButton continueBtn;
        private Bunifu.Framework.UI.BunifuFlatButton addRuleBtn;
        private Bunifu.Framework.UI.BunifuFlatButton saveRuleBtn;
        private System.Windows.Forms.ListBox listRules;
        private System.Windows.Forms.Panel body;
        private System.Windows.Forms.TableLayoutPanel settingTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel cellOne;
        private System.Windows.Forms.Panel cellTwo;
        private Bunifu.Framework.UI.BunifuCheckbox selectShowTitle;
        private System.Windows.Forms.NumericUpDown startNumber;
        private System.Windows.Forms.ComboBox startLetter;
        private System.Windows.Forms.NumericUpDown endNumber;
        private System.Windows.Forms.ComboBox endLetter;
        private System.Windows.Forms.ComboBox selectSafeMethod;
        private Bunifu.Framework.UI.BunifuFlatButton deleteRuleBtn;
    }
}
