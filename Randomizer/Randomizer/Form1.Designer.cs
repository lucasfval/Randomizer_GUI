namespace Randomizer
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
            this.randomButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.discardButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.originBox = new System.Windows.Forms.TextBox();
            this.destinyBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.countIn = new System.Windows.Forms.TextBox();
            this.countOut = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // randomButton
            // 
            this.randomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.randomButton.Image = ((System.Drawing.Image)(resources.GetObject("randomButton.Image")));
            this.randomButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.randomButton.Location = new System.Drawing.Point(12, 160);
            this.randomButton.Name = "randomButton";
            this.randomButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.randomButton.Size = new System.Drawing.Size(225, 79);
            this.randomButton.TabIndex = 0;
            this.randomButton.Text = "Randomize";
            this.randomButton.UseVisualStyleBackColor = true;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.Location = new System.Drawing.Point(12, 256);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(225, 79);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // discardButton
            // 
            this.discardButton.Image = ((System.Drawing.Image)(resources.GetObject("discardButton.Image")));
            this.discardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.discardButton.Location = new System.Drawing.Point(12, 366);
            this.discardButton.Name = "discardButton";
            this.discardButton.Size = new System.Drawing.Size(225, 79);
            this.discardButton.TabIndex = 0;
            this.discardButton.Text = "Discard";
            this.discardButton.UseVisualStyleBackColor = true;
            this.discardButton.Click += new System.EventHandler(this.discardButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"txt files (*.txt)|*.txt|All files (*.*)|*.*\"";
            this.openFileDialog1.InitialDirectory = "@\"C:\\\"";
            this.openFileDialog1.ReadOnlyChecked = true;
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.ShowReadOnly = true;
            this.openFileDialog1.Title = "Origin Text File";
            // 
            // originBox
            // 
            this.originBox.Location = new System.Drawing.Point(12, 32);
            this.originBox.Name = "originBox";
            this.originBox.ReadOnly = true;
            this.originBox.Size = new System.Drawing.Size(363, 27);
            this.originBox.TabIndex = 1;
            this.originBox.Text = "Origin File";
            // 
            // destinyBox
            // 
            this.destinyBox.Location = new System.Drawing.Point(12, 105);
            this.destinyBox.Name = "destinyBox";
            this.destinyBox.ReadOnly = true;
            this.destinyBox.Size = new System.Drawing.Size(363, 27);
            this.destinyBox.TabIndex = 1;
            this.destinyBox.Text = "Destiny File";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(398, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(250, 160);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(125, 43);
            this.confirmButton.TabIndex = 3;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Links in Origin: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Links in Destiny: ";
            // 
            // countIn
            // 
            this.countIn.Location = new System.Drawing.Point(409, 363);
            this.countIn.Name = "countIn";
            this.countIn.ReadOnly = true;
            this.countIn.Size = new System.Drawing.Size(101, 27);
            this.countIn.TabIndex = 5;
            // 
            // countOut
            // 
            this.countOut.Location = new System.Drawing.Point(409, 401);
            this.countOut.Name = "countOut";
            this.countOut.ReadOnly = true;
            this.countOut.Size = new System.Drawing.Size(101, 27);
            this.countOut.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(541, 488);
            this.Controls.Add(this.countOut);
            this.Controls.Add(this.countIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.destinyBox);
            this.Controls.Add(this.originBox);
            this.Controls.Add(this.discardButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.randomButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Randomizer";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button randomButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button discardButton;
        private System.Windows.Forms.TextBox originPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox originBox;
        private System.Windows.Forms.TextBox destinyBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox countIn;
        private System.Windows.Forms.TextBox countOut;
    }
}

