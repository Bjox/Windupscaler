namespace Windupscaler
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
            this.windowList = new System.Windows.Forms.ListBox();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.fullscreenBtn = new System.Windows.Forms.Button();
            this.aspectBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // windowList
            // 
            this.windowList.FormattingEnabled = true;
            this.windowList.Location = new System.Drawing.Point(12, 12);
            this.windowList.Name = "windowList";
            this.windowList.Size = new System.Drawing.Size(219, 225);
            this.windowList.TabIndex = 0;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(12, 243);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(219, 23);
            this.refreshBtn.TabIndex = 1;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // fullscreenBtn
            // 
            this.fullscreenBtn.Location = new System.Drawing.Point(12, 272);
            this.fullscreenBtn.Name = "fullscreenBtn";
            this.fullscreenBtn.Size = new System.Drawing.Size(105, 62);
            this.fullscreenBtn.TabIndex = 2;
            this.fullscreenBtn.Text = "Fullscreen";
            this.fullscreenBtn.UseVisualStyleBackColor = true;
            this.fullscreenBtn.Click += new System.EventHandler(this.fullscreenBtn_Click);
            // 
            // aspectBtn
            // 
            this.aspectBtn.Location = new System.Drawing.Point(126, 272);
            this.aspectBtn.Name = "aspectBtn";
            this.aspectBtn.Size = new System.Drawing.Size(105, 62);
            this.aspectBtn.TabIndex = 3;
            this.aspectBtn.Text = "Keep aspect-ratio";
            this.aspectBtn.UseVisualStyleBackColor = true;
            this.aspectBtn.Click += new System.EventHandler(this.aspectBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 347);
            this.Controls.Add(this.aspectBtn);
            this.Controls.Add(this.fullscreenBtn);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.windowList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Windupscaler";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox windowList;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button fullscreenBtn;
        private System.Windows.Forms.Button aspectBtn;
    }
}

