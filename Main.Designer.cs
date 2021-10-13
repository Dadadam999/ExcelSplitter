
namespace ExcelSplitter
{
    partial class Main
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.topBar = new System.Windows.Forms.Panel();
            this.expandApp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.hideApp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.closeApp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bodyContainer = new System.Windows.Forms.Panel();
            this.controlsContainer = new System.Windows.Forms.Panel();
            this.footer = new System.Windows.Forms.Panel();
            this.resizser = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.leftBar = new System.Windows.Forms.Panel();
            this.WorkingStatus = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SafeFiles = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SettingRange = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SelectingFiles = new Bunifu.Framework.UI.BunifuFlatButton();
            this.topBar.SuspendLayout();
            this.bodyContainer.SuspendLayout();
            this.footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resizser)).BeginInit();
            this.leftBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // topBar
            // 
            this.topBar.Controls.Add(this.expandApp);
            this.topBar.Controls.Add(this.hideApp);
            this.topBar.Controls.Add(this.closeApp);
            this.topBar.Controls.Add(this.label1);
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(800, 30);
            this.topBar.TabIndex = 0;
            this.topBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topBar_MouseDown);
            // 
            // expandApp
            // 
            this.expandApp.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.expandApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.expandApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.expandApp.BorderRadius = 0;
            this.expandApp.ButtonText = "◻";
            this.expandApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expandApp.DisabledColor = System.Drawing.Color.Gray;
            this.expandApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.expandApp.Iconcolor = System.Drawing.Color.Transparent;
            this.expandApp.Iconimage = null;
            this.expandApp.Iconimage_right = null;
            this.expandApp.Iconimage_right_Selected = null;
            this.expandApp.Iconimage_Selected = null;
            this.expandApp.IconMarginLeft = 0;
            this.expandApp.IconMarginRight = 0;
            this.expandApp.IconRightVisible = true;
            this.expandApp.IconRightZoom = 0D;
            this.expandApp.IconVisible = true;
            this.expandApp.IconZoom = 90D;
            this.expandApp.IsTab = false;
            this.expandApp.Location = new System.Drawing.Point(710, 0);
            this.expandApp.Name = "expandApp";
            this.expandApp.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.expandApp.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.expandApp.OnHoverTextColor = System.Drawing.Color.White;
            this.expandApp.selected = false;
            this.expandApp.Size = new System.Drawing.Size(30, 30);
            this.expandApp.TabIndex = 3;
            this.expandApp.Text = "◻";
            this.expandApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.expandApp.Textcolor = System.Drawing.Color.White;
            this.expandApp.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expandApp.Click += new System.EventHandler(this.ExpandApp_Click);
            // 
            // hideApp
            // 
            this.hideApp.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(89)))), ((int)(((byte)(25)))));
            this.hideApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(89)))), ((int)(((byte)(25)))));
            this.hideApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hideApp.BorderRadius = 0;
            this.hideApp.ButtonText = "_";
            this.hideApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hideApp.DisabledColor = System.Drawing.Color.Gray;
            this.hideApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.hideApp.Iconcolor = System.Drawing.Color.Transparent;
            this.hideApp.Iconimage = null;
            this.hideApp.Iconimage_right = null;
            this.hideApp.Iconimage_right_Selected = null;
            this.hideApp.Iconimage_Selected = null;
            this.hideApp.IconMarginLeft = 0;
            this.hideApp.IconMarginRight = 0;
            this.hideApp.IconRightVisible = true;
            this.hideApp.IconRightZoom = 0D;
            this.hideApp.IconVisible = true;
            this.hideApp.IconZoom = 90D;
            this.hideApp.IsTab = false;
            this.hideApp.Location = new System.Drawing.Point(740, 0);
            this.hideApp.Name = "hideApp";
            this.hideApp.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(89)))), ((int)(((byte)(25)))));
            this.hideApp.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.hideApp.OnHoverTextColor = System.Drawing.Color.White;
            this.hideApp.selected = false;
            this.hideApp.Size = new System.Drawing.Size(30, 30);
            this.hideApp.TabIndex = 2;
            this.hideApp.Text = "_";
            this.hideApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hideApp.Textcolor = System.Drawing.Color.White;
            this.hideApp.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideApp.Click += new System.EventHandler(this.HideApp_Click);
            // 
            // closeApp
            // 
            this.closeApp.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
            this.closeApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
            this.closeApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeApp.BorderRadius = 0;
            this.closeApp.ButtonText = "X";
            this.closeApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeApp.DisabledColor = System.Drawing.Color.Gray;
            this.closeApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeApp.Iconcolor = System.Drawing.Color.Transparent;
            this.closeApp.Iconimage = null;
            this.closeApp.Iconimage_right = null;
            this.closeApp.Iconimage_right_Selected = null;
            this.closeApp.Iconimage_Selected = null;
            this.closeApp.IconMarginLeft = 0;
            this.closeApp.IconMarginRight = 0;
            this.closeApp.IconRightVisible = true;
            this.closeApp.IconRightZoom = 0D;
            this.closeApp.IconVisible = true;
            this.closeApp.IconZoom = 90D;
            this.closeApp.IsTab = false;
            this.closeApp.Location = new System.Drawing.Point(770, 0);
            this.closeApp.Name = "closeApp";
            this.closeApp.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
            this.closeApp.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.closeApp.OnHoverTextColor = System.Drawing.Color.White;
            this.closeApp.selected = false;
            this.closeApp.Size = new System.Drawing.Size(30, 30);
            this.closeApp.TabIndex = 1;
            this.closeApp.Text = "X";
            this.closeApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeApp.Textcolor = System.Drawing.Color.White;
            this.closeApp.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeApp.Click += new System.EventHandler(this.CloseApp_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Excel Splitter";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bodyContainer
            // 
            this.bodyContainer.Controls.Add(this.controlsContainer);
            this.bodyContainer.Controls.Add(this.footer);
            this.bodyContainer.Controls.Add(this.splitter1);
            this.bodyContainer.Controls.Add(this.leftBar);
            this.bodyContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyContainer.Location = new System.Drawing.Point(0, 30);
            this.bodyContainer.Name = "bodyContainer";
            this.bodyContainer.Size = new System.Drawing.Size(800, 470);
            this.bodyContainer.TabIndex = 1;
            // 
            // controlsContainer
            // 
            this.controlsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlsContainer.Location = new System.Drawing.Point(183, 0);
            this.controlsContainer.Name = "controlsContainer";
            this.controlsContainer.Size = new System.Drawing.Size(617, 455);
            this.controlsContainer.TabIndex = 3;
            // 
            // footer
            // 
            this.footer.Controls.Add(this.resizser);
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(183, 455);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(617, 15);
            this.footer.TabIndex = 2;
            // 
            // resizser
            // 
            this.resizser.Dock = System.Windows.Forms.DockStyle.Right;
            this.resizser.Image = global::ExcelSplitter.Properties.Resources.icon_resize_1;
            this.resizser.Location = new System.Drawing.Point(602, 0);
            this.resizser.Name = "resizser";
            this.resizser.Size = new System.Drawing.Size(15, 15);
            this.resizser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resizser.TabIndex = 0;
            this.resizser.TabStop = false;
            this.resizser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Resizser_MouseDown);
            this.resizser.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Resizser_MouseMove);
            this.resizser.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Resizser_MouseUp);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Gainsboro;
            this.splitter1.Location = new System.Drawing.Point(180, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 470);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // leftBar
            // 
            this.leftBar.Controls.Add(this.WorkingStatus);
            this.leftBar.Controls.Add(this.SafeFiles);
            this.leftBar.Controls.Add(this.SettingRange);
            this.leftBar.Controls.Add(this.SelectingFiles);
            this.leftBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftBar.Location = new System.Drawing.Point(0, 0);
            this.leftBar.MinimumSize = new System.Drawing.Size(180, 200);
            this.leftBar.Name = "leftBar";
            this.leftBar.Size = new System.Drawing.Size(180, 470);
            this.leftBar.TabIndex = 0;
            // 
            // WorkingStatus
            // 
            this.WorkingStatus.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.WorkingStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.WorkingStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WorkingStatus.BorderRadius = 0;
            this.WorkingStatus.ButtonText = "Статус выполнения";
            this.WorkingStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WorkingStatus.DisabledColor = System.Drawing.Color.Gray;
            this.WorkingStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.WorkingStatus.Enabled = false;
            this.WorkingStatus.Iconcolor = System.Drawing.Color.Transparent;
            this.WorkingStatus.Iconimage = null;
            this.WorkingStatus.Iconimage_right = null;
            this.WorkingStatus.Iconimage_right_Selected = null;
            this.WorkingStatus.Iconimage_Selected = null;
            this.WorkingStatus.IconMarginLeft = 0;
            this.WorkingStatus.IconMarginRight = 0;
            this.WorkingStatus.IconRightVisible = true;
            this.WorkingStatus.IconRightZoom = 0D;
            this.WorkingStatus.IconVisible = true;
            this.WorkingStatus.IconZoom = 90D;
            this.WorkingStatus.IsTab = false;
            this.WorkingStatus.Location = new System.Drawing.Point(0, 150);
            this.WorkingStatus.Name = "WorkingStatus";
            this.WorkingStatus.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.WorkingStatus.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.WorkingStatus.OnHoverTextColor = System.Drawing.Color.White;
            this.WorkingStatus.selected = false;
            this.WorkingStatus.Size = new System.Drawing.Size(180, 50);
            this.WorkingStatus.TabIndex = 0;
            this.WorkingStatus.Text = "Статус выполнения";
            this.WorkingStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WorkingStatus.Textcolor = System.Drawing.Color.White;
            this.WorkingStatus.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkingStatus.Click += new System.EventHandler(this.WorkingStatus_Click);
            // 
            // SafeFiles
            // 
            this.SafeFiles.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.SafeFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.SafeFiles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SafeFiles.BorderRadius = 0;
            this.SafeFiles.ButtonText = "Сохранение файлов";
            this.SafeFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SafeFiles.DisabledColor = System.Drawing.Color.Gray;
            this.SafeFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.SafeFiles.Enabled = false;
            this.SafeFiles.Iconcolor = System.Drawing.Color.Transparent;
            this.SafeFiles.Iconimage = null;
            this.SafeFiles.Iconimage_right = null;
            this.SafeFiles.Iconimage_right_Selected = null;
            this.SafeFiles.Iconimage_Selected = null;
            this.SafeFiles.IconMarginLeft = 0;
            this.SafeFiles.IconMarginRight = 0;
            this.SafeFiles.IconRightVisible = true;
            this.SafeFiles.IconRightZoom = 0D;
            this.SafeFiles.IconVisible = true;
            this.SafeFiles.IconZoom = 90D;
            this.SafeFiles.IsTab = false;
            this.SafeFiles.Location = new System.Drawing.Point(0, 100);
            this.SafeFiles.Name = "SafeFiles";
            this.SafeFiles.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.SafeFiles.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.SafeFiles.OnHoverTextColor = System.Drawing.Color.White;
            this.SafeFiles.selected = false;
            this.SafeFiles.Size = new System.Drawing.Size(180, 50);
            this.SafeFiles.TabIndex = 0;
            this.SafeFiles.Text = "Сохранение файлов";
            this.SafeFiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SafeFiles.Textcolor = System.Drawing.Color.White;
            this.SafeFiles.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SafeFiles.Click += new System.EventHandler(this.SafeFiles_Click);
            // 
            // SettingRange
            // 
            this.SettingRange.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.SettingRange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.SettingRange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingRange.BorderRadius = 0;
            this.SettingRange.ButtonText = "Настройте диапозоны";
            this.SettingRange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingRange.DisabledColor = System.Drawing.Color.Gray;
            this.SettingRange.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingRange.Enabled = false;
            this.SettingRange.Iconcolor = System.Drawing.Color.Transparent;
            this.SettingRange.Iconimage = null;
            this.SettingRange.Iconimage_right = null;
            this.SettingRange.Iconimage_right_Selected = null;
            this.SettingRange.Iconimage_Selected = null;
            this.SettingRange.IconMarginLeft = 0;
            this.SettingRange.IconMarginRight = 0;
            this.SettingRange.IconRightVisible = true;
            this.SettingRange.IconRightZoom = 0D;
            this.SettingRange.IconVisible = true;
            this.SettingRange.IconZoom = 90D;
            this.SettingRange.IsTab = false;
            this.SettingRange.Location = new System.Drawing.Point(0, 50);
            this.SettingRange.Name = "SettingRange";
            this.SettingRange.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.SettingRange.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.SettingRange.OnHoverTextColor = System.Drawing.Color.White;
            this.SettingRange.selected = false;
            this.SettingRange.Size = new System.Drawing.Size(180, 50);
            this.SettingRange.TabIndex = 0;
            this.SettingRange.Text = "Настройте диапозоны";
            this.SettingRange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingRange.Textcolor = System.Drawing.Color.White;
            this.SettingRange.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingRange.Click += new System.EventHandler(this.SettingRange_Click);
            // 
            // SelectingFiles
            // 
            this.SelectingFiles.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.SelectingFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.SelectingFiles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SelectingFiles.BorderRadius = 0;
            this.SelectingFiles.ButtonText = "Выберите файлы";
            this.SelectingFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectingFiles.DisabledColor = System.Drawing.Color.Gray;
            this.SelectingFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.SelectingFiles.Iconcolor = System.Drawing.Color.Transparent;
            this.SelectingFiles.Iconimage = null;
            this.SelectingFiles.Iconimage_right = null;
            this.SelectingFiles.Iconimage_right_Selected = null;
            this.SelectingFiles.Iconimage_Selected = null;
            this.SelectingFiles.IconMarginLeft = 0;
            this.SelectingFiles.IconMarginRight = 0;
            this.SelectingFiles.IconRightVisible = true;
            this.SelectingFiles.IconRightZoom = 0D;
            this.SelectingFiles.IconVisible = true;
            this.SelectingFiles.IconZoom = 90D;
            this.SelectingFiles.IsTab = false;
            this.SelectingFiles.Location = new System.Drawing.Point(0, 0);
            this.SelectingFiles.Name = "SelectingFiles";
            this.SelectingFiles.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.SelectingFiles.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.SelectingFiles.OnHoverTextColor = System.Drawing.Color.White;
            this.SelectingFiles.selected = false;
            this.SelectingFiles.Size = new System.Drawing.Size(180, 50);
            this.SelectingFiles.TabIndex = 0;
            this.SelectingFiles.Text = "Выберите файлы";
            this.SelectingFiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SelectingFiles.Textcolor = System.Drawing.Color.White;
            this.SelectingFiles.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectingFiles.Click += new System.EventHandler(this.SelectingFiles_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.bodyContainer);
            this.Controls.Add(this.topBar);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Form1";
            this.topBar.ResumeLayout(false);
            this.bodyContainer.ResumeLayout(false);
            this.footer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resizser)).EndInit();
            this.leftBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel bodyContainer;
        private System.Windows.Forms.Panel leftBar;
        private Bunifu.Framework.UI.BunifuFlatButton expandApp;
        private Bunifu.Framework.UI.BunifuFlatButton hideApp;
        private Bunifu.Framework.UI.BunifuFlatButton closeApp;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel footer;
        private System.Windows.Forms.PictureBox resizser;
        private System.Windows.Forms.Panel controlsContainer;
        public Bunifu.Framework.UI.BunifuFlatButton WorkingStatus;
        public Bunifu.Framework.UI.BunifuFlatButton SafeFiles;
        public Bunifu.Framework.UI.BunifuFlatButton SettingRange;
        public Bunifu.Framework.UI.BunifuFlatButton SelectingFiles;
    }
}

