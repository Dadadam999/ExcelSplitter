
namespace ExcelSplitter
{
    partial class SelectFiles
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listFiles = new System.Windows.Forms.ListBox();
            this.addFilesBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.deleteFilesBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.continueBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.topBar = new System.Windows.Forms.TableLayoutPanel();
            this.topBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "New excel files (*.xlsx)|*.xlsx|Old excel files (*.xls)|*.xls";
            this.openFileDialog1.Multiselect = true;
            // 
            // listFiles
            // 
            this.listFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listFiles.FormattingEnabled = true;
            this.listFiles.Location = new System.Drawing.Point(0, 30);
            this.listFiles.Name = "listFiles";
            this.listFiles.Size = new System.Drawing.Size(632, 357);
            this.listFiles.TabIndex = 2;
            // 
            // addFilesBtn
            // 
            this.addFilesBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.addFilesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.addFilesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addFilesBtn.BorderRadius = 0;
            this.addFilesBtn.ButtonText = "Добавить файл(ы)";
            this.addFilesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addFilesBtn.DisabledColor = System.Drawing.Color.Gray;
            this.addFilesBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addFilesBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.addFilesBtn.Iconimage = null;
            this.addFilesBtn.Iconimage_right = null;
            this.addFilesBtn.Iconimage_right_Selected = null;
            this.addFilesBtn.Iconimage_Selected = null;
            this.addFilesBtn.IconMarginLeft = 0;
            this.addFilesBtn.IconMarginRight = 0;
            this.addFilesBtn.IconRightVisible = true;
            this.addFilesBtn.IconRightZoom = 0D;
            this.addFilesBtn.IconVisible = true;
            this.addFilesBtn.IconZoom = 90D;
            this.addFilesBtn.IsTab = false;
            this.addFilesBtn.Location = new System.Drawing.Point(3, 3);
            this.addFilesBtn.Name = "addFilesBtn";
            this.addFilesBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.addFilesBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.addFilesBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.addFilesBtn.selected = false;
            this.addFilesBtn.Size = new System.Drawing.Size(204, 24);
            this.addFilesBtn.TabIndex = 4;
            this.addFilesBtn.Text = "Добавить файл(ы)";
            this.addFilesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addFilesBtn.Textcolor = System.Drawing.Color.White;
            this.addFilesBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFilesBtn.Click += new System.EventHandler(this.AddFilesBtn_Click);
            // 
            // deleteFilesBtn
            // 
            this.deleteFilesBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.deleteFilesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.deleteFilesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteFilesBtn.BorderRadius = 0;
            this.deleteFilesBtn.ButtonText = "Удалить файл";
            this.deleteFilesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteFilesBtn.DisabledColor = System.Drawing.Color.Gray;
            this.deleteFilesBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteFilesBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.deleteFilesBtn.Iconimage = null;
            this.deleteFilesBtn.Iconimage_right = null;
            this.deleteFilesBtn.Iconimage_right_Selected = null;
            this.deleteFilesBtn.Iconimage_Selected = null;
            this.deleteFilesBtn.IconMarginLeft = 0;
            this.deleteFilesBtn.IconMarginRight = 0;
            this.deleteFilesBtn.IconRightVisible = true;
            this.deleteFilesBtn.IconRightZoom = 0D;
            this.deleteFilesBtn.IconVisible = true;
            this.deleteFilesBtn.IconZoom = 90D;
            this.deleteFilesBtn.IsTab = false;
            this.deleteFilesBtn.Location = new System.Drawing.Point(213, 3);
            this.deleteFilesBtn.Name = "deleteFilesBtn";
            this.deleteFilesBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.deleteFilesBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.deleteFilesBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.deleteFilesBtn.selected = false;
            this.deleteFilesBtn.Size = new System.Drawing.Size(204, 24);
            this.deleteFilesBtn.TabIndex = 5;
            this.deleteFilesBtn.Text = "Удалить файл";
            this.deleteFilesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deleteFilesBtn.Textcolor = System.Drawing.Color.White;
            this.deleteFilesBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteFilesBtn.Click += new System.EventHandler(this.DeleteFilesBtn_Click);
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
            this.continueBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.continueBtn.Enabled = false;
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
            this.continueBtn.Location = new System.Drawing.Point(423, 3);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.continueBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.continueBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.continueBtn.selected = false;
            this.continueBtn.Size = new System.Drawing.Size(206, 24);
            this.continueBtn.TabIndex = 6;
            this.continueBtn.Text = "Далее";
            this.continueBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.continueBtn.Textcolor = System.Drawing.Color.White;
            this.continueBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueBtn.Click += new System.EventHandler(this.ContinueBtn_Click);
            // 
            // topBar
            // 
            this.topBar.ColumnCount = 3;
            this.topBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.topBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.topBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.topBar.Controls.Add(this.continueBtn, 2, 0);
            this.topBar.Controls.Add(this.addFilesBtn, 0, 0);
            this.topBar.Controls.Add(this.deleteFilesBtn, 1, 0);
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Margin = new System.Windows.Forms.Padding(0);
            this.topBar.Name = "topBar";
            this.topBar.RowCount = 1;
            this.topBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topBar.Size = new System.Drawing.Size(632, 30);
            this.topBar.TabIndex = 8;
            // 
            // SelectFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.listFiles);
            this.Controls.Add(this.topBar);
            this.Name = "SelectFiles";
            this.Size = new System.Drawing.Size(632, 387);
            this.topBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listFiles;
        private Bunifu.Framework.UI.BunifuFlatButton addFilesBtn;
        private Bunifu.Framework.UI.BunifuFlatButton deleteFilesBtn;
        private Bunifu.Framework.UI.BunifuFlatButton continueBtn;
        private System.Windows.Forms.TableLayoutPanel topBar;
    }
}
