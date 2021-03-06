﻿namespace BuildCorpusTXT
{
    partial class SettingsForm_BuildCorpusTXT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm_BuildCorpusTXT));
            this.SetFileButton = new System.Windows.Forms.Button();
            this.SelectedFileTextbox = new System.Windows.Forms.TextBox();
            this.EncodingDropdown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.LowercaseCheckbox = new System.Windows.Forms.CheckBox();
            this.appendFileCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // SetFileButton
            // 
            this.SetFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetFileButton.Location = new System.Drawing.Point(12, 148);
            this.SetFileButton.Name = "SetFileButton";
            this.SetFileButton.Size = new System.Drawing.Size(118, 40);
            this.SetFileButton.TabIndex = 0;
            this.SetFileButton.Text = "Choose File";
            this.SetFileButton.UseVisualStyleBackColor = true;
            this.SetFileButton.Click += new System.EventHandler(this.SetFolderButton_Click);
            // 
            // SelectedFileTextbox
            // 
            this.SelectedFileTextbox.Enabled = false;
            this.SelectedFileTextbox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedFileTextbox.Location = new System.Drawing.Point(12, 119);
            this.SelectedFileTextbox.MaxLength = 2147483647;
            this.SelectedFileTextbox.Name = "SelectedFileTextbox";
            this.SelectedFileTextbox.Size = new System.Drawing.Size(606, 23);
            this.SelectedFileTextbox.TabIndex = 1;
            // 
            // EncodingDropdown
            // 
            this.EncodingDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EncodingDropdown.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncodingDropdown.FormattingEnabled = true;
            this.EncodingDropdown.Location = new System.Drawing.Point(12, 50);
            this.EncodingDropdown.Name = "EncodingDropdown";
            this.EncodingDropdown.Size = new System.Drawing.Size(268, 23);
            this.EncodingDropdown.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Output File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Corpus File Encoding";
            // 
            // OKButton
            // 
            this.OKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.Location = new System.Drawing.Point(260, 326);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(118, 40);
            this.OKButton.TabIndex = 6;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // LowercaseCheckbox
            // 
            this.LowercaseCheckbox.AutoSize = true;
            this.LowercaseCheckbox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LowercaseCheckbox.Location = new System.Drawing.Point(15, 222);
            this.LowercaseCheckbox.Name = "LowercaseCheckbox";
            this.LowercaseCheckbox.Size = new System.Drawing.Size(229, 20);
            this.LowercaseCheckbox.TabIndex = 7;
            this.LowercaseCheckbox.Text = "Convert Corpus to Lower Case";
            this.LowercaseCheckbox.UseVisualStyleBackColor = true;
            // 
            // appendFileCheckbox
            // 
            this.appendFileCheckbox.AutoSize = true;
            this.appendFileCheckbox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appendFileCheckbox.Location = new System.Drawing.Point(15, 269);
            this.appendFileCheckbox.Name = "appendFileCheckbox";
            this.appendFileCheckbox.Size = new System.Drawing.Size(177, 20);
            this.appendFileCheckbox.TabIndex = 8;
            this.appendFileCheckbox.Text = "Append to Existing File";
            this.appendFileCheckbox.UseVisualStyleBackColor = true;
            // 
            // SettingsForm_BuildCorpusTXT
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 380);
            this.Controls.Add(this.appendFileCheckbox);
            this.Controls.Add(this.LowercaseCheckbox);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EncodingDropdown);
            this.Controls.Add(this.SelectedFileTextbox);
            this.Controls.Add(this.SetFileButton);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm_BuildCorpusTXT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plugin Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SetFileButton;
        private System.Windows.Forms.TextBox SelectedFileTextbox;
        private System.Windows.Forms.ComboBox EncodingDropdown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.CheckBox LowercaseCheckbox;
        private System.Windows.Forms.CheckBox appendFileCheckbox;
    }
}