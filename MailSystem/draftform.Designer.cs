namespace MailSystem
{
    partial class draftform
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
            this.message = new System.Windows.Forms.RichTextBox();
            this.to = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.from = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.subject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.reply = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.SuspendLayout();
            // 
            // message
            // 
            this.message.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.message.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.message.Location = new System.Drawing.Point(99, 119);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(312, 28);
            this.message.TabIndex = 22;
            this.message.Text = "";
            // 
            // to
            // 
            this.to.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.to.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.to.Enabled = false;
            this.to.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to.Location = new System.Drawing.Point(99, 89);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(312, 18);
            this.to.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "To:";
            // 
            // from
            // 
            this.from.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.from.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.from.Enabled = false;
            this.from.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from.Location = new System.Drawing.Point(99, 59);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(312, 18);
            this.from.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "From:";
            // 
            // subject
            // 
            this.subject.AutoCompleteCustomSource.AddRange(new string[] {
            "journalreagan",
            "conarditoh",
            "rigallitoh"});
            this.subject.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.subject.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.subject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subject.Enabled = false;
            this.subject.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject.Location = new System.Drawing.Point(99, 13);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(312, 22);
            this.subject.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Subject:";
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Red;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(393, 278);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 36);
            this.delete.TabIndex = 18;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // reply
            // 
            this.reply.BackColor = System.Drawing.Color.CornflowerBlue;
            this.reply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reply.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reply.ForeColor = System.Drawing.Color.White;
            this.reply.Location = new System.Drawing.Point(261, 278);
            this.reply.Name = "reply";
            this.reply.Size = new System.Drawing.Size(75, 36);
            this.reply.TabIndex = 17;
            this.reply.Text = "Resend";
            this.reply.UseVisualStyleBackColor = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(515, 324);
            this.shapeContainer1.TabIndex = 23;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.White;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 20;
            this.lineShape2.X2 = 492;
            this.lineShape2.Y1 = 187;
            this.lineShape2.Y2 = 186;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.White;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 21;
            this.lineShape1.X2 = 490;
            this.lineShape1.Y1 = 45;
            this.lineShape1.Y2 = 45;
            // 
            // draftform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(515, 324);
            this.Controls.Add(this.message);
            this.Controls.Add(this.to);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.from);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.reply);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "draftform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox message;
        public System.Windows.Forms.TextBox to;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox from;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox subject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button reply;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}