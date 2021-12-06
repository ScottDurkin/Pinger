
namespace PingApp
{
    partial class IDD_FORM
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
            this.IDE_PING_LIST = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // IDE_PING_LIST
            // 
            this.IDE_PING_LIST.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.IDE_PING_LIST.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IDE_PING_LIST.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.IDE_PING_LIST.FormattingEnabled = true;
            this.IDE_PING_LIST.ItemHeight = 20;
            this.IDE_PING_LIST.Location = new System.Drawing.Point(13, 13);
            this.IDE_PING_LIST.Name = "IDE_PING_LIST";
            this.IDE_PING_LIST.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.IDE_PING_LIST.Size = new System.Drawing.Size(354, 360);
            this.IDE_PING_LIST.TabIndex = 0;
            // 
            // IDD_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(379, 453);
            this.Controls.Add(this.IDE_PING_LIST);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "IDD_FORM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pinger";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox IDE_PING_LIST;
    }
}

