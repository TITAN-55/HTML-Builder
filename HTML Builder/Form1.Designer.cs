namespace HTML_Builder
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
            this.htmlText = new System.Windows.Forms.RichTextBox();
            this.outputText = new System.Windows.Forms.RichTextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.settingsCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // htmlText
            // 
            this.htmlText.Location = new System.Drawing.Point(12, 69);
            this.htmlText.Name = "htmlText";
            this.htmlText.Size = new System.Drawing.Size(348, 270);
            this.htmlText.TabIndex = 1;
            this.htmlText.Text = "";
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(396, 69);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(348, 270);
            this.outputText.TabIndex = 2;
            this.outputText.Text = "";
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(12, 368);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(132, 38);
            this.convertButton.TabIndex = 3;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(612, 368);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(132, 38);
            this.copyButton.TabIndex = 4;
            this.copyButton.Text = "Copy Code";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // settingsCombo
            // 
            this.settingsCombo.FormattingEnabled = true;
            this.settingsCombo.Items.AddRange(new object[] {
            "Convert HTML",
            "Convert Text"});
            this.settingsCombo.Location = new System.Drawing.Point(12, 13);
            this.settingsCombo.Name = "settingsCombo";
            this.settingsCombo.Size = new System.Drawing.Size(348, 28);
            this.settingsCombo.TabIndex = 5;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(768, 429);
            this.Controls.Add(this.settingsCombo);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.htmlText);
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.Text = "HTML BUILDER";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox htmlText;
        private System.Windows.Forms.RichTextBox outputText;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.ComboBox settingsCombo;
    }
}

