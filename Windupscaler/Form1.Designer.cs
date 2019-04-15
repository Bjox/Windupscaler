namespace Windupscaler
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
            this.windowList = new System.Windows.Forms.ListBox();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.upscaleBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // windowList
            // 
            this.windowList.FormattingEnabled = true;
            this.windowList.Location = new System.Drawing.Point(12, 12);
            this.windowList.Name = "windowList";
            this.windowList.Size = new System.Drawing.Size(280, 225);
            this.windowList.TabIndex = 0;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(12, 243);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshBtn.TabIndex = 1;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // upscaleBtn
            // 
            this.upscaleBtn.Location = new System.Drawing.Point(93, 243);
            this.upscaleBtn.Name = "upscaleBtn";
            this.upscaleBtn.Size = new System.Drawing.Size(75, 23);
            this.upscaleBtn.TabIndex = 2;
            this.upscaleBtn.Text = "Upscale!";
            this.upscaleBtn.UseVisualStyleBackColor = true;
            this.upscaleBtn.Click += new System.EventHandler(this.upscaleBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 279);
            this.Controls.Add(this.upscaleBtn);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.windowList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Windupscaler";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox windowList;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button upscaleBtn;
    }
}

