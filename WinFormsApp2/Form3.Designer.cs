namespace WinFormsApp6
{
    partial class enter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(enter));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Microsoft JhengHei", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(487, 207);
            label1.Name = "label1";
            label1.Size = new Size(254, 103);
            label1.TabIndex = 3;
            label1.Text = "Welcome to      3alamtak";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(524, 345);
            button1.Name = "button1";
            button1.Size = new Size(154, 40);
            button1.TabIndex = 4;
            button1.Text = "Try My App";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackgroundImage = WinFormsApp2.Properties.Resources.linkedin1;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(472, 455);
            button2.Name = "button2";
            button2.Size = new Size(49, 47);
            button2.TabIndex = 5;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = WinFormsApp2.Properties.Resources.instagram;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(588, 455);
            button3.Name = "button3";
            button3.Size = new Size(49, 47);
            button3.TabIndex = 6;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackgroundImage = WinFormsApp2.Properties.Resources.facebook;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(692, 455);
            button4.Name = "button4";
            button4.Size = new Size(49, 47);
            button4.TabIndex = 7;
            button4.UseVisualStyleBackColor = true;
            // 
            // enter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = WinFormsApp2.Properties.Resources.ahmad_orof_0;
            CancelButton = button1;
            ClientSize = new Size(785, 608);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "enter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "3alamtak";
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}