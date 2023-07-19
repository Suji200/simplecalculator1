namespace simplecalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtdisplay = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btnmulti = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btndividion = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btnminus = new Button();
            btn0 = new Button();
            btnadd = new Button();
            btnclear = new Button();
            btnequal = new Button();
            btn6 = new Button();
            btn3 = new Button();
            btn9 = new Button();
            SuspendLayout();
            // 
            // txtdisplay
            // 
            txtdisplay.BorderStyle = BorderStyle.FixedSingle;
            txtdisplay.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            txtdisplay.Location = new Point(40, 33);
            txtdisplay.Multiline = true;
            txtdisplay.Name = "txtdisplay";
            txtdisplay.Size = new Size(430, 89);
            txtdisplay.TabIndex = 0;
            txtdisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.HighlightText;
            btn1.ForeColor = SystemColors.Desktop;
            btn1.Location = new Point(40, 163);
            btn1.Name = "btn1";
            btn1.Size = new Size(102, 52);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.ButtonHighlight;
            btn2.Location = new Point(160, 163);
            btn2.Name = "btn2";
            btn2.Size = new Size(98, 52);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btnmulti
            // 
            btnmulti.BackColor = SystemColors.ButtonHighlight;
            btnmulti.Location = new Point(388, 163);
            btnmulti.Name = "btnmulti";
            btnmulti.Size = new Size(96, 52);
            btnmulti.TabIndex = 4;
            btnmulti.Text = "*";
            btnmulti.UseVisualStyleBackColor = false;
            btnmulti.Click += btnmulti_Click;
            // 
            // btn4
            // 
            btn4.BackColor = SystemColors.ButtonHighlight;
            btn4.Location = new Point(40, 241);
            btn4.Name = "btn4";
            btn4.Size = new Size(102, 52);
            btn4.TabIndex = 1;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.BackColor = SystemColors.ButtonHighlight;
            btn5.Location = new Point(160, 241);
            btn5.Name = "btn5";
            btn5.Size = new Size(98, 52);
            btn5.TabIndex = 2;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btndividion
            // 
            btndividion.BackColor = SystemColors.ButtonHighlight;
            btndividion.Location = new Point(388, 241);
            btndividion.Name = "btndividion";
            btndividion.Size = new Size(96, 52);
            btndividion.TabIndex = 4;
            btndividion.Text = "/";
            btndividion.UseVisualStyleBackColor = false;
            btndividion.Click += btndividion_Click;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.ButtonHighlight;
            btn7.Location = new Point(40, 322);
            btn7.Name = "btn7";
            btn7.Size = new Size(102, 52);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.BackColor = SystemColors.ButtonHighlight;
            btn8.Location = new Point(160, 322);
            btn8.Name = "btn8";
            btn8.Size = new Size(98, 52);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btnminus
            // 
            btnminus.BackColor = SystemColors.ButtonHighlight;
            btnminus.Location = new Point(388, 322);
            btnminus.Name = "btnminus";
            btnminus.Size = new Size(96, 52);
            btnminus.TabIndex = 4;
            btnminus.Text = "-";
            btnminus.UseVisualStyleBackColor = false;
            btnminus.Click += btnminus_Click;
            // 
            // btn0
            // 
            btn0.BackColor = SystemColors.ButtonHighlight;
            btn0.Location = new Point(40, 413);
            btn0.Name = "btn0";
            btn0.Size = new Size(98, 52);
            btn0.TabIndex = 2;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btnadd
            // 
            btnadd.BackColor = SystemColors.ButtonHighlight;
            btnadd.Location = new Point(160, 413);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(96, 52);
            btnadd.TabIndex = 4;
            btnadd.Text = "+";
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += btnadd_Click;
            // 
            // btnclear
            // 
            btnclear.BackColor = SystemColors.ButtonHighlight;
            btnclear.Location = new Point(276, 413);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(208, 52);
            btnclear.TabIndex = 5;
            btnclear.Text = "C";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += btnclear_Click;
            // 
            // btnequal
            // 
            btnequal.BackColor = SystemColors.ButtonHighlight;
            btnequal.Location = new Point(60, 484);
            btnequal.Name = "btnequal";
            btnequal.Size = new Size(410, 56);
            btnequal.TabIndex = 7;
            btnequal.Text = "=";
            btnequal.UseVisualStyleBackColor = false;
            btnequal.Click += btnequal_Click;
            // 
            // btn6
            // 
            btn6.BackColor = SystemColors.ButtonHighlight;
            btn6.Location = new Point(276, 241);
            btn6.Name = "btn6";
            btn6.Size = new Size(94, 52);
            btn6.TabIndex = 8;
            btn6.Text = "6";
            btn6.UseCompatibleTextRendering = true;
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn3
            // 
            btn3.BackColor = SystemColors.ButtonHighlight;
            btn3.Location = new Point(276, 163);
            btn3.Name = "btn3";
            btn3.Size = new Size(94, 52);
            btn3.TabIndex = 9;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click_2;
            // 
            // btn9
            // 
            btn9.BackColor = SystemColors.ButtonHighlight;
            btn9.Location = new Point(276, 327);
            btn9.Name = "btn9";
            btn9.Size = new Size(94, 47);
            btn9.TabIndex = 10;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(521, 552);
            Controls.Add(txtdisplay);
            Controls.Add(btn9);
            Controls.Add(btn3);
            Controls.Add(btn6);
            Controls.Add(btnequal);
            Controls.Add(btnclear);
            Controls.Add(btnadd);
            Controls.Add(btnminus);
            Controls.Add(btndividion);
            Controls.Add(btnmulti);
            Controls.Add(btn0);
            Controls.Add(btn8);
            Controls.Add(btn5);
            Controls.Add(btn7);
            Controls.Add(btn4);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.InfoText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "Form1";
            Text = "calculator";
            TransparencyKey = Color.Gray;
            ResumeLayout(false);
            PerformLayout();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox txtdisplay;
        private Button btn1;
        private Button btn2;
        private Button btnmulti;
        private Button btn4;
        private Button btn5;
        private Button btndividion;
        private Button btn7;
        private Button btn8;
        private Button btnminus;
        private Button btn0;
        private Button btnadd;
        private Button btnclear;
        private Button btnequal;
        private Button btn6;
        private Button btn3;
        private Button btn9;
    }
}