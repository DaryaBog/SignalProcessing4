namespace SignalProcessing4
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оттенкиСерогоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.чБToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.негативToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.логПреобразованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.убратьШумToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шумToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нЧToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.h1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.h2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.h3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиКонтурыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.медианныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вЧToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.маскаH4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.маскаH5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.маскаH6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.маскаH7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.маскаH8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.маскаH9ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.uBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(4, 43);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1115, 509);
            this.splitContainer1.SplitterDistance = 554;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(554, 509);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(557, 509);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Images|*.bmp;*.png;*.jpg";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.оттенкиСерогоToolStripMenuItem,
            this.чБToolStripMenuItem,
            this.негативToolStripMenuItem,
            this.логПреобразованиеToolStripMenuItem,
            this.убратьШумToolStripMenuItem,
            this.найтиКонтурыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1123, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click_1);
            // 
            // оттенкиСерогоToolStripMenuItem
            // 
            this.оттенкиСерогоToolStripMenuItem.Name = "оттенкиСерогоToolStripMenuItem";
            this.оттенкиСерогоToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.оттенкиСерогоToolStripMenuItem.Text = "Полутоновое";
            this.оттенкиСерогоToolStripMenuItem.Click += new System.EventHandler(this.оттенкиСерогоToolStripMenuItem_Click);
            // 
            // чБToolStripMenuItem
            // 
            this.чБToolStripMenuItem.Name = "чБToolStripMenuItem";
            this.чБToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.чБToolStripMenuItem.Text = "Бинарное";
            this.чБToolStripMenuItem.Click += new System.EventHandler(this.чБToolStripMenuItem_Click);
            // 
            // негативToolStripMenuItem
            // 
            this.негативToolStripMenuItem.Name = "негативToolStripMenuItem";
            this.негативToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.негативToolStripMenuItem.Text = "Негатив";
            this.негативToolStripMenuItem.Click += new System.EventHandler(this.негативToolStripMenuItem_Click);
            // 
            // логПреобразованиеToolStripMenuItem
            // 
            this.логПреобразованиеToolStripMenuItem.Name = "логПреобразованиеToolStripMenuItem";
            this.логПреобразованиеToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.логПреобразованиеToolStripMenuItem.Text = "Лог. преобразование";
            this.логПреобразованиеToolStripMenuItem.Click += new System.EventHandler(this.логПреобразованиеToolStripMenuItem_Click);
            // 
            // убратьШумToolStripMenuItem
            // 
            this.убратьШумToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.шумToolStripMenuItem,
            this.нЧToolStripMenuItem,
            this.медианныйToolStripMenuItem,
            this.вЧToolStripMenuItem});
            this.убратьШумToolStripMenuItem.Name = "убратьШумToolStripMenuItem";
            this.убратьШумToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.убратьШумToolStripMenuItem.Text = "Фильтр";
            // 
            // шумToolStripMenuItem
            // 
            this.шумToolStripMenuItem.Name = "шумToolStripMenuItem";
            this.шумToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.шумToolStripMenuItem.Text = "Шум";
            this.шумToolStripMenuItem.Click += new System.EventHandler(this.шумToolStripMenuItem_Click);
            // 
            // нЧToolStripMenuItem
            // 
            this.нЧToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.h1ToolStripMenuItem,
            this.h2ToolStripMenuItem,
            this.h3ToolStripMenuItem});
            this.нЧToolStripMenuItem.Name = "нЧToolStripMenuItem";
            this.нЧToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.нЧToolStripMenuItem.Text = "НЧ";
            this.нЧToolStripMenuItem.Click += new System.EventHandler(this.нЧToolStripMenuItem_Click);
            // 
            // h1ToolStripMenuItem
            // 
            this.h1ToolStripMenuItem.Name = "h1ToolStripMenuItem";
            this.h1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.h1ToolStripMenuItem.Text = "Маска H1";
            this.h1ToolStripMenuItem.Click += new System.EventHandler(this.h1ToolStripMenuItem_Click);
            // 
            // h2ToolStripMenuItem
            // 
            this.h2ToolStripMenuItem.Name = "h2ToolStripMenuItem";
            this.h2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.h2ToolStripMenuItem.Text = "Маска H2";
            this.h2ToolStripMenuItem.Click += new System.EventHandler(this.h2ToolStripMenuItem_Click);
            // 
            // h3ToolStripMenuItem
            // 
            this.h3ToolStripMenuItem.Name = "h3ToolStripMenuItem";
            this.h3ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.h3ToolStripMenuItem.Text = "Маска H3";
            this.h3ToolStripMenuItem.Click += new System.EventHandler(this.h3ToolStripMenuItem_Click);
            // 
            // найтиКонтурыToolStripMenuItem
            // 
            this.найтиКонтурыToolStripMenuItem.Name = "найтиКонтурыToolStripMenuItem";
            this.найтиКонтурыToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.найтиКонтурыToolStripMenuItem.Text = "Найти контуры";
            this.найтиКонтурыToolStripMenuItem.Click += new System.EventHandler(this.найтиКонтурыToolStripMenuItem_Click);
            // 
            // медианныйToolStripMenuItem
            // 
            this.медианныйToolStripMenuItem.Name = "медианныйToolStripMenuItem";
            this.медианныйToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.медианныйToolStripMenuItem.Text = "Медианный";
            this.медианныйToolStripMenuItem.Click += new System.EventHandler(this.медианныйToolStripMenuItem_Click);
            // 
            // вЧToolStripMenuItem
            // 
            this.вЧToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.маскаH4ToolStripMenuItem,
            this.маскаH5ToolStripMenuItem,
            this.маскаH6ToolStripMenuItem,
            this.маскаH7ToolStripMenuItem,
            this.маскаH8ToolStripMenuItem,
            this.маскаH9ToolStripMenuItem});
            this.вЧToolStripMenuItem.Name = "вЧToolStripMenuItem";
            this.вЧToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.вЧToolStripMenuItem.Text = "ВЧ";
            // 
            // маскаH4ToolStripMenuItem
            // 
            this.маскаH4ToolStripMenuItem.Name = "маскаH4ToolStripMenuItem";
            this.маскаH4ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.маскаH4ToolStripMenuItem.Text = "Маска H4";
            this.маскаH4ToolStripMenuItem.Click += new System.EventHandler(this.маскаH4ToolStripMenuItem_Click);
            // 
            // маскаH5ToolStripMenuItem
            // 
            this.маскаH5ToolStripMenuItem.Name = "маскаH5ToolStripMenuItem";
            this.маскаH5ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.маскаH5ToolStripMenuItem.Text = "Маска H5";
            this.маскаH5ToolStripMenuItem.Click += new System.EventHandler(this.маскаH5ToolStripMenuItem_Click);
            // 
            // маскаH6ToolStripMenuItem
            // 
            this.маскаH6ToolStripMenuItem.Name = "маскаH6ToolStripMenuItem";
            this.маскаH6ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.маскаH6ToolStripMenuItem.Text = "Маска H6";
            this.маскаH6ToolStripMenuItem.Click += new System.EventHandler(this.маскаH6ToolStripMenuItem_Click);
            // 
            // маскаH7ToolStripMenuItem
            // 
            this.маскаH7ToolStripMenuItem.Name = "маскаH7ToolStripMenuItem";
            this.маскаH7ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.маскаH7ToolStripMenuItem.Text = "Маска H7";
            this.маскаH7ToolStripMenuItem.Click += new System.EventHandler(this.маскаH7ToolStripMenuItem_Click);
            // 
            // маскаH8ToolStripMenuItem
            // 
            this.маскаH8ToolStripMenuItem.Name = "маскаH8ToolStripMenuItem";
            this.маскаH8ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.маскаH8ToolStripMenuItem.Text = "Маска H8";
            this.маскаH8ToolStripMenuItem.Click += new System.EventHandler(this.маскаH8ToolStripMenuItem_Click);
            // 
            // маскаH9ToolStripMenuItem
            // 
            this.маскаH9ToolStripMenuItem.Name = "маскаH9ToolStripMenuItem";
            this.маскаH9ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.маскаH9ToolStripMenuItem.Text = "Маска H9";
            this.маскаH9ToolStripMenuItem.Click += new System.EventHandler(this.маскаH9ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(847, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "U = ";
            // 
            // uBox
            // 
            this.uBox.Location = new System.Drawing.Point(900, 2);
            this.uBox.Name = "uBox";
            this.uBox.Size = new System.Drawing.Size(39, 22);
            this.uBox.TabIndex = 4;
            this.uBox.Text = "2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 558);
            this.Controls.Add(this.uBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оттенкиСерогоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem убратьШумToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найтиКонтурыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem чБToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem негативToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem логПреобразованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem нЧToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шумToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem h1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem h2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem h3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem медианныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вЧToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem маскаH4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem маскаH5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem маскаH6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem маскаH7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem маскаH8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem маскаH9ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uBox;
    }
}

