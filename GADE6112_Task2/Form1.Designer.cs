namespace GADE6112_Task2
{
    partial class Form1
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.lblRound = new System.Windows.Forms.Label();
            this.richTextBoxMap = new System.Windows.Forms.RichTextBox();
            this.richTextBoxDescr = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(912, 38);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(156, 55);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(915, 127);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(152, 63);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Location = new System.Drawing.Point(12, 9);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(58, 17);
            this.lblRound.TabIndex = 2;
            this.lblRound.Text = "Round: ";
            // 
            // richTextBoxMap
            // 
            this.richTextBoxMap.Location = new System.Drawing.Point(15, 66);
            this.richTextBoxMap.Name = "richTextBoxMap";
            this.richTextBoxMap.Size = new System.Drawing.Size(556, 405);
            this.richTextBoxMap.TabIndex = 3;
            this.richTextBoxMap.Text = "";
            // 
            // richTextBoxDescr
            // 
            this.richTextBoxDescr.Location = new System.Drawing.Point(618, 226);
            this.richTextBoxDescr.Name = "richTextBoxDescr";
            this.richTextBoxDescr.Size = new System.Drawing.Size(457, 244);
            this.richTextBoxDescr.TabIndex = 4;
            this.richTextBoxDescr.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 492);
            this.Controls.Add(this.richTextBoxDescr);
            this.Controls.Add(this.richTextBoxMap);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnSave);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.RichTextBox richTextBoxMap;
        private System.Windows.Forms.RichTextBox richTextBoxDescr;
    }
}

