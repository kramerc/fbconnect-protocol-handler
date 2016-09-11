namespace FBConnect_Protocol_Handler
{
    partial class MainForm
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
            this.accessTokenTextBox = new System.Windows.Forms.TextBox();
            this.accessTokenLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // accessTokenTextBox
            // 
            this.accessTokenTextBox.Location = new System.Drawing.Point(97, 12);
            this.accessTokenTextBox.Name = "accessTokenTextBox";
            this.accessTokenTextBox.ReadOnly = true;
            this.accessTokenTextBox.Size = new System.Drawing.Size(489, 20);
            this.accessTokenTextBox.TabIndex = 0;
            // 
            // accessTokenLabel
            // 
            this.accessTokenLabel.AutoSize = true;
            this.accessTokenLabel.Location = new System.Drawing.Point(12, 15);
            this.accessTokenLabel.Name = "accessTokenLabel";
            this.accessTokenLabel.Size = new System.Drawing.Size(79, 13);
            this.accessTokenLabel.TabIndex = 1;
            this.accessTokenLabel.Text = "Access Token:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 44);
            this.Controls.Add(this.accessTokenLabel);
            this.Controls.Add(this.accessTokenTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FBConnect Protocol Handler";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox accessTokenTextBox;
        private System.Windows.Forms.Label accessTokenLabel;
    }
}

