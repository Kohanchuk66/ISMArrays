namespace OOPDraw
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.NumberKill = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.Figure = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.col = new System.Windows.Forms.ColorDialog();
            this.Count = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberKill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Count)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(2, 12);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(0, 500);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(0, 500);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(0, 500);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(25, 551);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Прорисовать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(200, 551);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "Стереть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(799, 582);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Коханчук І. В.";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Location = new System.Drawing.Point(14, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(860, 422);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseUp);
            // 
            // NumberKill
            // 
            this.NumberKill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NumberKill.Location = new System.Drawing.Point(366, 545);
            this.NumberKill.Name = "NumberKill";
            this.NumberKill.Size = new System.Drawing.Size(61, 20);
            this.NumberKill.TabIndex = 5;
            this.NumberKill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumberKill.ValueChanged += new System.EventHandler(this.NumberKill_ValueChanged);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(362, 571);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 24);
            this.button3.TabIndex = 6;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Figure
            // 
            this.Figure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Figure.DisplayMember = "Rectangle";
            this.Figure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Figure.FormattingEnabled = true;
            this.Figure.Items.AddRange(new object[] {
            "Rectangle",
            "Ellips",
            "Circle",
            "Line",
            "Point"});
            this.Figure.Location = new System.Drawing.Point(452, 545);
            this.Figure.Name = "Figure";
            this.Figure.Size = new System.Drawing.Size(77, 21);
            this.Figure.TabIndex = 7;
            this.Figure.SelectedIndexChanged += new System.EventHandler(this.Figure_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.Location = new System.Drawing.Point(452, 571);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 24);
            this.button4.TabIndex = 8;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Count
            // 
            this.Count.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Count.Location = new System.Drawing.Point(25, 467);
            this.Count.Maximum = 20;
            this.Count.Minimum = 1;
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(512, 45);
            this.Count.TabIndex = 9;
            this.Count.Value = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(573, 577);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Номер карты";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(690, 577);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "пин";
            this.label3.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(555, 543);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(108, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox2.Location = new System.Drawing.Point(669, 543);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(67, 20);
            this.textBox2.TabIndex = 13;
            this.textBox2.Visible = false;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(750, 508);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(59, 30);
            this.button5.TabIndex = 14;
            this.button5.Text = "Влево";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(815, 508);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(59, 30);
            this.button6.TabIndex = 15;
            this.button6.Text = "Вправо";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Location = new System.Drawing.Point(782, 544);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(59, 30);
            this.button7.TabIndex = 16;
            this.button7.Text = "Вниз";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.Location = new System.Drawing.Point(782, 472);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(59, 30);
            this.button8.TabIndex = 17;
            this.button8.Text = "Вверх";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(366, 508);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(134, 17);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Показывать красиво";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(213, 508);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(119, 17);
            this.checkBox2.TabIndex = 19;
            this.checkBox2.Text = "Рисовать красиво";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 613);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Figure);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.NumberKill);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(657, 621);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberKill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Count)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ColorDialog col;
        public System.Windows.Forms.NumericUpDown NumberKill;
        public System.Windows.Forms.ComboBox Figure;
        private System.Windows.Forms.TrackBar Count;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

