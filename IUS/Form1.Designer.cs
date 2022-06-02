namespace IUS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.radio150 = new System.Windows.Forms.RadioButton();
            this.radio500 = new System.Windows.Forms.RadioButton();
            this.textBoxCurr = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonCurr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonCoef = new System.Windows.Forms.Button();
            this.Coef = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonRS = new System.Windows.Forms.Button();
            this.labelRS = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.high = new System.Windows.Forms.TextBox();
            this.buttonr = new System.Windows.Forms.Button();
            this.labelr = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelcom = new System.Windows.Forms.Label();
            this.Curr = new System.Windows.Forms.TextBox();
            this.Volta = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.History = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio1);
            this.groupBox1.Controls.Add(this.radio150);
            this.groupBox1.Controls.Add(this.radio500);
            this.groupBox1.Location = new System.Drawing.Point(460, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 56);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Диапазон измерения напряжения";
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Location = new System.Drawing.Point(184, 26);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(41, 17);
            this.radio1.TabIndex = 17;
            this.radio1.TabStop = true;
            this.radio1.Text = "1 В";
            this.radio1.UseVisualStyleBackColor = true;
            this.radio1.Click += new System.EventHandler(this.Radio1_Click);
            // 
            // radio150
            // 
            this.radio150.AutoSize = true;
            this.radio150.Location = new System.Drawing.Point(16, 26);
            this.radio150.Name = "radio150";
            this.radio150.Size = new System.Drawing.Size(61, 17);
            this.radio150.TabIndex = 15;
            this.radio150.TabStop = true;
            this.radio150.Text = "150 мВ";
            this.radio150.UseVisualStyleBackColor = true;
            this.radio150.Click += new System.EventHandler(this.Radio150_Click);
            // 
            // radio500
            // 
            this.radio500.AutoSize = true;
            this.radio500.Location = new System.Drawing.Point(97, 26);
            this.radio500.Name = "radio500";
            this.radio500.Size = new System.Drawing.Size(61, 17);
            this.radio500.TabIndex = 16;
            this.radio500.TabStop = true;
            this.radio500.Text = "500 мВ";
            this.radio500.UseVisualStyleBackColor = true;
            this.radio500.Click += new System.EventHandler(this.Radio500_Click);
            // 
            // textBoxCurr
            // 
            this.textBoxCurr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCurr.Location = new System.Drawing.Point(6, 19);
            this.textBoxCurr.MaxLength = 6;
            this.textBoxCurr.Multiline = true;
            this.textBoxCurr.Name = "textBoxCurr";
            this.textBoxCurr.ShortcutsEnabled = false;
            this.textBoxCurr.Size = new System.Drawing.Size(100, 31);
            this.textBoxCurr.TabIndex = 4;
            this.textBoxCurr.TabStop = false;
            this.textBoxCurr.WordWrap = false;
            this.textBoxCurr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxCurr_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(442, 386);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonCurr);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxCurr);
            this.groupBox2.Location = new System.Drawing.Point(460, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 56);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Уставка тока";
            // 
            // buttonCurr
            // 
            this.buttonCurr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCurr.Location = new System.Drawing.Point(133, 19);
            this.buttonCurr.Name = "buttonCurr";
            this.buttonCurr.Size = new System.Drawing.Size(97, 31);
            this.buttonCurr.TabIndex = 6;
            this.buttonCurr.TabStop = false;
            this.buttonCurr.Text = "Задать";
            this.buttonCurr.UseVisualStyleBackColor = true;
            this.buttonCurr.Click += new System.EventHandler(this.ButtonCurr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(109, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "мА";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonCoef);
            this.groupBox3.Controls.Add(this.Coef);
            this.groupBox3.Location = new System.Drawing.Point(460, 69);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(236, 56);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Коэффициент";
            // 
            // buttonCoef
            // 
            this.buttonCoef.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCoef.Location = new System.Drawing.Point(133, 19);
            this.buttonCoef.Name = "buttonCoef";
            this.buttonCoef.Size = new System.Drawing.Size(97, 31);
            this.buttonCoef.TabIndex = 6;
            this.buttonCoef.TabStop = false;
            this.buttonCoef.Text = "Изменить";
            this.buttonCoef.UseVisualStyleBackColor = true;
            this.buttonCoef.Click += new System.EventHandler(this.ButtonCoef_Click);
            // 
            // Coef
            // 
            this.Coef.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Coef.Location = new System.Drawing.Point(6, 19);
            this.Coef.MaxLength = 6;
            this.Coef.Multiline = true;
            this.Coef.Name = "Coef";
            this.Coef.ShortcutsEnabled = false;
            this.Coef.Size = new System.Drawing.Size(121, 31);
            this.Coef.TabIndex = 4;
            this.Coef.TabStop = false;
            this.Coef.WordWrap = false;
            this.Coef.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxCoef_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelRS);
            this.groupBox4.Controls.Add(this.buttonRS);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(460, 193);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(236, 58);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Поверхностное сопротивление";
            // 
            // buttonRS
            // 
            this.buttonRS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRS.Location = new System.Drawing.Point(133, 19);
            this.buttonRS.Name = "buttonRS";
            this.buttonRS.Size = new System.Drawing.Size(97, 31);
            this.buttonRS.TabIndex = 11;
            this.buttonRS.TabStop = false;
            this.buttonRS.Text = "Рассчитать";
            this.buttonRS.UseVisualStyleBackColor = true;
            this.buttonRS.Click += new System.EventHandler(this.ButtonRS_Click);
            // 
            // labelRS
            // 
            this.labelRS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRS.Location = new System.Drawing.Point(6, 20);
            this.labelRS.Name = "labelRS";
            this.labelRS.Size = new System.Drawing.Size(57, 31);
            this.labelRS.TabIndex = 6;
            this.labelRS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(65, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 31);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ом";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.buttonr);
            this.groupBox5.Controls.Add(this.labelr);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Location = new System.Drawing.Point(460, 257);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(236, 141);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Удельное сопротивление";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.high);
            this.groupBox6.Location = new System.Drawing.Point(10, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(215, 60);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Толщина";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(154, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "мкм";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // high
            // 
            this.high.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.high.Location = new System.Drawing.Point(6, 19);
            this.high.MaxLength = 4;
            this.high.Multiline = true;
            this.high.Name = "high";
            this.high.ShortcutsEnabled = false;
            this.high.Size = new System.Drawing.Size(142, 31);
            this.high.TabIndex = 12;
            this.high.TabStop = false;
            this.high.WordWrap = false;
            this.high.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxhigh_KeyPress);
            // 
            // buttonr
            // 
            this.buttonr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonr.Location = new System.Drawing.Point(133, 98);
            this.buttonr.Name = "buttonr";
            this.buttonr.Size = new System.Drawing.Size(97, 31);
            this.buttonr.TabIndex = 11;
            this.buttonr.TabStop = false;
            this.buttonr.Text = "Рассчитать";
            this.buttonr.UseVisualStyleBackColor = true;
            this.buttonr.Click += new System.EventHandler(this.Buttonr_Click);
            // 
            // labelr
            // 
            this.labelr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelr.Location = new System.Drawing.Point(6, 98);
            this.labelr.Name = "labelr";
            this.labelr.Size = new System.Drawing.Size(79, 31);
            this.labelr.TabIndex = 6;
            this.labelr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(80, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 31);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ом.см";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelcom
            // 
            this.labelcom.AutoSize = true;
            this.labelcom.Location = new System.Drawing.Point(9, 7);
            this.labelcom.Name = "labelcom";
            this.labelcom.Size = new System.Drawing.Size(50, 13);
            this.labelcom.TabIndex = 12;
            this.labelcom.Text = "labelCom";
            // 
            // Curr
            // 
            this.Curr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Curr.Location = new System.Drawing.Point(190, 70);
            this.Curr.MaxLength = 10;
            this.Curr.Multiline = true;
            this.Curr.Name = "Curr";
            this.Curr.ReadOnly = true;
            this.Curr.Size = new System.Drawing.Size(78, 27);
            this.Curr.TabIndex = 13;
            this.Curr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Volta
            // 
            this.Volta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Volta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Volta.Location = new System.Drawing.Point(189, 171);
            this.Volta.Multiline = true;
            this.Volta.Name = "Volta";
            this.Volta.ReadOnly = true;
            this.Volta.Size = new System.Drawing.Size(78, 27);
            this.Volta.TabIndex = 14;
            this.Volta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.History);
            this.groupBox7.Location = new System.Drawing.Point(703, 7);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(328, 390);
            this.groupBox7.TabIndex = 15;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "История измерений";
            // 
            // History
            // 
            this.History.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.History.Location = new System.Drawing.Point(6, 16);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(316, 368);
            this.History.TabIndex = 0;
            this.History.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1043, 408);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.Volta);
            this.Controls.Add(this.Curr);
            this.Controls.Add(this.labelcom);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ИУС версия 1.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxCurr;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCurr;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonCoef;
        private System.Windows.Forms.TextBox Coef;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labelRS;
        private System.Windows.Forms.Button buttonRS;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonr;
        private System.Windows.Forms.Label labelr;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox high;
        private System.Windows.Forms.Label labelcom;
        private System.Windows.Forms.TextBox Curr;
        private System.Windows.Forms.TextBox Volta;
        private System.Windows.Forms.RadioButton radio150;
        private System.Windows.Forms.RadioButton radio500;
        private System.Windows.Forms.RadioButton radio1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RichTextBox History;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

