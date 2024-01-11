namespace WinFormsApp6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            button1 = new Button();
            label4 = new Label();
            information = new Button();
            displayTextBox = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            button4 = new Button();
            checkBox1 = new CheckBox();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            button3 = new Button();
            button5 = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Dubai", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(205, 71);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(213, 64);
            label1.TabIndex = 0;
            label1.Text = " 3alamtak";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // radioButton1
            // 
            radioButton1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radioButton1.BackgroundImage = WinFormsApp2.Properties.Resources.Untitl7e4d;
            radioButton1.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton1.CheckAlign = ContentAlignment.MiddleCenter;
            radioButton1.Cursor = Cursors.Hand;
            radioButton1.ForeColor = SystemColors.ButtonHighlight;
            radioButton1.ImageAlign = ContentAlignment.MiddleRight;
            radioButton1.Location = new Point(324, 248);
            radioButton1.Margin = new Padding(3, 4, 3, 4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(157, 32);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "               A";
            radioButton1.TextAlign = ContentAlignment.MiddleCenter;
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.BackColor = Color.Transparent;
            radioButton2.BackgroundImage = WinFormsApp2.Properties.Resources.Untitl7e4d;
            radioButton2.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton2.CheckAlign = ContentAlignment.MiddleCenter;
            radioButton2.Cursor = Cursors.Hand;
            radioButton2.ForeColor = SystemColors.ButtonHighlight;
            radioButton2.Location = new Point(652, 248);
            radioButton2.Margin = new Padding(3, 4, 3, 4);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(157, 32);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "D             نجاح";
            radioButton2.TextAlign = ContentAlignment.MiddleCenter;
            radioButton2.UseVisualStyleBackColor = false;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // button1
            // 
            button1.BackgroundImage = WinFormsApp2.Properties.Resources.Untitl7e4d;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(441, 351);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(236, 44);
            button1.TabIndex = 6;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ImageAlign = ContentAlignment.TopCenter;
            label4.Location = new Point(248, 691);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(631, 37);
            label4.TabIndex = 8;
            label4.Text = "هذا البرنامج يظهر علامات تقريبية وليست دقيقة";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.UseMnemonic = false;
            // 
            // information
            // 
            information.BackgroundImage = WinFormsApp2.Properties.Resources.information;
            information.BackgroundImageLayout = ImageLayout.Zoom;
            information.Cursor = Cursors.Hand;
            information.FlatStyle = FlatStyle.Flat;
            information.Location = new Point(116, 331);
            information.Margin = new Padding(3, 4, 3, 4);
            information.Name = "information";
            information.RightToLeft = RightToLeft.Yes;
            information.Size = new Size(40, 38);
            information.TabIndex = 9;
            information.TextAlign = ContentAlignment.BottomRight;
            information.UseVisualStyleBackColor = true;
            information.Click += information_Click;
            // 
            // displayTextBox
            // 
            displayTextBox.BackColor = Color.WhiteSmoke;
            displayTextBox.Cursor = Cursors.IBeam;
            displayTextBox.Location = new Point(205, 439);
            displayTextBox.Margin = new Padding(0);
            displayTextBox.Multiline = true;
            displayTextBox.Name = "displayTextBox";
            displayTextBox.ReadOnly = true;
            displayTextBox.ScrollBars = ScrollBars.Vertical;
            displayTextBox.Size = new Size(746, 208);
            displayTextBox.TabIndex = 10;
            displayTextBox.TextChanged += textBox1_TextChanged;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Cursor = Cursors.Hand;
            textBox1.Location = new Point(324, 304);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(157, 27);
            textBox1.TabIndex = 11;
            textBox1.TextChanged += textBox2_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Cursor = Cursors.Hand;
            textBox2.Location = new Point(652, 304);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(157, 27);
            textBox2.TabIndex = 13;
            textBox2.TextChanged += textBox3_TextChanged;
            // 
            // button2
            // 
            button2.BackgroundImage = WinFormsApp2.Properties.Resources.Untitl7e4d1;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(441, 351);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(236, 44);
            button2.TabIndex = 12;
            button2.Text = "Enter";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Menu;
            button4.BackgroundImage = WinFormsApp2.Properties.Resources.bin;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(116, 226);
            button4.Name = "button4";
            button4.Size = new Size(40, 38);
            button4.TabIndex = 14;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.BackgroundImage = WinFormsApp2.Properties.Resources.Untit4l67e4d1;
            checkBox1.BackgroundImageLayout = ImageLayout.Zoom;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.ForeColor = SystemColors.ButtonHighlight;
            checkBox1.ImageAlign = ContentAlignment.BottomCenter;
            checkBox1.Location = new Point(175, 138);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(201, 40);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "الفرق بين الرموز (Admin)";
            checkBox1.TextAlign = ContentAlignment.MiddleRight;
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.Visible = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.DarkBlue;
            numericUpDown1.Cursor = Cursors.Hand;
            numericUpDown1.ForeColor = Color.White;
            numericUpDown1.Location = new Point(183, 185);
            numericUpDown1.Margin = new Padding(3, 4, 3, 4);
            numericUpDown1.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.ReadOnly = true;
            numericUpDown1.Size = new Size(173, 27);
            numericUpDown1.TabIndex = 18;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Visible = false;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(441, 154);
            label2.Name = "label2";
            label2.Size = new Size(236, 49);
            label2.TabIndex = 19;
            label2.Text = "شو العلامة الي تعرفها؟";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.UseMnemonic = false;
            // 
            // button3
            // 
            button3.BackgroundImage = WinFormsApp2.Properties.Resources.administrato2r1;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(116, 137);
            button3.Name = "button3";
            button3.Size = new Size(40, 40);
            button3.TabIndex = 20;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkBlue;
            button5.BackgroundImage = WinFormsApp2.Properties.Resources._switch;
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.Cursor = Cursors.Hand;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Arial Narrow", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ActiveCaptionText;
            button5.Location = new Point(116, 434);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(40, 38);
            button5.TabIndex = 21;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(183, 52);
            label3.Name = "label3";
            label3.Size = new Size(46, 83);
            label3.TabIndex = 22;
            label3.Text = "|";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            BackgroundImage = WinFormsApp2.Properties.Resources.back2;
            ClientSize = new Size(1143, 790);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(numericUpDown1);
            Controls.Add(checkBox1);
            Controls.Add(button4);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(displayTextBox);
            Controls.Add(information);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label3);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "3alamtak";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button1;
        private Label label4;
        private Button information;
        private TextBox displayTextBox;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private Button button4;
        private CheckBox checkBox1;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private Button button3;
        private Button button5;
        private Label label3;
    }
}