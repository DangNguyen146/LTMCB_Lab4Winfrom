namespace Bai4_WebBrowser
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
            this.btnBiewSource = new System.Windows.Forms.Button();
            this.btnDowload = new System.Windows.Forms.Button();
            this.btnViewHTML = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // btnBiewSource
            // 
            this.btnBiewSource.Location = new System.Drawing.Point(517, 12);
            this.btnBiewSource.Name = "btnBiewSource";
            this.btnBiewSource.Size = new System.Drawing.Size(91, 23);
            this.btnBiewSource.TabIndex = 9;
            this.btnBiewSource.Text = "View Source";
            this.btnBiewSource.UseVisualStyleBackColor = true;
            this.btnBiewSource.Click += new System.EventHandler(this.btnBiewSource_Click);
            // 
            // btnDowload
            // 
            this.btnDowload.Location = new System.Drawing.Point(444, 12);
            this.btnDowload.Name = "btnDowload";
            this.btnDowload.Size = new System.Drawing.Size(67, 23);
            this.btnDowload.TabIndex = 8;
            this.btnDowload.Text = "Dowload";
            this.btnDowload.UseVisualStyleBackColor = true;
            this.btnDowload.Click += new System.EventHandler(this.btnDowload_Click);
            // 
            // btnViewHTML
            // 
            this.btnViewHTML.Location = new System.Drawing.Point(412, 14);
            this.btnViewHTML.Name = "btnViewHTML";
            this.btnViewHTML.Size = new System.Drawing.Size(26, 20);
            this.btnViewHTML.TabIndex = 6;
            this.btnViewHTML.Text = ">";
            this.btnViewHTML.UseVisualStyleBackColor = true;
            this.btnViewHTML.Click += new System.EventHandler(this.btnViewHTML_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(9, 14);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(408, 20);
            this.txtUrl.TabIndex = 5;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(9, 40);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(599, 398);
            this.webBrowser1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 450);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnBiewSource);
            this.Controls.Add(this.btnDowload);
            this.Controls.Add(this.btnViewHTML);
            this.Controls.Add(this.txtUrl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBiewSource;
        private System.Windows.Forms.Button btnDowload;
        private System.Windows.Forms.Button btnViewHTML;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

