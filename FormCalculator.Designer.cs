
using System.Windows.Forms;

namespace CalculatorCS
{
    partial class FormCalculator
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            button21 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.08547F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 79.91453F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(327, 422);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(button2, 1, 4);
            tableLayoutPanel2.Controls.Add(button1, 0, 4);
            tableLayoutPanel2.Controls.Add(button3, 2, 4);
            tableLayoutPanel2.Controls.Add(button4, 0, 3);
            tableLayoutPanel2.Controls.Add(button5, 1, 3);
            tableLayoutPanel2.Controls.Add(button6, 2, 3);
            tableLayoutPanel2.Controls.Add(button7, 0, 2);
            tableLayoutPanel2.Controls.Add(button8, 1, 2);
            tableLayoutPanel2.Controls.Add(button9, 2, 2);
            tableLayoutPanel2.Controls.Add(button10, 1, 5);
            tableLayoutPanel2.Controls.Add(button11, 2, 5);
            tableLayoutPanel2.Controls.Add(button12, 0, 5);
            tableLayoutPanel2.Controls.Add(button13, 3, 4);
            tableLayoutPanel2.Controls.Add(button14, 3, 3);
            tableLayoutPanel2.Controls.Add(button15, 3, 2);
            tableLayoutPanel2.Controls.Add(button16, 3, 1);
            tableLayoutPanel2.Controls.Add(button17, 1, 1);
            tableLayoutPanel2.Controls.Add(button18, 2, 1);
            tableLayoutPanel2.Controls.Add(button19, 0, 1);
            tableLayoutPanel2.Controls.Add(button20, 3, 0);
            tableLayoutPanel2.Controls.Add(button21, 3, 5);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 87);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.Size = new Size(321, 332);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.Dock = DockStyle.Fill;
            button2.Font = new Font("Microsoft YaHei UI", 15.75F);
            button2.Location = new Point(83, 223);
            button2.Name = "button2";
            button2.Size = new Size(74, 49);
            button2.TabIndex = 1;
            button2.TabStop = false;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Microsoft YaHei UI", 15.75F);
            button1.Location = new Point(3, 223);
            button1.Name = "button1";
            button1.Size = new Size(74, 49);
            button1.TabIndex = 0;
            button1.TabStop = false;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonFace;
            button3.Dock = DockStyle.Fill;
            button3.Font = new Font("Microsoft YaHei UI", 15.75F);
            button3.Location = new Point(163, 223);
            button3.Name = "button3";
            button3.Size = new Size(74, 49);
            button3.TabIndex = 2;
            button3.TabStop = false;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonFace;
            button4.Dock = DockStyle.Fill;
            button4.Font = new Font("Microsoft YaHei UI", 15.75F);
            button4.Location = new Point(3, 168);
            button4.Name = "button4";
            button4.Size = new Size(74, 49);
            button4.TabIndex = 3;
            button4.TabStop = false;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonFace;
            button5.Dock = DockStyle.Fill;
            button5.Font = new Font("Microsoft YaHei UI", 15.75F);
            button5.Location = new Point(83, 168);
            button5.Name = "button5";
            button5.Size = new Size(74, 49);
            button5.TabIndex = 4;
            button5.TabStop = false;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ButtonFace;
            button6.Dock = DockStyle.Fill;
            button6.Font = new Font("Microsoft YaHei UI", 15.75F);
            button6.Location = new Point(163, 168);
            button6.Name = "button6";
            button6.Size = new Size(74, 49);
            button6.TabIndex = 5;
            button6.TabStop = false;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ButtonFace;
            button7.Dock = DockStyle.Fill;
            button7.Font = new Font("Microsoft YaHei UI", 15.75F);
            button7.Location = new Point(3, 113);
            button7.Name = "button7";
            button7.Size = new Size(74, 49);
            button7.TabIndex = 6;
            button7.TabStop = false;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ButtonFace;
            button8.Dock = DockStyle.Fill;
            button8.Font = new Font("Microsoft YaHei UI", 15.75F);
            button8.Location = new Point(83, 113);
            button8.Name = "button8";
            button8.Size = new Size(74, 49);
            button8.TabIndex = 7;
            button8.TabStop = false;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ButtonFace;
            button9.Dock = DockStyle.Fill;
            button9.Font = new Font("Microsoft YaHei UI", 15.75F);
            button9.Location = new Point(163, 113);
            button9.Name = "button9";
            button9.Size = new Size(74, 49);
            button9.TabIndex = 8;
            button9.TabStop = false;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.ButtonFace;
            button10.Dock = DockStyle.Fill;
            button10.Font = new Font("Microsoft YaHei UI", 15.75F);
            button10.Location = new Point(83, 278);
            button10.Name = "button10";
            button10.Size = new Size(74, 51);
            button10.TabIndex = 9;
            button10.TabStop = false;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.BackColor = SystemColors.ButtonFace;
            button11.Dock = DockStyle.Fill;
            button11.Font = new Font("Microsoft YaHei UI", 15.75F);
            button11.Location = new Point(163, 278);
            button11.Name = "button11";
            button11.Size = new Size(74, 51);
            button11.TabIndex = 10;
            button11.TabStop = false;
            button11.Text = ".";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.BackColor = SystemColors.ButtonFace;
            button12.Dock = DockStyle.Fill;
            button12.Font = new Font("Microsoft YaHei UI", 15.75F);
            button12.Location = new Point(3, 278);
            button12.Name = "button12";
            button12.Size = new Size(74, 51);
            button12.TabIndex = 11;
            button12.TabStop = false;
            button12.Text = "±";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.Dock = DockStyle.Fill;
            button13.Font = new Font("Microsoft YaHei UI", 15.75F);
            button13.Location = new Point(243, 223);
            button13.Name = "button13";
            button13.Size = new Size(75, 49);
            button13.TabIndex = 12;
            button13.TabStop = false;
            button13.Text = "+";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.Dock = DockStyle.Fill;
            button14.Font = new Font("Microsoft YaHei UI", 15.75F);
            button14.Location = new Point(243, 168);
            button14.Name = "button14";
            button14.Size = new Size(75, 49);
            button14.TabIndex = 13;
            button14.TabStop = false;
            button14.Text = "－";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.Dock = DockStyle.Fill;
            button15.Font = new Font("Microsoft YaHei UI", 15.75F);
            button15.Location = new Point(243, 113);
            button15.Name = "button15";
            button15.Size = new Size(75, 49);
            button15.TabIndex = 14;
            button15.TabStop = false;
            button15.Text = "×";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // button16
            // 
            button16.Dock = DockStyle.Fill;
            button16.Font = new Font("Microsoft YaHei UI", 15.75F);
            button16.Location = new Point(243, 58);
            button16.Name = "button16";
            button16.Size = new Size(75, 49);
            button16.TabIndex = 15;
            button16.TabStop = false;
            button16.Text = "÷";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // button17
            // 
            button17.Dock = DockStyle.Fill;
            button17.Font = new Font("Microsoft YaHei UI", 15.75F);
            button17.Location = new Point(83, 58);
            button17.Name = "button17";
            button17.Size = new Size(74, 49);
            button17.TabIndex = 16;
            button17.TabStop = false;
            button17.Text = "(";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            // 
            // button18
            // 
            button18.Dock = DockStyle.Fill;
            button18.Font = new Font("Microsoft YaHei UI", 15.75F);
            button18.Location = new Point(163, 58);
            button18.Name = "button18";
            button18.Size = new Size(74, 49);
            button18.TabIndex = 17;
            button18.TabStop = false;
            button18.Text = ")";
            button18.UseVisualStyleBackColor = true;
            button18.Click += button18_Click;
            // 
            // button19
            // 
            button19.Dock = DockStyle.Fill;
            button19.Font = new Font("Microsoft YaHei UI", 15.75F);
            button19.Location = new Point(3, 58);
            button19.Name = "button19";
            button19.Size = new Size(74, 49);
            button19.TabIndex = 18;
            button19.TabStop = false;
            button19.Text = "C";
            button19.UseVisualStyleBackColor = true;
            button19.Click += button19_Click;
            // 
            // button20
            // 
            button20.Dock = DockStyle.Fill;
            button20.Font = new Font("Microsoft YaHei UI", 15.75F);
            button20.Location = new Point(243, 3);
            button20.Name = "button20";
            button20.Size = new Size(75, 49);
            button20.TabIndex = 19;
            button20.TabStop = false;
            button20.Text = "⌫";
            button20.UseVisualStyleBackColor = true;
            button20.Click += button20_Click;
            // 
            // button21
            // 
            button21.Dock = DockStyle.Fill;
            button21.Font = new Font("Microsoft YaHei UI", 15.75F);
            button21.Location = new Point(243, 278);
            button21.Name = "button21";
            button21.Size = new Size(75, 51);
            button21.TabIndex = 20;
            button21.TabStop = false;
            button21.Text = "=";
            button21.UseVisualStyleBackColor = true;
            button21.Click += button21_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            tableLayoutPanel2.SetColumnSpan(label1, 3);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(234, 55);
            label1.TabIndex = 21;
            label1.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 134);
            textBox1.Location = new Point(3, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(321, 78);
            textBox1.TabIndex = 2;
            // 
            // FormCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 422);
            Controls.Add(tableLayoutPanel1);
            Name = "FormCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "计算器";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button21;
        private TextBox textBox1;
        private Label label1;
    }
}
