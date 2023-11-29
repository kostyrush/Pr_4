namespace UP4_3
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pct = new System.Windows.Forms.PictureBox();
            this.btcStart = new System.Windows.Forms.Button();
            this.btcExit = new System.Windows.Forms.Button();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pct)).BeginInit();
            this.SuspendLayout();
            // 
            // pct
            // 
            this.pct.Image = ((System.Drawing.Image)(resources.GetObject("pct.Image")));
            this.pct.ImageLocation = "";
            this.pct.Location = new System.Drawing.Point(12, 12);
            this.pct.Name = "pct";
            this.pct.Size = new System.Drawing.Size(228, 204);
            this.pct.TabIndex = 0;
            this.pct.TabStop = false;
            // 
            // btcStart
            // 
            this.btcStart.Location = new System.Drawing.Point(170, 307);
            this.btcStart.Name = "btcStart";
            this.btcStart.Size = new System.Drawing.Size(70, 32);
            this.btcStart.TabIndex = 1;
            this.btcStart.Text = "Старт";
            this.btcStart.UseVisualStyleBackColor = true;
            this.btcStart.Click += new System.EventHandler(this.btcStart_Click);
            // 
            // btcExit
            // 
            this.btcExit.Location = new System.Drawing.Point(294, 307);
            this.btcExit.Name = "btcExit";
            this.btcExit.Size = new System.Drawing.Size(70, 32);
            this.btcExit.TabIndex = 2;
            this.btcExit.Text = "Выход";
            this.btcExit.UseVisualStyleBackColor = true;
            this.btcExit.Click += new System.EventHandler(this.btcExit_Click);
            // 
            // tmr
            // 
            this.tmr.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 371);
            this.Controls.Add(this.btcExit);
            this.Controls.Add(this.btcStart);
            this.Controls.Add(this.pct);
            this.Name = "Form1";
            this.Text = "Анимация";
            ((System.ComponentModel.ISupportInitialize)(this.pct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pct;
        private System.Windows.Forms.Button btcStart;
        private System.Windows.Forms.Button btcExit;
        private System.Windows.Forms.Timer tmr;
    }
}

