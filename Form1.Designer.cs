﻿namespace demo_calculadora
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
            components = new System.ComponentModel.Container();
            txtAmount = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button1 = new Button();
            button4 = new Button();
            button5 = new Button();
            comboBox1 = new ComboBox();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            label1 = new Label();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            toolTip1 = new ToolTip(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            txtAmount.Location = new Point(27, 60);
            txtAmount.Margin = new Padding(4);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(280, 36);
            txtAmount.TabIndex = 0;
            txtAmount.TextChanged += txtAmount_TextChanged;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(105, 4);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(93, 78);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(206, 4);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(93, 78);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(4, 4);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(93, 78);
            button1.TabIndex = 4;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(4, 90);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(93, 78);
            button4.TabIndex = 5;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += teclat_Click;
            // 
            // button5
            // 
            button5.Location = new Point(380, 204);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(96, 32);
            button5.TabIndex = 6;
            button5.Text = "Convertir";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(354, 167);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(146, 29);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.TextChanged += comboBox1_TextChanged;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(105, 90);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(93, 78);
            button6.TabIndex = 8;
            button6.Text = "5";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(206, 90);
            button7.Margin = new Padding(4);
            button7.Name = "button7";
            button7.Size = new Size(93, 78);
            button7.TabIndex = 9;
            button7.Text = "6";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(4, 176);
            button8.Margin = new Padding(4);
            button8.Name = "button8";
            button8.Size = new Size(93, 78);
            button8.TabIndex = 10;
            button8.Text = "7";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(105, 176);
            button9.Margin = new Padding(4);
            button9.Name = "button9";
            button9.Size = new Size(93, 78);
            button9.TabIndex = 11;
            button9.Text = "8";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button10.Location = new Point(206, 176);
            button10.Margin = new Padding(4);
            button10.Name = "button10";
            button10.Size = new Size(93, 78);
            button10.TabIndex = 12;
            button10.Text = "9";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button11.Location = new Point(4, 262);
            button11.Margin = new Padding(4);
            button11.Name = "button11";
            button11.Size = new Size(194, 78);
            button11.TabIndex = 13;
            button11.Text = "0";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button12.Location = new Point(206, 262);
            button12.Margin = new Padding(4);
            button12.Name = "button12";
            button12.Size = new Size(93, 78);
            button12.TabIndex = 14;
            button12.Text = "borrar";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 35);
            label1.Name = "label1";
            label1.Size = new Size(82, 21);
            label1.TabIndex = 15;
            label1.Text = "Conversor";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(354, 130);
            comboBox2.Margin = new Padding(4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(146, 29);
            comboBox2.TabIndex = 16;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(355, 60);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(144, 36);
            textBox1.TabIndex = 18;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // toolTip1
            // 
            toolTip1.Popup += toolTip1_Popup;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(button6);
            flowLayoutPanel1.Controls.Add(button7);
            flowLayoutPanel1.Controls.Add(button8);
            flowLayoutPanel1.Controls.Add(button9);
            flowLayoutPanel1.Controls.Add(button10);
            flowLayoutPanel1.Controls.Add(button11);
            flowLayoutPanel1.Controls.Add(button12);
            flowLayoutPanel1.Location = new Point(27, 130);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(304, 345);
            flowLayoutPanel1.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 533);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(button5);
            Controls.Add(txtAmount);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAmount;
        private Button button2;
        private Button button3;
        private Button button1;
        private Button button4;
        private Button button5;
        private ComboBox comboBox1;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Label label1;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private ToolTip toolTip1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}