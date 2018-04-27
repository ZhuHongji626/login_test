namespace MailSystem
{
    partial class HomeFrame
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Button();
            this.account = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.PictureBox();
            this.home = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.time = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnsentmail = new System.Windows.Forms.Button();
            this.btndraft = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.home)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.account);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.home);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 72);
            this.panel1.TabIndex = 0;
            // 
            // logout
            // 
            this.logout.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.logout.BackColor = System.Drawing.Color.RoyalBlue;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logout.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(865, 3);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(116, 38);
            this.logout.TabIndex = 4;
            this.logout.Text = "LOGOUT";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // account
            // 
            this.account.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.account.BackColor = System.Drawing.Color.MidnightBlue;
            this.account.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.account.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.account.Location = new System.Drawing.Point(865, 47);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(116, 25);
            this.account.TabIndex = 3;
            this.account.Text = "View accounts";
            this.account.UseVisualStyleBackColor = false;
            this.account.Click += new System.EventHandler(this.account_Click);
            this.account.MouseEnter += new System.EventHandler(this.accounts_MouseEnter);
            this.account.MouseLeave += new System.EventHandler(this.accounts_MouseLeave);
            this.account.MouseHover += new System.EventHandler(this.accounts_MouseHover);
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.BackgroundImage = global::MailSystem.Properties.Resources._4;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit.Location = new System.Drawing.Point(1676, 6);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(44, 39);
            this.exit.TabIndex = 2;
            this.exit.TabStop = false;
            // 
            // home
            // 
            this.home.BackgroundImage = global::MailSystem.Properties.Resources._2;
            this.home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.home.Location = new System.Drawing.Point(50, 24);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(55, 33);
            this.home.TabIndex = 1;
            this.home.TabStop = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(350, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "EMAIL SCHEDULING SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 495);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.BackgroundImage = global::MailSystem.Properties.Resources.bg;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(193, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(791, 495);
            this.panel4.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(193, 495);
            this.panel3.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.time);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnsentmail);
            this.groupBox1.Controls.Add(this.btndraft);
            this.groupBox1.Location = new System.Drawing.Point(15, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 477);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "xxxxx";
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(35, 394);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(75, 23);
            this.time.TabIndex = 6;
            this.time.Text = "Timer";
            this.time.UseVisualStyleBackColor = true;
            this.time.Visible = false;
            this.time.Click += new System.EventHandler(this.time_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button6.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(12, 211);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(129, 51);
            this.button6.TabIndex = 5;
            this.button6.Text = "TRASH";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "COMPOSE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // btnsentmail
            // 
            this.btnsentmail.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnsentmail.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsentmail.Location = new System.Drawing.Point(12, 115);
            this.btnsentmail.Name = "btnsentmail";
            this.btnsentmail.Size = new System.Drawing.Size(129, 51);
            this.btnsentmail.TabIndex = 3;
            this.btnsentmail.Text = "OUTBOX";
            this.btnsentmail.UseVisualStyleBackColor = true;
            this.btnsentmail.Click += new System.EventHandler(this.button4_Click);
            // 
            // btndraft
            // 
            this.btndraft.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btndraft.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndraft.Location = new System.Drawing.Point(12, 305);
            this.btndraft.Name = "btndraft";
            this.btndraft.Size = new System.Drawing.Size(129, 51);
            this.btndraft.TabIndex = 4;
            this.btndraft.Text = "DRAFT";
            this.btndraft.UseVisualStyleBackColor = true;
            this.btndraft.Click += new System.EventHandler(this.button5_Click);
            // 
            // HomeFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 567);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "HomeFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.home)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btndraft;
        private System.Windows.Forms.Button btnsentmail;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox home;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.Button account;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button logout;
        public System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button time;
    }
}