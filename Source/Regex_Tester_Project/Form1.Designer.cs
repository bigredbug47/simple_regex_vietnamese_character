namespace Regex_Tester_Project
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.exportFile = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.Error_Box = new System.Windows.Forms.TextBox();
            this.result_tester = new System.Windows.Forms.RichTextBox();
            this.input_pattern = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.exportFile);
            this.panel1.Controls.Add(this.openButton);
            this.panel1.Controls.Add(this.Error_Box);
            this.panel1.Controls.Add(this.result_tester);
            this.panel1.Controls.Add(this.input_pattern);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 410);
            this.panel1.TabIndex = 0;
            // 
            // exportFile
            // 
            this.exportFile.BackColor = System.Drawing.Color.Snow;
            this.exportFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exportFile.Location = new System.Drawing.Point(968, 28);
            this.exportFile.Name = "exportFile";
            this.exportFile.Size = new System.Drawing.Size(75, 23);
            this.exportFile.TabIndex = 3;
            this.exportFile.Text = "Save";
            this.exportFile.UseVisualStyleBackColor = false;
            this.exportFile.Click += new System.EventHandler(this.exportFile_Click);
            // 
            // openButton
            // 
            this.openButton.BackColor = System.Drawing.Color.Snow;
            this.openButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.openButton.Location = new System.Drawing.Point(887, 28);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 3;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = false;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // Error_Box
            // 
            this.Error_Box.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Error_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Error_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error_Box.Location = new System.Drawing.Point(951, 64);
            this.Error_Box.Name = "Error_Box";
            this.Error_Box.Size = new System.Drawing.Size(88, 19);
            this.Error_Box.TabIndex = 2;
            this.Error_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // result_tester
            // 
            this.result_tester.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.result_tester.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_tester.Location = new System.Drawing.Point(10, 91);
            this.result_tester.Name = "result_tester";
            this.result_tester.Size = new System.Drawing.Size(1033, 306);
            this.result_tester.TabIndex = 1;
            this.result_tester.Text = "";
            this.result_tester.TextChanged += new System.EventHandler(this.result_tester_TextChanged);
            // 
            // input_pattern
            // 
            this.input_pattern.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.input_pattern.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.input_pattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_pattern.Location = new System.Drawing.Point(10, 62);
            this.input_pattern.MaxLength = 30000;
            this.input_pattern.Name = "input_pattern";
            this.input_pattern.Size = new System.Drawing.Size(1034, 23);
            this.input_pattern.TabIndex = 0;
            this.input_pattern.TextChanged += new System.EventHandler(this.input_pattern_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Mistral", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(10, 10);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(403, 46);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "REGEX TESTER VIETNAMESE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 411);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Regex Tester Vietnamese";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox input_pattern;
        private System.Windows.Forms.RichTextBox result_tester;
        private System.Windows.Forms.TextBox Error_Box;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button exportFile;
        private System.Windows.Forms.TextBox textBox1;
    }
}

