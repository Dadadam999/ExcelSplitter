
namespace ExcelSplitter
{
    partial class WorkStatus
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
            this.resultLog = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.topBar = new System.Windows.Forms.TableLayoutPanel();
            this.openFolderBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.animationLoading = new System.Windows.Forms.PictureBox();
            this.topBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animationLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // resultLog
            // 
            this.resultLog.BackColor = System.Drawing.Color.White;
            this.resultLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultLog.Location = new System.Drawing.Point(0, 30);
            this.resultLog.Name = "resultLog";
            this.resultLog.ReadOnly = true;
            this.resultLog.Size = new System.Drawing.Size(683, 442);
            this.resultLog.TabIndex = 0;
            this.resultLog.Text = "";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // topBar
            // 
            this.topBar.ColumnCount = 4;
            this.topBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.topBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.topBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.topBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.topBar.Controls.Add(this.openFolderBtn, 3, 0);
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Margin = new System.Windows.Forms.Padding(0);
            this.topBar.Name = "topBar";
            this.topBar.RowCount = 1;
            this.topBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topBar.Size = new System.Drawing.Size(683, 30);
            this.topBar.TabIndex = 11;
            // 
            // openFolderBtn
            // 
            this.openFolderBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.openFolderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.openFolderBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openFolderBtn.BorderRadius = 0;
            this.openFolderBtn.ButtonText = "Открыть папку";
            this.openFolderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openFolderBtn.DisabledColor = System.Drawing.Color.Gray;
            this.openFolderBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openFolderBtn.Enabled = false;
            this.openFolderBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.openFolderBtn.Iconimage = null;
            this.openFolderBtn.Iconimage_right = null;
            this.openFolderBtn.Iconimage_right_Selected = null;
            this.openFolderBtn.Iconimage_Selected = null;
            this.openFolderBtn.IconMarginLeft = 0;
            this.openFolderBtn.IconMarginRight = 0;
            this.openFolderBtn.IconRightVisible = true;
            this.openFolderBtn.IconRightZoom = 0D;
            this.openFolderBtn.IconVisible = true;
            this.openFolderBtn.IconZoom = 90D;
            this.openFolderBtn.IsTab = false;
            this.openFolderBtn.Location = new System.Drawing.Point(513, 3);
            this.openFolderBtn.Name = "openFolderBtn";
            this.openFolderBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.openFolderBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.openFolderBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.openFolderBtn.selected = false;
            this.openFolderBtn.Size = new System.Drawing.Size(167, 24);
            this.openFolderBtn.TabIndex = 6;
            this.openFolderBtn.Text = "Открыть папку";
            this.openFolderBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.openFolderBtn.Textcolor = System.Drawing.Color.White;
            this.openFolderBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFolderBtn.Click += new System.EventHandler(this.OpenFolderBtn_Click);
            // 
            // animationLoading
            // 
            this.animationLoading.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.animationLoading.Image = global::ExcelSplitter.Properties.Resources.ajax_loading_gif_8;
            this.animationLoading.Location = new System.Drawing.Point(0, 472);
            this.animationLoading.Name = "animationLoading";
            this.animationLoading.Size = new System.Drawing.Size(683, 30);
            this.animationLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.animationLoading.TabIndex = 0;
            this.animationLoading.TabStop = false;
            // 
            // WorkStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.resultLog);
            this.Controls.Add(this.topBar);
            this.Controls.Add(this.animationLoading);
            this.Name = "WorkStatus";
            this.Size = new System.Drawing.Size(683, 502);
            this.VisibleChanged += new System.EventHandler(this.WorkStatus_VisibleChanged);
            this.topBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.animationLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox resultLog;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TableLayoutPanel topBar;
        private Bunifu.Framework.UI.BunifuFlatButton openFolderBtn;
        private System.Windows.Forms.PictureBox animationLoading;
    }
}
