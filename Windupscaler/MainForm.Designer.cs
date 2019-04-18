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
            this.borderlessCheckbox = new System.Windows.Forms.CheckBox();
            this.fullscreenRadioBtn = new System.Windows.Forms.RadioButton();
            this.aspectRatioRadioBtn = new System.Windows.Forms.RadioButton();
            this.customRadioBtn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.customResolutionXInput = new System.Windows.Forms.TextBox();
            this.customResolutionYInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.scaleBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.accommodateTaskbarCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // windowList
            // 
            this.windowList.FormattingEnabled = true;
            this.windowList.Location = new System.Drawing.Point(12, 29);
            this.windowList.Name = "windowList";
            this.windowList.Size = new System.Drawing.Size(219, 225);
            this.windowList.TabIndex = 0;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(12, 260);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(219, 30);
            this.refreshBtn.TabIndex = 1;
            this.refreshBtn.Text = "Refresh window list";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // borderlessCheckbox
            // 
            this.borderlessCheckbox.AutoSize = true;
            this.borderlessCheckbox.Checked = true;
            this.borderlessCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.borderlessCheckbox.Location = new System.Drawing.Point(12, 398);
            this.borderlessCheckbox.Name = "borderlessCheckbox";
            this.borderlessCheckbox.Size = new System.Drawing.Size(75, 17);
            this.borderlessCheckbox.TabIndex = 4;
            this.borderlessCheckbox.Text = "Borderless";
            this.borderlessCheckbox.UseVisualStyleBackColor = true;
            // 
            // fullscreenRadioBtn
            // 
            this.fullscreenRadioBtn.AutoSize = true;
            this.fullscreenRadioBtn.Checked = true;
            this.fullscreenRadioBtn.Location = new System.Drawing.Point(6, 19);
            this.fullscreenRadioBtn.Name = "fullscreenRadioBtn";
            this.fullscreenRadioBtn.Size = new System.Drawing.Size(73, 17);
            this.fullscreenRadioBtn.TabIndex = 5;
            this.fullscreenRadioBtn.TabStop = true;
            this.fullscreenRadioBtn.Text = "Fullscreen";
            this.fullscreenRadioBtn.UseVisualStyleBackColor = true;
            // 
            // aspectRatioRadioBtn
            // 
            this.aspectRatioRadioBtn.AutoSize = true;
            this.aspectRatioRadioBtn.Location = new System.Drawing.Point(6, 43);
            this.aspectRatioRadioBtn.Name = "aspectRatioRadioBtn";
            this.aspectRatioRadioBtn.Size = new System.Drawing.Size(108, 17);
            this.aspectRatioRadioBtn.TabIndex = 6;
            this.aspectRatioRadioBtn.Text = "Keep aspect-ratio";
            this.aspectRatioRadioBtn.UseVisualStyleBackColor = true;
            // 
            // customRadioBtn
            // 
            this.customRadioBtn.AutoSize = true;
            this.customRadioBtn.Location = new System.Drawing.Point(6, 67);
            this.customRadioBtn.Name = "customRadioBtn";
            this.customRadioBtn.Size = new System.Drawing.Size(111, 17);
            this.customRadioBtn.TabIndex = 7;
            this.customRadioBtn.Text = "Custom resolution:";
            this.customRadioBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.fullscreenRadioBtn);
            this.groupBox1.Controls.Add(this.customResolutionYInput);
            this.groupBox1.Controls.Add(this.customResolutionXInput);
            this.groupBox1.Controls.Add(this.customRadioBtn);
            this.groupBox1.Controls.Add(this.aspectRatioRadioBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 296);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 96);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scaling mode:";
            // 
            // customResolutionXInput
            // 
            this.customResolutionXInput.Enabled = false;
            this.customResolutionXInput.Location = new System.Drawing.Point(119, 66);
            this.customResolutionXInput.MaxLength = 4;
            this.customResolutionXInput.Name = "customResolutionXInput";
            this.customResolutionXInput.Size = new System.Drawing.Size(32, 20);
            this.customResolutionXInput.TabIndex = 9;
            // 
            // customResolutionYInput
            // 
            this.customResolutionYInput.Enabled = false;
            this.customResolutionYInput.Location = new System.Drawing.Point(171, 66);
            this.customResolutionYInput.MaxLength = 4;
            this.customResolutionYInput.Name = "customResolutionYInput";
            this.customResolutionYInput.Size = new System.Drawing.Size(32, 20);
            this.customResolutionYInput.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "X";
            // 
            // scaleBtn
            // 
            this.scaleBtn.Enabled = false;
            this.scaleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scaleBtn.Location = new System.Drawing.Point(12, 444);
            this.scaleBtn.Name = "scaleBtn";
            this.scaleBtn.Size = new System.Drawing.Size(219, 44);
            this.scaleBtn.TabIndex = 9;
            this.scaleBtn.Text = "Scale!";
            this.scaleBtn.UseVisualStyleBackColor = true;
            this.scaleBtn.Click += new System.EventHandler(this.scaleBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Select an open window:";
            // 
            // accommodateTaskbarCheckbox
            // 
            this.accommodateTaskbarCheckbox.AutoSize = true;
            this.accommodateTaskbarCheckbox.Enabled = false;
            this.accommodateTaskbarCheckbox.Location = new System.Drawing.Point(12, 421);
            this.accommodateTaskbarCheckbox.Name = "accommodateTaskbarCheckbox";
            this.accommodateTaskbarCheckbox.Size = new System.Drawing.Size(132, 17);
            this.accommodateTaskbarCheckbox.TabIndex = 11;
            this.accommodateTaskbarCheckbox.Text = "Accommodate taskbar";
            this.accommodateTaskbarCheckbox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 501);
            this.Controls.Add(this.accommodateTaskbarCheckbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scaleBtn);
            this.Controls.Add(this.borderlessCheckbox);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.windowList);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Windupscaler";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox windowList;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.CheckBox borderlessCheckbox;
        private System.Windows.Forms.RadioButton fullscreenRadioBtn;
        private System.Windows.Forms.RadioButton aspectRatioRadioBtn;
        private System.Windows.Forms.RadioButton customRadioBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox customResolutionXInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customResolutionYInput;
        private System.Windows.Forms.Button scaleBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox accommodateTaskbarCheckbox;
    }
}

