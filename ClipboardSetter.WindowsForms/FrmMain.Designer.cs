namespace ClipboardSetter.WindowsForms
{
    partial class FrmMain
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
            this.txtClipboardContent = new System.Windows.Forms.TextBox();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnRestart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtClipboardContent
            // 
            this.txtClipboardContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClipboardContent.Location = new System.Drawing.Point(90, 41);
            this.txtClipboardContent.Name = "txtClipboardContent";
            this.txtClipboardContent.Size = new System.Drawing.Size(111, 80);
            this.txtClipboardContent.TabIndex = 0;
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(12, 155);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(85, 23);
            this.BtnNext.TabIndex = 1;
            this.BtnNext.Text = "&Next";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnRestart
            // 
            this.BtnRestart.Location = new System.Drawing.Point(201, 155);
            this.BtnRestart.Name = "BtnRestart";
            this.BtnRestart.Size = new System.Drawing.Size(75, 23);
            this.BtnRestart.TabIndex = 3;
            this.BtnRestart.Text = "&Restart";
            this.BtnRestart.UseVisualStyleBackColor = true;
            this.BtnRestart.Click += new System.EventHandler(this.BtnRestart_Click);
            // 
            // FrmMain
            // 
            this.AcceptButton = this.BtnNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(288, 199);
            this.Controls.Add(this.BtnRestart);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.txtClipboardContent);
            this.Name = "FrmMain";
            this.Text = "ClipboardSetter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClipboardContent;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnRestart;
    }
}

