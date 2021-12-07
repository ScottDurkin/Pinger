
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
            this.IDC_PING_COUNT = new System.Windows.Forms.Label();
            this.IDC_LAST_PING_DATETIME = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IDE_PING_LIST
            // 
            this.IDE_PING_LIST.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.IDE_PING_LIST.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IDE_PING_LIST.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDE_PING_LIST.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.IDE_PING_LIST.FormattingEnabled = true;
            this.IDE_PING_LIST.ItemHeight = 22;
            this.IDE_PING_LIST.Location = new System.Drawing.Point(13, 13);
            this.IDE_PING_LIST.Name = "IDE_PING_LIST";
            this.IDE_PING_LIST.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.IDE_PING_LIST.Size = new System.Drawing.Size(354, 352);
            this.IDE_PING_LIST.TabIndex = 0;
            // 
            // IDC_PING_COUNT
            // 
            this.IDC_PING_COUNT.AutoSize = true;
            this.IDC_PING_COUNT.BackColor = System.Drawing.Color.Transparent;
            this.IDC_PING_COUNT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDC_PING_COUNT.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.IDC_PING_COUNT.Location = new System.Drawing.Point(9, 380);
            this.IDC_PING_COUNT.Name = "IDC_PING_COUNT";
            this.IDC_PING_COUNT.Size = new System.Drawing.Size(75, 22);
            this.IDC_PING_COUNT.TabIndex = 1;
            this.IDC_PING_COUNT.Text = "Pings: 0";
            // 
            // IDC_LAST_PING_DATETIME
            // 
            this.IDC_LAST_PING_DATETIME.AutoSize = true;
            this.IDC_LAST_PING_DATETIME.BackColor = System.Drawing.Color.Transparent;
            this.IDC_LAST_PING_DATETIME.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDC_LAST_PING_DATETIME.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.IDC_LAST_PING_DATETIME.Location = new System.Drawing.Point(9, 404);
            this.IDC_LAST_PING_DATETIME.Name = "IDC_LAST_PING_DATETIME";
            this.IDC_LAST_PING_DATETIME.Size = new System.Drawing.Size(186, 22);
            this.IDC_LAST_PING_DATETIME.TabIndex = 2;
            this.IDC_LAST_PING_DATETIME.Text = "Last Ping: No ping yet";
            // 
            // IDD_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(379, 453);
            this.Controls.Add(this.IDC_LAST_PING_DATETIME);
            this.Controls.Add(this.IDC_PING_COUNT);
            this.Controls.Add(this.IDE_PING_LIST);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "IDD_FORM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pinger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox IDE_PING_LIST;
        private System.Windows.Forms.Label IDC_PING_COUNT;
        private System.Windows.Forms.Label IDC_LAST_PING_DATETIME;
    }
}

