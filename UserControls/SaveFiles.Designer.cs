
namespace ExcelSplitter
{
    partial class SaveFiles
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cell2 = new System.Windows.Forms.Panel();
            this.directory = new System.Windows.Forms.TextBox();
            this.selectDirectoryBtn = new System.Windows.Forms.Button();
            this.fileNameTemplate = new System.Windows.Forms.RichTextBox();
            this.topBar = new System.Windows.Forms.TableLayoutPanel();
            this.continueBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.splitBody = new System.Windows.Forms.SplitContainer();
            this.logFile = new System.Windows.Forms.RichTextBox();
            this.logRule = new System.Windows.Forms.RichTextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.cell2.SuspendLayout();
            this.topBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitBody)).BeginInit();
            this.splitBody.Panel1.SuspendLayout();
            this.splitBody.Panel2.SuspendLayout();
            this.splitBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.28699F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.71301F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cell2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.fileNameTemplate, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(670, 110);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите конечную папку сохранения";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(4, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 82);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите имя файла по шаблону\r\n%file% - название исходного файла\r\n%date% - текущая" +
    " дата\r\n%rule% - имя правила\r\n%number% - номер файла\r\n%number_rule% - номер прави" +
    "ла";
            // 
            // cell2
            // 
            this.cell2.Controls.Add(this.directory);
            this.cell2.Controls.Add(this.selectDirectoryBtn);
            this.cell2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cell2.Location = new System.Drawing.Point(220, 4);
            this.cell2.Name = "cell2";
            this.cell2.Size = new System.Drawing.Size(446, 19);
            this.cell2.TabIndex = 2;
            // 
            // directory
            // 
            this.directory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.directory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.directory.Location = new System.Drawing.Point(0, 0);
            this.directory.Name = "directory";
            this.directory.Size = new System.Drawing.Size(416, 13);
            this.directory.TabIndex = 1;
            this.directory.Text = "C:\\";
            // 
            // selectDirectoryBtn
            // 
            this.selectDirectoryBtn.BackgroundImage = global::ExcelSplitter.Properties.Resources.directory_icons;
            this.selectDirectoryBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.selectDirectoryBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.selectDirectoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectDirectoryBtn.Location = new System.Drawing.Point(416, 0);
            this.selectDirectoryBtn.Name = "selectDirectoryBtn";
            this.selectDirectoryBtn.Size = new System.Drawing.Size(30, 19);
            this.selectDirectoryBtn.TabIndex = 0;
            this.selectDirectoryBtn.UseVisualStyleBackColor = true;
            this.selectDirectoryBtn.Click += new System.EventHandler(this.selectDirectoryBtn_Click);
            // 
            // fileNameTemplate
            // 
            this.fileNameTemplate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fileNameTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileNameTemplate.Location = new System.Drawing.Point(220, 30);
            this.fileNameTemplate.Name = "fileNameTemplate";
            this.fileNameTemplate.Size = new System.Drawing.Size(446, 76);
            this.fileNameTemplate.TabIndex = 3;
            this.fileNameTemplate.Text = "%file%_%date%_%rule%.txt";
            // 
            // topBar
            // 
            this.topBar.ColumnCount = 4;
            this.topBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.topBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.topBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.topBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.topBar.Controls.Add(this.continueBtn, 3, 0);
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Margin = new System.Windows.Forms.Padding(0);
            this.topBar.Name = "topBar";
            this.topBar.RowCount = 1;
            this.topBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topBar.Size = new System.Drawing.Size(670, 30);
            this.topBar.TabIndex = 10;
            // 
            // continueBtn
            // 
            this.continueBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.continueBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.continueBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.continueBtn.BorderRadius = 0;
            this.continueBtn.ButtonText = "Запуск";
            this.continueBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.continueBtn.DisabledColor = System.Drawing.Color.Gray;
            this.continueBtn.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.continueBtn.Location = new System.Drawing.Point(504, 3);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.continueBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.continueBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.continueBtn.selected = false;
            this.continueBtn.Size = new System.Drawing.Size(163, 24);
            this.continueBtn.TabIndex = 6;
            this.continueBtn.Text = "Запуск";
            this.continueBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.continueBtn.Textcolor = System.Drawing.Color.White;
            this.continueBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueBtn.Click += new System.EventHandler(this.continueBtn_Click);
            // 
            // splitBody
            // 
            this.splitBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitBody.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitBody.Location = new System.Drawing.Point(0, 143);
            this.splitBody.Name = "splitBody";
            // 
            // splitBody.Panel1
            // 
            this.splitBody.Panel1.Controls.Add(this.logFile);
            // 
            // splitBody.Panel2
            // 
            this.splitBody.Panel2.Controls.Add(this.logRule);
            this.splitBody.Size = new System.Drawing.Size(670, 300);
            this.splitBody.SplitterDistance = 331;
            this.splitBody.TabIndex = 0;
            // 
            // logFile
            // 
            this.logFile.BackColor = System.Drawing.Color.White;
            this.logFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logFile.Location = new System.Drawing.Point(0, 0);
            this.logFile.Name = "logFile";
            this.logFile.ReadOnly = true;
            this.logFile.Size = new System.Drawing.Size(329, 298);
            this.logFile.TabIndex = 0;
            this.logFile.Text = "";
            // 
            // logRule
            // 
            this.logRule.BackColor = System.Drawing.Color.White;
            this.logRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logRule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logRule.Location = new System.Drawing.Point(0, 0);
            this.logRule.Name = "logRule";
            this.logRule.ReadOnly = true;
            this.logRule.Size = new System.Drawing.Size(333, 298);
            this.logRule.TabIndex = 1;
            this.logRule.Text = "";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 140);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(670, 3);
            this.splitter1.TabIndex = 12;
            this.splitter1.TabStop = false;
            // 
            // SaveFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.splitBody);
            this.Controls.Add(this.topBar);
            this.Name = "SaveFiles";
            this.Size = new System.Drawing.Size(670, 443);
            this.VisibleChanged += new System.EventHandler(this.SaveFiles_VisibleChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.cell2.ResumeLayout(false);
            this.cell2.PerformLayout();
            this.topBar.ResumeLayout(false);
            this.splitBody.Panel1.ResumeLayout(false);
            this.splitBody.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitBody)).EndInit();
            this.splitBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel topBar;
        private Bunifu.Framework.UI.BunifuFlatButton continueBtn;
        private System.Windows.Forms.SplitContainer splitBody;
        private System.Windows.Forms.RichTextBox logFile;
        private System.Windows.Forms.RichTextBox logRule;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel cell2;
        private System.Windows.Forms.TextBox directory;
        private System.Windows.Forms.Button selectDirectoryBtn;
        private System.Windows.Forms.RichTextBox fileNameTemplate;
    }
}
