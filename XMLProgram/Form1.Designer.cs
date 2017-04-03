namespace XMLProgram
{
    partial class mainForm
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
            this.readButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.writeButton = new System.Windows.Forms.Button();
            this.contentSelect = new System.Windows.Forms.TextBox();
            this.editButton = new System.Windows.Forms.Button();
            this.newContent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(38, 23);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(64, 32);
            this.readButton.TabIndex = 0;
            this.readButton.Text = "Read File";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(35, 155);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(254, 284);
            this.outputLabel.TabIndex = 1;
            // 
            // writeButton
            // 
            this.writeButton.Location = new System.Drawing.Point(108, 23);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(64, 32);
            this.writeButton.TabIndex = 2;
            this.writeButton.Text = "Write File";
            this.writeButton.UseVisualStyleBackColor = true;
            this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
            // 
            // contentSelect
            // 
            this.contentSelect.Location = new System.Drawing.Point(119, 82);
            this.contentSelect.Name = "contentSelect";
            this.contentSelect.Size = new System.Drawing.Size(100, 20);
            this.contentSelect.TabIndex = 4;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(242, 82);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(47, 46);
            this.editButton.TabIndex = 6;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // newContent
            // 
            this.newContent.Location = new System.Drawing.Point(119, 108);
            this.newContent.Name = "newContent";
            this.newContent.Size = new System.Drawing.Size(100, 20);
            this.newContent.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Old Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "New Name:";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 448);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newContent);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.contentSelect);
            this.Controls.Add(this.writeButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.readButton);
            this.Name = "mainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button writeButton;
        private System.Windows.Forms.TextBox contentSelect;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox newContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

