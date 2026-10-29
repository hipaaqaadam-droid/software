namespace software
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
            lbl = new Label();
            label1 = new Label();
            txtnumberofbackage = new TextBox();
            txtpriceperpackage = new TextBox();
            calculate = new Button();
            button2 = new Button();
            button3 = new Button();
            listBox1 = new ListBox();
            quantity = new Label();
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            lbl4 = new Label();
            label7 = new Label();
            lbl5 = new Label();
            lbl6 = new Label();
            lbl7 = new Label();
            label11 = new Label();
            SuspendLayout();
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl.Location = new Point(107, 69);
            lbl.Name = "lbl";
            lbl.Size = new Size(177, 25);
            lbl.TabIndex = 0;
            lbl.Text = "number of package";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(119, 125);
            label1.Name = "label1";
            label1.Size = new Size(163, 25);
            label1.TabIndex = 1;
            label1.Text = "price per package";
            // 
            // txtnumberofbackage
            // 
            txtnumberofbackage.Location = new Point(302, 75);
            txtnumberofbackage.Name = "txtnumberofbackage";
            txtnumberofbackage.Size = new Size(184, 31);
            txtnumberofbackage.TabIndex = 2;
            // 
            // txtpriceperpackage
            // 
            txtpriceperpackage.Location = new Point(302, 122);
            txtpriceperpackage.Name = "txtpriceperpackage";
            txtpriceperpackage.Size = new Size(184, 31);
            txtpriceperpackage.TabIndex = 3;
            // 
            // calculate
            // 
            calculate.Location = new Point(40, 241);
            calculate.Name = "calculate";
            calculate.Size = new Size(158, 75);
            calculate.TabIndex = 4;
            calculate.Text = "calculate";
            calculate.UseVisualStyleBackColor = true;
            calculate.Click += calculate_Click;
            // 
            // button2
            // 
            button2.Location = new Point(228, 241);
            button2.Name = "button2";
            button2.Size = new Size(158, 75);
            button2.TabIndex = 5;
            button2.Text = "clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(433, 241);
            button3.Name = "button3";
            button3.Size = new Size(158, 75);
            button3.TabIndex = 6;
            button3.Text = "exit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(661, 26);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(411, 429);
            listBox1.TabIndex = 7;
            // 
            // quantity
            // 
            quantity.AutoSize = true;
            quantity.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            quantity.Location = new Point(48, 390);
            quantity.Name = "quantity";
            quantity.Size = new Size(84, 25);
            quantity.TabIndex = 8;
            quantity.Text = "quantity";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl1.Location = new Point(66, 430);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(59, 25);
            lbl1.TabIndex = 9;
            lbl1.Text = "10-19";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl2.Location = new Point(66, 477);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(59, 25);
            lbl2.TabIndex = 10;
            lbl2.Text = "20-40";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl3.Location = new Point(66, 520);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(59, 25);
            lbl3.TabIndex = 11;
            lbl3.Text = "50-99";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl4.Location = new Point(56, 560);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(113, 25);
            lbl4.TabIndex = 12;
            lbl4.Text = "100 0r more";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(280, 380);
            label7.Name = "label7";
            label7.Size = new Size(85, 25);
            label7.TabIndex = 13;
            label7.Text = "discount";
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl5.Location = new Point(280, 430);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(48, 25);
            lbl5.TabIndex = 14;
            lbl5.Text = "20%";
            // 
            // lbl6
            // 
            lbl6.AutoSize = true;
            lbl6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl6.Location = new Point(280, 477);
            lbl6.Name = "lbl6";
            lbl6.Size = new Size(48, 25);
            lbl6.TabIndex = 15;
            lbl6.Text = "30%";
            // 
            // lbl7
            // 
            lbl7.AutoSize = true;
            lbl7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl7.Location = new Point(280, 520);
            lbl7.Name = "lbl7";
            lbl7.Size = new Size(48, 25);
            lbl7.TabIndex = 16;
            lbl7.Text = "40%";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label11.Location = new Point(280, 560);
            label11.Name = "label11";
            label11.Size = new Size(48, 25);
            label11.TabIndex = 17;
            label11.Text = "50%";
            label11.Click += label11_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1102, 633);
            Controls.Add(label11);
            Controls.Add(lbl7);
            Controls.Add(lbl6);
            Controls.Add(lbl5);
            Controls.Add(label7);
            Controls.Add(lbl4);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(quantity);
            Controls.Add(listBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(calculate);
            Controls.Add(txtpriceperpackage);
            Controls.Add(txtnumberofbackage);
            Controls.Add(label1);
            Controls.Add(lbl);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl;
        private Label label1;
        private TextBox txtnumberofbackage;
        private TextBox txtpriceperpackage;
        private Button calculate;
        private Button button2;
        private Button button3;
        private ListBox listBox1;
        private Label quantity;
        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private Label lbl4;
        private Label label7;
        private Label lbl5;
        private Label lbl6;
        private Label lbl7;
        private Label label11;
    }
}
