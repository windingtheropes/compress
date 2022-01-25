namespace Compress
{
    partial class mainForm
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
            this.inputBox = new System.Windows.Forms.TextBox();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.goButton = new System.Windows.Forms.Button();
            this.crfBox = new System.Windows.Forms.NumericUpDown();
            this.inputLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.crfRadio = new System.Windows.Forms.RadioButton();
            this.bitrateRadio = new System.Windows.Forms.RadioButton();
            this.crfLabel = new System.Windows.Forms.Label();
            this.bitrateBox = new System.Windows.Forms.TextBox();
            this.bitrateLabel = new System.Windows.Forms.Label();
            this.inputBrowse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.crfBox)).BeginInit();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(74, 66);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(199, 20);
            this.inputBox.TabIndex = 0;
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(74, 92);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(199, 20);
            this.outputBox.TabIndex = 1;
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(74, 296);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 2;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // crfBox
            // 
            this.crfBox.Location = new System.Drawing.Point(74, 162);
            this.crfBox.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.crfBox.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.crfBox.Name = "crfBox";
            this.crfBox.Size = new System.Drawing.Size(120, 20);
            this.crfBox.TabIndex = 3;
            this.crfBox.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(12, 69);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(56, 13);
            this.inputLabel.TabIndex = 4;
            this.inputLabel.Text = "Input Path";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(4, 95);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(64, 13);
            this.outputLabel.TabIndex = 5;
            this.outputLabel.Text = "Output Path";
            // 
            // crfRadio
            // 
            this.crfRadio.AutoSize = true;
            this.crfRadio.Location = new System.Drawing.Point(74, 130);
            this.crfRadio.Name = "crfRadio";
            this.crfRadio.Size = new System.Drawing.Size(116, 17);
            this.crfRadio.TabIndex = 6;
            this.crfRadio.TabStop = true;
            this.crfRadio.Text = "Change CRF Value";
            this.crfRadio.UseVisualStyleBackColor = true;
            // 
            // bitrateRadio
            // 
            this.bitrateRadio.AutoSize = true;
            this.bitrateRadio.Location = new System.Drawing.Point(196, 130);
            this.bitrateRadio.Name = "bitrateRadio";
            this.bitrateRadio.Size = new System.Drawing.Size(95, 17);
            this.bitrateRadio.TabIndex = 8;
            this.bitrateRadio.TabStop = true;
            this.bitrateRadio.Text = "Change Bitrate";
            this.bitrateRadio.UseVisualStyleBackColor = true;
            // 
            // crfLabel
            // 
            this.crfLabel.AutoSize = true;
            this.crfLabel.Location = new System.Drawing.Point(40, 164);
            this.crfLabel.Name = "crfLabel";
            this.crfLabel.Size = new System.Drawing.Size(28, 13);
            this.crfLabel.TabIndex = 9;
            this.crfLabel.Text = "CRF";
            // 
            // bitrateBox
            // 
            this.bitrateBox.Location = new System.Drawing.Point(87, 188);
            this.bitrateBox.Name = "bitrateBox";
            this.bitrateBox.Size = new System.Drawing.Size(49, 20);
            this.bitrateBox.TabIndex = 10;
            // 
            // bitrateLabel
            // 
            this.bitrateLabel.AutoSize = true;
            this.bitrateLabel.Location = new System.Drawing.Point(12, 191);
            this.bitrateLabel.Name = "bitrateLabel";
            this.bitrateLabel.Size = new System.Drawing.Size(69, 13);
            this.bitrateLabel.TabIndex = 11;
            this.bitrateLabel.Text = "Bitrate (kbps)";
            // 
            // inputBrowse
            // 
            this.inputBrowse.Location = new System.Drawing.Point(279, 64);
            this.inputBrowse.Name = "inputBrowse";
            this.inputBrowse.Size = new System.Drawing.Size(75, 23);
            this.inputBrowse.TabIndex = 12;
            this.inputBrowse.Text = "Browse";
            this.inputBrowse.UseVisualStyleBackColor = true;
            this.inputBrowse.Click += new System.EventHandler(this.inputBrowse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 460);
            this.Controls.Add(this.inputBrowse);
            this.Controls.Add(this.bitrateLabel);
            this.Controls.Add(this.bitrateBox);
            this.Controls.Add(this.crfLabel);
            this.Controls.Add(this.bitrateRadio);
            this.Controls.Add(this.crfRadio);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.crfBox);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.inputBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.crfBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.NumericUpDown crfBox;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.RadioButton crfRadio;
        private System.Windows.Forms.RadioButton bitrateRadio;
        private System.Windows.Forms.Label crfLabel;
        private System.Windows.Forms.TextBox bitrateBox;
        private System.Windows.Forms.Label bitrateLabel;
        private System.Windows.Forms.Button inputBrowse;
    }
}

