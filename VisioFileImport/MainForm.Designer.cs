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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Input Folder :";
            // 
            // tb_inputPath
            // 
            this.tb_inputPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_inputPath.Location = new System.Drawing.Point(128, 8);
            this.tb_inputPath.Name = "tb_inputPath";
            this.tb_inputPath.Size = new System.Drawing.Size(680, 22);
            this.tb_inputPath.TabIndex = 1;
            this.tb_inputPath.TextChanged += new System.EventHandler(this.tbInputFolder_TextChanged);
            // 
            // btn_browseInput
            // 
            this.btn_browseInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browseInput.Location = new System.Drawing.Point(128, 36);
            this.btn_browseInput.Name = "btn_browseInput";
            this.btn_browseInput.Size = new System.Drawing.Size(75, 23);
            this.btn_browseInput.TabIndex = 2;
            this.btn_browseInput.Text = "Browse";
            this.btn_browseInput.UseVisualStyleBackColor = true;
            this.btn_browseInput.Click += new System.EventHandler(this.btnBrowseInput_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output File :";
            // 
            // tb_outputPath
            // 
            this.tb_outputPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_outputPath.Location = new System.Drawing.Point(128, 86);
            this.tb_outputPath.Name = "tb_outputPath";
            this.tb_outputPath.Size = new System.Drawing.Size(680, 22);
            this.tb_outputPath.TabIndex = 4;
            this.tb_outputPath.TextChanged += new System.EventHandler(this.tbOutputPath_TextChanged);
            // 
            // btn_browseOutput
            // 
            this.btn_browseOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browseOutput.Location = new System.Drawing.Point(128, 114);
            this.btn_browseOutput.Name = "btn_browseOutput";
            this.btn_browseOutput.Size = new System.Drawing.Size(75, 23);
            this.btn_browseOutput.TabIndex = 5;
            this.btn_browseOutput.Text = "Browse";
            this.btn_browseOutput.UseVisualStyleBackColor = true;
            this.btn_browseOutput.Click += new System.EventHandler(this.btnBrowseOutput_Click);
            // 
            // btn_generate
            // 
            this.btn_generate.Enabled = false;
            this.btn_generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generate.Location = new System.Drawing.Point(692, 133);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(116, 31);
            this.btn_generate.TabIndex = 6;
            this.btn_generate.Text = "Generate";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 176);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.btn_browseOutput);
            this.Controls.Add(this.tb_outputPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_browseInput);
            this.Controls.Add(this.tb_inputPath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visio File Import";
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
    }
}

