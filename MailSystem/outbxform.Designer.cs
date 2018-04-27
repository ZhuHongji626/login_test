namespace MailSystem
{
    partial class outbxform
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.subject = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.from = new System.Windows.Forms.TextBox();
            this.to = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.message = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "To:";
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
            this.subject.Location = new System.Drawing.Point(100, 12);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(312, 22);
            this.subject.TabIndex = 1;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Red;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(394, 277);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 36);
            this.delete.TabIndex = 5;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(14, 179);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(487, 73);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // from
            // 
            this.from.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.from.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.from.Enabled = false;
            this.from.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from.Location = new System.Drawing.Point(100, 58);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(312, 18);
            this.from.TabIndex = 8;
            // 
            // to
            // 
            this.to.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.to.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.to.Enabled = false;
            this.to.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to.Location = new System.Drawing.Point(100, 88);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(312, 18);
            this.to.TabIndex = 9;
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
            this.shapeContainer1.TabIndex = 11;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.White;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 14;
            this.lineShape2.X2 = 500;
            this.lineShape2.Y1 = 163;
            this.lineShape2.Y2 = 163;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.White;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 13;
            this.lineShape1.X2 = 500;
            this.lineShape1.Y1 = 42;
            this.lineShape1.Y2 = 43;
            // 
            // message
            // 
            this.message.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.message.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.message.Location = new System.Drawing.Point(100, 118);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(312, 28);
            this.message.TabIndex = 12;
            this.message.Text = "";
            // 
            // outbxform
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
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "outbxform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.TextBox subject;
        public System.Windows.Forms.TextBox from;
        public System.Windows.Forms.TextBox to;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        public System.Windows.Forms.RichTextBox message;
    }
}