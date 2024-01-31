namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            notifyIcon1 = new NotifyIcon(components);
            EmailBox = new RichTextBox();
            PasswordBox = new RichTextBox();
            PathBox = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // EmailBox
            // 
            EmailBox.BorderStyle = BorderStyle.None;
            EmailBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EmailBox.Location = new Point(70, 68);
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(630, 28);
            EmailBox.TabIndex = 0;
            EmailBox.Text = "email";
            // 
            // PasswordBox
            // 
            PasswordBox.BorderStyle = BorderStyle.None;
            PasswordBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordBox.Location = new Point(70, 127);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(630, 28);
            PasswordBox.TabIndex = 1;
            PasswordBox.Text = "password";
            // 
            // PathBox
            // 
            PathBox.BorderStyle = BorderStyle.None;
            PathBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PathBox.Location = new Point(70, 190);
            PathBox.Name = "PathBox";
            PathBox.Size = new Size(630, 28);
            PathBox.TabIndex = 2;
            PathBox.Text = "path";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(531, 224);
            button1.Name = "button1";
            button1.Size = new Size(169, 34);
            button1.TabIndex = 3;
            button1.Text = "Save Info";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(285, 353);
            button2.Name = "button2";
            button2.Size = new Size(169, 34);
            button2.TabIndex = 4;
            button2.Text = "Launch";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(PathBox);
            Controls.Add(PasswordBox);
            Controls.Add(EmailBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Launcher";
            TopMost = true;
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private NotifyIcon notifyIcon1;
        private RichTextBox EmailBox;
        private RichTextBox PasswordBox;
        private RichTextBox PathBox;
        private Button button1;
        private Button button2;
    }
}
