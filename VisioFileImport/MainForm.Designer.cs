namespace VisioFileImport
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_inputPath = new System.Windows.Forms.TextBox();
            this.btn_browseInput = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_outputPath = new System.Windows.Forms.TextBox();
            this.btn_browseOutput = new System.Windows.Forms.Button();
            this.btn_generate = new System.Windows.Forms.Button();
            this.fbd_input = new System.Windows.Forms.FolderBrowserDialog();
            this.fbd_output = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Input Folder :";
            // 
            // tb_inputPath
            // 
            this.tb_inputPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_inputPath.Location = new System.Drawing.Point(171, 10);
            this.tb_inputPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_inputPath.Name = "tb_inputPath";
            this.tb_inputPath.Size = new System.Drawing.Size(905, 26);
            this.tb_inputPath.TabIndex = 1;
            this.tb_inputPath.TextChanged += new System.EventHandler(this.tbInputFolder_TextChanged);
            // 
            // btn_browseInput
            // 
            this.btn_browseInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browseInput.Location = new System.Drawing.Point(171, 44);
            this.btn_browseInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_browseInput.Name = "btn_browseInput";
            this.btn_browseInput.Size = new System.Drawing.Size(100, 28);
            this.btn_browseInput.TabIndex = 2;
            this.btn_browseInput.Text = "Browse";
            this.btn_browseInput.UseVisualStyleBackColor = true;
            this.btn_browseInput.Click += new System.EventHandler(this.btnBrowseInput_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output File :";
            // 
            // tb_outputPath
            // 
            this.tb_outputPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_outputPath.Location = new System.Drawing.Point(171, 106);
            this.tb_outputPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_outputPath.Name = "tb_outputPath";
            this.tb_outputPath.Size = new System.Drawing.Size(905, 26);
            this.tb_outputPath.TabIndex = 4;
            this.tb_outputPath.TextChanged += new System.EventHandler(this.tbOutputPath_TextChanged);
            // 
            // btn_browseOutput
            // 
            this.btn_browseOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browseOutput.Location = new System.Drawing.Point(171, 140);
            this.btn_browseOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_browseOutput.Name = "btn_browseOutput";
            this.btn_browseOutput.Size = new System.Drawing.Size(100, 28);
            this.btn_browseOutput.TabIndex = 5;
            this.btn_browseOutput.Text = "Browse";
            this.btn_browseOutput.UseVisualStyleBackColor = true;
            this.btn_browseOutput.Click += new System.EventHandler(this.btnBrowseOutput_Click);
            // 
            // btn_generate
            // 
            this.btn_generate.Enabled = false;
            this.btn_generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generate.Location = new System.Drawing.Point(923, 164);
            this.btn_generate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(155, 38);
            this.btn_generate.TabIndex = 6;
            this.btn_generate.Text = "Generate";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Created by: Alex Meyer (alex.itguy@gmail.com)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 217);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.btn_browseOutput);
            this.Controls.Add(this.tb_outputPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_browseInput);
            this.Controls.Add(this.tb_inputPath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visio File Import - v1.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_inputPath;
        private System.Windows.Forms.Button btn_browseInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_outputPath;
        private System.Windows.Forms.Button btn_browseOutput;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.FolderBrowserDialog fbd_input;
        private System.Windows.Forms.FolderBrowserDialog fbd_output;
        private System.Windows.Forms.Label label3;
    }
}

