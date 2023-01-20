namespace Check_SHA256_Of_A_File
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
            this.GivenHash = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.Prompter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GivenHash
            // 
            this.GivenHash.AllowDrop = true;
            this.GivenHash.Location = new System.Drawing.Point(12, 12);
            this.GivenHash.Name = "GivenHash";
            this.GivenHash.PlaceholderText = "Enter the hash";
            this.GivenHash.Size = new System.Drawing.Size(770, 27);
            this.GivenHash.TabIndex = 0;
            this.GivenHash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GivenHash.DragDrop += new System.Windows.Forms.DragEventHandler(this.All_DragDrop);
            this.GivenHash.DragEnter += new System.Windows.Forms.DragEventHandler(this.All_DragEnter);
            // 
            // button1
            // 
            this.button1.AllowDrop = true;
            this.button1.Location = new System.Drawing.Point(349, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.DragDrop += new System.Windows.Forms.DragEventHandler(this.All_DragDrop);
            this.button1.DragEnter += new System.Windows.Forms.DragEventHandler(this.All_DragEnter);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AllowDrop = true;
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResultLabel.Location = new System.Drawing.Point(449, 40);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 32);
            this.ResultLabel.TabIndex = 2;
            this.ResultLabel.DragDrop += new System.Windows.Forms.DragEventHandler(this.All_DragDrop);
            this.ResultLabel.DragEnter += new System.Windows.Forms.DragEventHandler(this.All_DragEnter);
            // 
            // Prompter
            // 
            this.Prompter.AllowDrop = true;
            this.Prompter.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Prompter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Prompter.Location = new System.Drawing.Point(12, 80);
            this.Prompter.Name = "Prompter";
            this.Prompter.PlaceholderText = "Drag and drop a file to compare its hash";
            this.Prompter.ReadOnly = true;
            this.Prompter.Size = new System.Drawing.Size(770, 20);
            this.Prompter.TabIndex = 4;
            this.Prompter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Prompter.DragDrop += new System.Windows.Forms.DragEventHandler(this.All_DragDrop);
            this.Prompter.DragEnter += new System.Windows.Forms.DragEventHandler(this.All_DragEnter);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 111);
            this.Controls.Add(this.Prompter);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GivenHash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Check SHA256";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.All_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.All_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox GivenHash;
        private Button button1;
        private Label ResultLabel;
        private TextBox Prompter;
    }
}